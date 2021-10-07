using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonOA
{
    class KthClosestElement
    {
        class PointsDistance
        {
            public int x;
            public int y;
            public int distance;
        }

        public static int[][] KClosest1(int[][] points, int k)
        {
            int n = points.Length;
            var pointsDistance = new PointsDistance[n];

            for (int i = 0; i < n; i++)
            {
                int x = points[i][0];
                int y = points[i][1];
                pointsDistance[i] = new PointsDistance { x = x, y =y, distance = (x * x) + (y * y) };
            }

            Array.Sort(pointsDistance, (point1, point2) => { return point1.distance - point2.distance; });

            int[][] OutputArray = new int[k][];
            for (int i = 0; i < k; i++)
            {
                OutputArray[i][0] = pointsDistance[i].x;
                OutputArray[i][1] = pointsDistance[i].y;
            }

            return OutputArray;


        }
        public static int[][] KClosest(int[][] points, int k)
        {
            int n = points.Length;
            int[][] OutputArray = new int[k][];
            int[] distance = new int[points.Length];
            for(int i = 0; i < n; i++)
            {
                int x = points[i][0];
                int y = points[i][1];
                distance[i] = (x * x) + (y * y);
                  
            }
            Array.Sort(distance);

            int distk = distance[k - 1];
            for(int i = 0; i < n; i++)
            {
                int iter = 0;
                int x = points[i][0];
                int y = points[i][1];
                int dist = (x * x) + (y * y);
                if (dist <= distk )
                {
                    OutputArray[iter][0] =x;
                    OutputArray[iter][1] = y;
                    iter++;
                }

            }
            return OutputArray;


        }

    }
    
}
