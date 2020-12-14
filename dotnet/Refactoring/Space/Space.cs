using System;
using System.Collections.Generic;

namespace Refactoring
{
    public class Space
    {
        private List<Dot> Dots = new List<Dot>();

        public void Add(IReadOnlyCollection<Dot> dots) => this.Dots.AddRange(dots);

        public void Clear() => this.Dots.Clear();

        public bool IsStraightLine()
        {
            if (this.Dots.Count < 2)
            {
                return false;
            }

            if (this.Dots.Count == 2)
            {
                return true;
            }

            var deltaX = this.Dots[1].X - this.Dots[0].X;
            var deltaY = this.Dots[1].Y - this.Dots[0].Y;
            var deltaZ = this.Dots[1].Z - this.Dots[0].Z;

            for (var index = 1; index < this.Dots.Count; index++)
            {
                var currentDot = this.Dots[index];
                var previousDot = this.Dots[index - 1];

                var currentDeltaX = currentDot.X - previousDot.X;
                var currentDeltaY = currentDot.Y - previousDot.Y;
                var currentDeltaZ = currentDot.Z - previousDot.Z;

                var coeffX = deltaX == 0 ? currentDeltaX : currentDeltaX / deltaX;
                var coeffY = deltaY == 0 ? currentDeltaY : currentDeltaY / deltaY;
                var coeffZ = deltaZ == 0 ? currentDeltaZ : currentDeltaZ / deltaZ;

                if (coeffX != coeffY || coeffX != coeffZ || coeffY != coeffZ)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsEquilateralTriangle()
        {
            if (this.Dots.Count != 3)
            {
                return false;
            }

            var deltaX01 = this.Dots[1].X - this.Dots[0].X;
            var deltaY01 = this.Dots[1].Y - this.Dots[0].Y;
            var deltaZ01 = this.Dots[1].Z - this.Dots[0].Z;

            var deltaX12 = this.Dots[2].X - this.Dots[1].X;
            var deltaY12 = this.Dots[2].Y - this.Dots[1].Y;
            var deltaZ12 = this.Dots[2].Z - this.Dots[1].Z;

            var deltaX20 = this.Dots[0].X - this.Dots[2].X;
            var deltaY20 = this.Dots[0].Y - this.Dots[2].Y;
            var deltaZ20 = this.Dots[0].Z - this.Dots[2].Z;

            // On compare ici les distances au carré pour éviter les problèmes d'arrondi avec Math.sqrt
            var squareDistance01 = (Math.Pow(deltaX01, 2) + Math.Pow(deltaY01, 2) + Math.Pow(deltaZ01, 2));
            var squareDistance12 = (Math.Pow(deltaX12, 2) + Math.Pow(deltaY12, 2) + Math.Pow(deltaZ12, 2));
            var squareDistance20 = (Math.Pow(deltaX20, 2) + Math.Pow(deltaY20, 2) + Math.Pow(deltaZ20, 2));

            return squareDistance01 == squareDistance12 && squareDistance12 == squareDistance20;
        }

        public bool IsSquareTriangle()
        {
            if (this.Dots.Count != 3)
            {
                return false;
            }

            var deltaX01 = this.Dots[1].X - this.Dots[0].X;
            var deltaY01 = this.Dots[1].Y - this.Dots[0].Y;
            var deltaZ01 = this.Dots[1].Z - this.Dots[0].Z;

            var deltaX12 = this.Dots[2].X - this.Dots[1].X;
            var deltaY12 = this.Dots[2].Y - this.Dots[1].Y;
            var deltaZ12 = this.Dots[2].Z - this.Dots[1].Z;

            var deltaX20 = this.Dots[0].X - this.Dots[2].X;
            var deltaY20 = this.Dots[0].Y - this.Dots[2].Y;
            var deltaZ20 = this.Dots[0].Z - this.Dots[2].Z;

            var squareDistance01 = Math.Pow(deltaX01, 2) + Math.Pow(deltaY01, 2) + Math.Pow(deltaZ01, 2);
            var squareDistance12 = Math.Pow(deltaX12, 2) + Math.Pow(deltaY12, 2) + Math.Pow(deltaZ12, 2);
            var squareDistance20 = Math.Pow(deltaX20, 2) + Math.Pow(deltaY20, 2) + Math.Pow(deltaZ20, 2);


            return (squareDistance01) == ((squareDistance12) + (squareDistance20))
                || (squareDistance12) == ((squareDistance20) + (squareDistance01))
                || (squareDistance20) == ((squareDistance12) + (squareDistance01));
        }
    }
}
