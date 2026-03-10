using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_solid_principles
{
    #region invalid implementation

    //public class Triangle
    //{
    //    public virtual string GetShape()
    //    {
    //        return "Triangle";
    //    }
    //}

    //public class Circle : Triangle
    //{
    //    public override string GetShape()
    //    {
    //        return "Circle";
    //    }
    //}
    #endregion

    #region valid implementation

    public abstract class Shape
    {
        public abstract string GetShape();
    }

    public class Triangle : Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }

    public class Circle : Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
    #endregion
}
