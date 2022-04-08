using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUser
{
    public class User
    {
        private int A, B, X;
        public User(int a, int b, int x)
        {
            A = a;
            B = b;
            X = x;
            if (A > 1 && B == 0)
            {
                X = X / A;
            }
            else
            {
                if (A == 2 || X > 1)
                {
                    X = X + 1;
                }
            }
        }
    }

}
