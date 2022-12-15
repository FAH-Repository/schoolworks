using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bricks
{
    public static class Collision
    {
        public struct Segment
        {
            public Vector2 p1;
            public Vector2 p2;
            public Segment(Vector2 a, Vector2 b)
            {
                p1 = a;
                p2 = b;
            }
            public Rectangle CollisionRect()
            {
                return new Rectangle(Math.Min((int)p1.X, (int)p2.X), Math.Min((int)p1.Y, (int)p2.Y), Math.Abs((int)p1.X - (int)p2.X), Math.Abs((int)p1.Y - (int)p2.Y));
            }
            public Vector2 GetVector()
            {
                return new Vector2(p2.X - p1.X, p2.Y - p1.Y);
            }
        }
        public struct Line2D
        {
            public Vector2 v;
            public Vector2 p;

            public float yInt()
            {
                return (-v.Y * p.X + v.X * p.Y) / v.X;
            }
            public float Slope()
            {
                return v.Y / v.X;
            }
        }

        public struct circle {
            public Vector2 P;
            public double R;
            public circle (Vector2 p, double r) {
                P = p;
                R = r;
            }
        }
        public static bool CheckSegmentSegmentCollision(Segment S1, Segment S2)
        {
            Line2D L1, L2;
            L1.p = S1.p1;
            L2.p = S2.p1;
            L1.v = S1.p2 - S1.p1;
            L2.v = S2.p2 - S2.p1;
            Vector2 collisionPoint;
            collisionPoint.X = (L2.yInt() - L1.yInt()) / (L1.Slope() - L2.Slope());
            collisionPoint.Y = L1.Slope() * collisionPoint.X + L1.yInt();
            bool cond1 = Math.Min(S1.p1.X, S1.p2.X) <= collisionPoint.X && Math.Max(S1.p1.X, S1.p2.X) >= collisionPoint.X;
            bool cond2 = Math.Min(S2.p1.X, S2.p2.X) <= collisionPoint.X && Math.Max(S2.p1.X, S2.p2.X) >= collisionPoint.X;
            bool cond3 = Math.Min(S1.p1.Y, S1.p2.Y) <= collisionPoint.Y && Math.Max(S1.p1.Y, S1.p2.Y) >= collisionPoint.Y;
            bool cond4 = Math.Min(S2.p1.Y, S2.p2.Y) <= collisionPoint.Y && Math.Max(S2.p1.Y, S2.p2.Y) >= collisionPoint.Y;
            return cond1 && cond2 && cond3 && cond4;
        }

        public static bool CheckCircleSegmentCollision(circle C, Segment S) {
            Line2D L;
            L.p = S.p1;
            L.v = S.p2 - S.p1;
            double OH = Math.Abs((L.v.X * (C.P.Y - L.p.Y) - L.v.Y * (C.P.X - L.p.X)) / GetMagnitude(L.v));
            if (OH <= C.R) {
                Vector2 collisionPoint1, collisionPoint2;
                if (L.v.X != 0) {
                    double Dv = L.v.Y / L.v.X;
                    double E = (L.v.X * L.p.Y - L.v.Y * L.p.X) / L.v.X - C.P.Y;

                    double a = 1 + Dv * Dv;
                    double b = -2 * C.P.X + 2 * E * Dv;
                    double c = C.P.X * C.P.X + E * E - C.R * C.R;

                    collisionPoint1.X = (float)SolveQuadratic(a, b, c, true);
                    collisionPoint2.X = (float)SolveQuadratic(a, b, c, false);
                    collisionPoint1.Y = L.Slope() * collisionPoint1.X + L.yInt();
                    collisionPoint2.Y = L.Slope() * collisionPoint2.X + L.yInt();

                    bool cond1 = Math.Min(S.p1.X, S.p2.X) <= collisionPoint1.X && Math.Max(S.p1.X, S.p2.X) >= collisionPoint1.X;
                    bool cond2 = Math.Min(S.p1.X, S.p2.X) <= collisionPoint2.X && Math.Max(S.p1.X, S.p2.X) >= collisionPoint2.X;
                    bool cond3 = Math.Min(S.p1.Y, S.p2.Y) <= collisionPoint1.Y && Math.Max(S.p1.Y, S.p2.Y) >= collisionPoint1.Y;
                    bool cond4 = Math.Min(S.p1.Y, S.p2.Y) <= collisionPoint2.Y && Math.Max(S.p1.Y, S.p2.Y) >= collisionPoint2.Y;
                    return (cond1 && cond3) || (cond2 && cond4);
                }
            }
            return false;
        }

        public static double SolveQuadratic(double a, double b, double c, bool pos) {
         // pos = true for +, false for -
         if (pos) {
                return (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            }
            return (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
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
        public static Vector2 GetUnitVector(Vector2 v)
        {
            return v * (1 / GetMagnitude(v));
        }
    }
}