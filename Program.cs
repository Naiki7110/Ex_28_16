
using System;
using System.Net;

namespace Ex_28_16_naitouibuki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ans;
            Console.WriteLine("三角柱の底面積の求め方を選択してください\n3辺の長さ:1\n底辺の長さと底辺の高さ:2");
            ans = int.Parse(Console.ReadLine());
            if (ans == 1)
            {
                Console.WriteLine("3辺の長さ");
                Console.WriteLine("1つ目の辺の長さ");
                var length1 = float.Parse(Console.ReadLine());
                Console.WriteLine("2つ目の辺の長さ");
                var length2 = float.Parse(Console.ReadLine());
                Console.WriteLine("3つ目の辺の長さ");
                var length3 = float.Parse(Console.ReadLine());
                Console.WriteLine("三角柱の高さ");
                var top = float.Parse(Console.ReadLine());
                TriangularPrism triangularprism = new TriangularPrism(length1, length2, length3, top);
                Console.WriteLine($"答え{triangularprism.GetVolueme()}");
            }
            else if (ans == 2)
            {
                Console.WriteLine("底辺");
                var bottom = float.Parse(Console.ReadLine());
                Console.WriteLine("三角形の高さ");
                var triangleheight = float.Parse(Console.ReadLine());
                Console.WriteLine("高さ");
                var top = float.Parse(Console.ReadLine());
                TriangularPrism triangularprism = new TriangularPrism(bottom, triangleheight, top);


                Console.WriteLine($"答え{triangularprism.GetSurface()}");
                
            }
        }
       
        class TriangularPrism
        {
            float bottom;
            float triangleheight;
            float top;
            float length1;
            float length2;
            float length3;
            float l;
            float s;
            public TriangularPrism(float bottom, float triangleheight, float top)
            {
                this.bottom = bottom;
                this.triangleheight = triangleheight;
                this.top = top;
                bottom = triangleheight * triangleheight / 2;
                l = triangleheight + triangleheight + (float)Math.Sqrt(triangleheight * triangleheight + triangleheight * triangleheight) * top;
            }
            public TriangularPrism(float length1, float length2, float length3, float top)
            {
                this.length1 = length1;
                this.length2 = length2;
                this.length3 = length3;
                this.top = top;
                s = (length1 + length2 + length3) / 2;
                bottom = (float)Math.Sqrt(s * ((s - length1) * (s - length2) * (s - length3)));
                l = (length1 + length2 + length3) * top;
            }
            public float GetSurface()
            {
                return bottom * 2 + l;
            }
            public float GetVolueme()
            {
                return bottom * top;
            }
            
        }


    }
}