using System.Collections.Generic;
namespace Cubes
{
  class Cube
  {
    public List<float[,]> pointsCube { get; set; }
    public Cube(float dCenter, float xMiddle, float yMiddle, float zMiddle)
    {
      float[,] pointsCubeCoor;
      float[,] points;

      pointsCube = new List<float[,]>();

      pointsCubeCoor = new float[,]{
        { xMiddle + (-dCenter / 2), yMiddle + (-dCenter / 2), zMiddle + (-dCenter / 2) },
        { xMiddle + (+dCenter / 2), yMiddle + (-dCenter / 2), zMiddle + (-dCenter / 2) },
        { xMiddle + (-dCenter / 2), yMiddle + (+dCenter / 2), zMiddle + (-dCenter / 2) },
        { xMiddle + (-dCenter / 2), yMiddle + (-dCenter / 2), zMiddle + (+dCenter / 2) },
        { xMiddle + (-dCenter / 2), yMiddle + (+dCenter / 2), zMiddle + (+dCenter / 2) },
        { xMiddle + (+dCenter / 2), yMiddle + (-dCenter / 2), zMiddle + (+dCenter / 2) },
        { xMiddle + (+dCenter / 2), yMiddle + (+dCenter / 2), zMiddle + (-dCenter / 2) },
        { xMiddle + (+dCenter / 2), yMiddle + (+dCenter / 2), zMiddle + (+dCenter / 2) }
      };

      for (int i=0;i<8;i++)
      {
        points = new float[,]{{ pointsCubeCoor[i,0], pointsCubeCoor[i,1], pointsCubeCoor[i,2] }};
        pointsCube.Add(points);
      }

    }
  }
}
