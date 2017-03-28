using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarleyBreakApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Game3 game = new Game3(3);
            game.Print();

          

            int oper = 0;

            do
            {
                Console.WriteLine("1.Сделать след шаг");
                Console.WriteLine("2.Отменить шаг");
                Console.WriteLine("3.Выход");

                oper = int.Parse(Console.ReadLine());

                switch (oper)
                {
                    case 1:
                        {
                            try
                            {
                                Console.WriteLine("Введите значение перемещаемого элемента ");
                                int val = int.Parse(Console.ReadLine());

                                game.Shift(val);

                                game.SaveHystory(val);

                                game.Print();

                                bool isCheck = game.CheckGameEnd();

                                if (isCheck)
                                {
                                    Console.WriteLine("Игра закончена. You WIN!");
                                    oper = 3;
                                }
                            }
                            catch (Exception exc)
                            {
                                Console.WriteLine(exc.Message);
                            }
                        }
                        break;
                    case 2:
                        game.Undo();
                        game.Print();
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            }
            while (oper != 3);

            Console.WriteLine("Вы хотите просмотреть историю ходов? Да(Y)/Нет(N)");
            string ch = Console.ReadLine();

            switch (ch)
            {
                case "Y":
                    game.ShowHystory();
                    break;
            }

            Console.ReadKey();
        }
    }
}
