using System;
using System.Collections.Generic;
using System.Linq;

namespace Cubes
{
  class Functions
  {
    private static List<float[,]> pointsInsideCube(Cube cubeA, Cube cubeB)
    {
      float[,] pointBMin = cubeB.pointsCube[0];
      float[,] pointBMax = cubeB.pointsCube[7];
      List<float[,]> pointsCollided = new List<float[,]>();

      for (int i = 0; i < 8; i++)
      {
        if ((cubeA.pointsCube[i][0, 0] >= pointBMin[0, 0] && cubeA.pointsCube[i][0, 0] <= pointBMax[0, 0]) &&
            (cubeA.pointsCube[i][0, 1] >= pointBMin[0, 1] && cubeA.pointsCube[i][0, 1] <= pointBMax[0, 1]) &&
            (cubeA.pointsCube[i][0, 2] >= pointBMin[0, 2] && cubeA.pointsCube[i][0, 2] <= pointBMax[0, 2]))
        {
          pointsCollided.Add(cubeA.pointsCube[i]);
        }
      }
      return pointsCollided;
    }

    private static List<float[]> getParallelPlanesToObject(Cube cube,List<float[,]>  pointsCollided)
    {
      List<float[]> parallelPlanes = new List<float[]>();

      if (pointsCollided.Count == 3)//plane
      {
        parallelPlanes = Geometry.getParralelPlanesToPlane(cube.pointsCube, pointsCollided);
      }
      else if (pointsCollided.Count == 2)//line
      {
        parallelPlanes = Geometry.getParralelPlanesToLine(cube.pointsCube, pointsCollided);
      }
      else// point
      {
        parallelPlanes = Geometry.getPlanesFromCube(cube.pointsCube);
      }

      return parallelPlanes;
    }

    private static List<float> heights(Cube bigCube, float segment, List<float[,]> pointsCollided, List<float[,]> pointsNotCollided)
    {
      List<float> height = new List<float>();
      float sumDistancePlane = 0;
      float distanceInside = 0;
      float distanceOutside = 0;
      List<float[]> parallelPlanes = new List<float[]>();

      parallelPlanes = getParallelPlanesToObject(bigCube, pointsCollided);

      distanceInside = (float)Geometry.distancePointPlane(parallelPlanes[0], pointsCollided[0]);
      distanceOutside = (float)Geometry.distancePointPlane(parallelPlanes[0], pointsNotCollided[0]);

      sumDistancePlane = distanceInside + distanceOutside;

      if (segment == sumDistancePlane)//determine witch plane is in between cube and calculate distance
      {   //plane 0 is in between
        height.Add((float)Geometry.distancePointPlane(parallelPlanes[0], pointsCollided[0]));
      }
      else
      {   //plane 1 is in between
        height.Add((float)Geometry.distancePointPlane(parallelPlanes[1], pointsCollided[0]));
      }

      if (parallelPlanes.Count == 4)//compare the other 2 planes
      {
        distanceInside = (float)Geometry.distancePointPlane(parallelPlanes[2], pointsCollided[0]);
        distanceOutside = (float)Geometry.distancePointPlane(parallelPlanes[2], pointsNotCollided[0]);

        sumDistancePlane = distanceInside + distanceOutside;

        if (segment == sumDistancePlane)//determine witch plane is in between cube and calculate distance
        {   //plane 0 is in between
          height.Add((float)Geometry.distancePointPlane(parallelPlanes[2], pointsCollided[0]));
        }
        else
        {   //plane 1 is in between
          height.Add((float)Geometry.distancePointPlane(parallelPlanes[3], pointsCollided[0]));
        }
      }

      return height;

    }

    public static float volumeCollision(float l1, Cube cube1, float l2, Cube cube2)
    {
      float volume;
      List<float> heigth;
      float segment;

      List<float[,]> numCollisionAB = pointsInsideCube(cube1, cube2);
      List<float[,]> numCollisionBA = pointsInsideCube(cube2, cube1);
      List<float> deltas = new List<float>();
      List<float[,]> numCollision = new List<float[,]>();
      List<float[,]> numNotColision = new List<float[,]>();

      Cube cube = new Cube(0, 0, 0, 0);

      if (numCollisionAB.Count == 0 && numCollisionBA.Count == 0) //both are outside
      {
        volume = 0;
      }
      else if (numCollisionAB.Count == 8 && numCollisionBA.Count == 8)//both are the same cube
      {
        volume = l1*l1*l1;
      }
      else
      {
        if (numCollisionAB.Count == 8) // cube1 inside cube2
        {
          volume = l1 * l1 * l1;
        }
        else if (numCollisionBA.Count == 8) // cube2 inside cube1
        {
          volume = l2 * l2 * l2;
        }
        else//partial collision 1,2 or 4 points inside 1 cube into the other IMPORTANT cubes are parallel;
        {

          if (numCollisionAB.Count > numCollisionBA.Count)// cube1 smaller than cube2
          {
            numCollision = numCollisionAB;
            numNotColision = cube1.pointsCube.Where(item => !numCollision.Any(i => i == item)).ToList();
            cube = cube2;
          }
          else if(numCollisionAB.Count == numCollisionBA.Count)//point inside each cube
          {
            numCollision.Add(numCollisionAB[0]);
            numCollision.Add(numCollisionBA[0]);
            numNotColision = cube1.pointsCube.Where(item => !numCollision.Any(i => i == item)).ToList();
            cube = cube1;
          }
          else// cube2 smaller than cube1
          {
            numCollision = numCollisionBA;
            numNotColision = cube2.pointsCube.Where(item => !numCollision.Any(i => i == item)).ToList();
            cube = cube1;
          }

          deltas = Geometry.getDeltas(numCollision);
          segment = (float)Math.Sqrt(deltas[0] * deltas[0] + deltas[1] * deltas[1] + deltas[2] * deltas[2]);

          if (numCollisionAB.Count == 4 || numCollisionBA.Count == 4)//plane inside big cube
          {
            heigth = heights(cube, segment, numCollision, numNotColision);
            volume = segment * segment * heigth[0];
          }
          else if ((numCollisionAB.Count == 2 || numCollisionBA.Count == 2)&&(numCollisionAB.Count != 1 && numCollisionBA.Count != 1))//line inside big cube
          {
            heigth = heights(cube, segment, numCollision, numNotColision);
            volume = segment * heigth[0] * heigth[1];
          }
          else//point inside cube
          {//volume usign diagonal points
            volume = (float)Math.Pow((segment / (float)Math.Sqrt(3)), 3);
          }
        }
      }
      return volume;
    }

  }
}
