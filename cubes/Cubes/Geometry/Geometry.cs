using System;
using System.Collections.Generic;

namespace Cubes
{
  class Geometry
  {
    public static double distancePointPlane(float[] plane, float[,] point)
    {
      return (Math.Abs(plane[0] * point[0, 0] + plane[1] * point[0, 1] + plane[2] * point[0, 2] + plane[3])) / (Math.Sqrt(plane[0] * plane[0] + plane[1] * plane[1] + plane[2] * plane[2]));
    }

    private static float[] ecuationsPlane(List<float[,]> points)
    {

      float[] equationValues = new float[4];
      float a1;
      float b1;
      float c1;
      float a2;
      float b2;
      float c2;

      a1 = points[1][0, 0] - points[0][0, 0];
      b1 = points[1][0, 1] - points[0][0, 1];
      c1 = points[1][0, 2] - points[0][0, 2];
      a2 = points[2][0, 0] - points[0][0, 0];
      b2 = points[2][0, 1] - points[0][0, 1];
      c2 = points[2][0, 2] - points[0][0, 2];

      equationValues[0] = (b1 * c2 - b2 * c1);
      equationValues[1] = (a2 * c1 - a1 * c2);
      equationValues[2] = (a1 * b2 - b1 * a2);
      equationValues[3] = ((-equationValues[0] * points[0][0, 0] - equationValues[1] * points[0][0, 1] - equationValues[2] * points[0][0, 2]));
        
      return equationValues;
    }

    public static List<float[]> getPlanesFromCube(List<float[,]> points)
    {
      List<float[]> planesEcuations = new List<float[]>();
      List<float[,]> pointsA = new List<float[,]>();
      List<float[,]> pointsB = new List<float[,]>();
      List<float[,]> pointsC = new List<float[,]>();
      List<float[,]> pointsD = new List<float[,]>();
      List<float[,]> pointsE = new List<float[,]>();
      List<float[,]> pointsF = new List<float[,]>();

      pointsA.AddRange(new List<float[,]>() { points[0], points[1], points[2] });
      pointsB.AddRange(new List<float[,]>() { points[7], points[5], points[4] });
      pointsC.AddRange(new List<float[,]>() { points[7], points[6], points[5] });
      pointsD.AddRange(new List<float[,]>() { points[0], points[2], points[3] });
      pointsE.AddRange(new List<float[,]>() { points[0], points[1], points[3] });
      pointsF.AddRange(new List<float[,]>() { points[7], points[6], points[4] });

      //plane XY
      planesEcuations.Add(ecuationsPlane(pointsA));
      planesEcuations.Add(ecuationsPlane(pointsB));
      //plane YZ
      planesEcuations.Add(ecuationsPlane(pointsC));
      planesEcuations.Add(ecuationsPlane(pointsD));
      //plane XZ
      planesEcuations.Add(ecuationsPlane(pointsE));
      planesEcuations.Add(ecuationsPlane(pointsF));
      return planesEcuations;
    }

    public static List<float[]> getParralelPlanesToPlane(List<float[,]> points, List<float[,]>pointsInside)
    {
      List<float[]> parallelPlanes = new List<float[]>();
      List<float[]> planesCube = getPlanesFromCube(points);
      float[] planeInside = ecuationsPlane(pointsInside);

      int count;

      for(int i=0;i< planesCube.Count-1;i=i+2)
      {
        count = 0;
        for (int j = 0; j < 3; j ++)
        {
          if (planesCube[i][j] == planeInside[j])
          {
            count++;
          };
          if (count == 2)
          {
            parallelPlanes.Add(planesCube[i]);
            parallelPlanes.Add(planesCube[i+1]);
          }
        }
      }
      return parallelPlanes;
    }

    public static List<float[]> getParralelPlanesToLine(List<float[,]> points, List<float[,]> pointsInside)
    {
      List<float[]> parallelPlanes = new List<float[]>();
      List<float[]> planesCube = getPlanesFromCube(points);

      if(pointsInside[1][0, 0] - pointsInside[0][0, 0] > 0)//aling to X axis
      {
        parallelPlanes.AddRange(new List<float[]>() { planesCube[0], planesCube[1], planesCube[4], planesCube[5] });
      }
      else if (pointsInside[1][0, 1] - pointsInside[0][0, 1] > 0)//align to Y axis
      {
        parallelPlanes.AddRange(new List<float[]>() { planesCube[0], planesCube[1], planesCube[2], planesCube[3] });
      }
      else//align to z axis
      {
        parallelPlanes.AddRange(new List<float[]>() { planesCube[2], planesCube[3], planesCube[4], planesCube[5] });
      }

      return parallelPlanes;
    }

    public static List<float> getDeltas(List<float[,]> points)
    {
      List<float> deltas = new List<float>();

      deltas.Add(points[1][0, 0] - points[0][0, 0]);
      deltas.Add(points[1][0, 1] - points[0][0, 1]);
      deltas.Add(points[1][0, 2] - points[0][0, 2]);

      return deltas;
    }
  }
}
