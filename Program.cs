using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Vector 
//X, Y , Z
//+ - * /
//== !=
//> <
//>=  <=
//ToString
//Equals

namespace ConsoleApp30
{
    //#region MyRegion


    //class Point
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }

    //    public static Point operator ++(Point point)
    //    {
    //        point.X++;
    //        point.Y++;
    //        return point;
    //    }


    //    public static Point operator --(Point point)
    //    {
    //        point.X--;
    //        point.Y--;
    //        return point;
    //    }

    //    public static Point operator +(Point p1, Point p2)
    //    {
    //        return new Point { X = p1.X + p2.X, Y = p1.Y + p2.Y };
    //    }

    //    public static Point operator -(Point p1, Point p2)
    //    {
    //        return new Point { X = p1.X - p2.X, Y = p1.Y - p2.Y };
    //    }

    //    public override string ToString()
    //    {
    //        return $"X : {X} Y : {Y}";
    //    }

    //    public static bool operator ==(Point p1, Point p2)
    //    {
    //        return p1.Equals(p2);
    //    }

    //    public static bool operator !=(Point p1, Point p2)
    //    {
    //        return !p1.Equals(p2);
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is Point p)
    //        {
    //            return this.X == p.X && this.Y == p.Y;
    //        }
    //        return false;
    //    }
    //}
    //#endregion
    public class Vector
    {
        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public static Vector operator+(Vector v1,Vector v2)
        {
            int x = v1.X + v2.X;
            int y = v1.Y + v2.Y;
            int z = v1.Z + v2.Z;
            return new Vector ( x,  y, z );
        }
        public static Vector operator-(Vector v1,Vector v2)
        {
            int x = v1.X - v2.X;
            int y = v1.Y - v2.Y;
            int z = v1.Z - v2.Z;
            return new Vector ( x,  y, z );
        }
        public static Vector operator*(Vector v1,Vector v2)
        {
            int x = v1.X * v2.X;
            int y = v1.Y * v2.Y;
            int z = v1.Z * v2.Z;
            return new Vector ( x,  y, z );
        }
        public static Vector operator/(Vector v1,Vector v2)
        {
            if (v2.X == 0 || v2.Y == 0 || v2.Z == 0)
            {
                throw new DivideByZeroException();
            }
            int x = v1.X / v2.X;
            int y = v1.Y / v2.Y;
            int z = v1.Z / v2.Z;
            return new Vector(x,y,z);
        }

        public override string ToString()
        {
            return $"X : {this.X}\nY : {this.Y}\nZ : {Z}\n";
        }
        public override bool Equals(object obj)
        {
            if (obj is Vector v)//if obj equals to Vector write it to 'v'
            {
                return this.X == v.X && this.Y == v.Y && this.Z == v.Z;
            }
            return false;
        }
        public static  bool operator==(Vector v1, Vector v2)
        {
            return v1.Equals(v1);
        }
        public static  bool operator!=(Vector v1, Vector v2)
        {
            return !v1.Equals(v1);
        }

        public static bool operator>(Vector v1, Vector v2)
        {
            int sum1 = v1.X + v1.Y + v1.Z;
            int sum2 = v2.X + v2.Y + v2.Z;
            return sum1 > sum2;
        }
         public static bool operator<(Vector v1, Vector v2)
        {
            int sum1 = v1.X + v1.Y + v1.Z;
            int sum2 = v2.X + v2.Y + v2.Z;
            return sum1 < sum2;
        }
        public static bool operator<=(Vector v1, Vector v2)
        {
            int sum1 = v1.X + v1.Y + v1.Z;
            int sum2 = v2.X + v2.Y + v2.Z;
            return sum1 <=sum2;
        }
        public static bool operator>=(Vector v1, Vector v2)
        {
            int sum1 = v1.X + v1.Y + v1.Z;
            int sum2 = v2.X + v2.Y + v2.Z;
            return sum1 >=sum2;
        }


    }
    public  class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(2,4,0);
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.ToString());
            if (v1.Equals(v2))
            {
                Console.WriteLine("YES They are equal\n");
            }
            else
            {
                Console.WriteLine("NO They are not equal\n");
            }
            Vector result = v1 / v2;
            Console.WriteLine(result.ToString());

        }
    }
}
