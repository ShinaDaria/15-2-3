using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarleyBreakApp
{
    public class Game3 : Game2
    {
        List<string> listHys = new List<string>();

        public void SaveHystory(int val)
        {
            Point point = GetLocation(val);

            listHys.Add(string.Format("{0} => {1}:{2}", val, point.X, point.Y));
        }

        public void Undo()
        {
            if (listHys.Count > 0)
            {
                string last = listHys[listHys.Count - 1];

                int val = int.Parse(last[0].ToString());
                Shift(val);

                listHys.RemoveAt(listHys.Count - 1);
            }
        }

        public void ShowHystory()
        {
            foreach (var item in listHys)
            {
                Console.WriteLine(item);
            }
        }

        public Game3(int n) : base(n)
        {
        }
    }
}
