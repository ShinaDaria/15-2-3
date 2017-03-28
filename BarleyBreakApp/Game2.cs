using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarleyBreakApp
{
    public class Game2 : Game
    {
        public bool CheckGameEnd()
        {
            int size = (int)Math.Pow(_n, 2);

            int[] a = new int[size];

            int index = 0;

            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    a[index] = _arr[i, j];
                    index++;
                }
            }

            if (a[size-1] == 0)
            {
                size--;
            }

            bool success = true;

            for (int i = 0; i < size - 1; i++)
            {
                if (a[i] > a[i+1])
                {
                    success = false;
                    break;
                }
            }

            return success;
        }

        public Game2(int n) : base(n)
        {
        }
    }
}
