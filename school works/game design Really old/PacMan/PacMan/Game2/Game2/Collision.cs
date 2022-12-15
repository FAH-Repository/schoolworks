using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMaster
{
    public static class Collision
    {
        public struct Segment
        {
            public Point p1;
            public Point p2;
            public Segment(Point a, Point b)
            {
                p1 = a;
                p2 = b;
            }
            public Rectangle CollisionRect()
            {
                return new Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
            }
            public Vector2 GetVector()
            {
                return new Vector2(p2.X - p1.X, p2.Y - p1.Y);
            }
        }
        public static Vector2 GetReflectedVector(Vector2 v, Vector2 u)
        {
            Vector2 n = GetVectorNormal(u);
            float CoEff = (-2 * GetDotProduct(v, n)) / GetMagnitudeSquared(n);
            return v + CoEff * n;

        }
        public static Vector2 GetVectorNormal(Vector2 v)
        {
            return new Vector2(-v.Y, v.X);
        }
        public static float GetDotProduct(Vector2 v, Vector2 u)
        {
            return v.X * u.X + v.Y * u.Y;
        }
        public static float GetMagnitude(Vector2 v)
        {
            return (float)Math.Sqrt(v.X * v.X + v.Y * v.Y);
        }
        public static float GetMagnitudeSquared(Vector2 v)
        {
            return v.X * v.X + v.Y * v.Y;
        }
        public static Vector2 GetUnitVector (Vector2 v)
        {
            return v * (1 / GetMagnitude(v));
        }
    }
}
