using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public static class TriangleValidator
    {
        public static bool Validate(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("wrong data");
            }

            if (a + b > c)
            {
                if (a + c > b)
                {
                    if (b + c > a)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
