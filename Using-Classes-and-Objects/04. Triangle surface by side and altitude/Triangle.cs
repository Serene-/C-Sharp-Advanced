using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_surface_by_side_and_altitude
{
    class Triangle
    {
        private float a;
        private float Ha;
        public Triangle(float a,float Ha)
        {
            this.a = a;
            this.Ha = Ha;
        }
        public float Surface()
        {
            float surface=(a*Ha)/2;
            return surface;
        }


    }
}
