using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Kill
    {
        public
        int A, B;
        public
        void Vibor_zashit()
        {
            Random rand = new Random();
            A = rand.Next(1, 4);
            Console.WriteLine(" Рандомное число  " + A);
        }
        public
        void Ydar()
        {
            Console.WriteLine("Введите куда вы хотите направить удар ? \"Голова\", \"Торс\" или \"Ноги\" ");
            string P;
            P = Console.ReadLine();
            switch (P)
            {
                case "Голова":
                    B = 1;
                break;
                case "Торс":
                    B = 2;
                break;
                case "Ноги":
                    B = 3;
                break;
                default:
                B = A;
                Console.WriteLine("Ты проиграл! Что б ЗНАЛЛЛЛ...!!!  :D");
                break;

            }
        }
        public
        void Block()
        {
            Console.WriteLine("Что хотите защитить? \"Голова\", \"Торс\" или \"Ноги\" ");
            string P;
            P = Console.ReadLine();
            switch (P)
            {
                case "Голова":
                    B = 1;
                    break;
                case "Торс":
                    B = 2;
                    break;
                case "Ноги":
                    B = 3;
                    break;
                default:
                    B = 0;
                    Console.WriteLine("Тебя ждет боль :(");
                    break;

            }
        }
        public
        void Ataka()
        {
            if (B != A)
            {
                Console.WriteLine("Ты победил!");
            }
            else
            {
                Console.WriteLine("Проигрышь");
            }
        }
        public
        void Zashita()
        {
            if (A != B)
            {
                Console.WriteLine("Struck");
            }
            else
            {
                Console.WriteLine("Victory!");
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            Console.WriteLine("Привет, пользователь! Хочу сыграть с тобой в игру:)");
            Proba:
            Console.WriteLine("Выберите! Вы будешь атаковать или защищаться?");
            Console.WriteLine("В соответствии с выбором, нажмите 1 или 2");

            d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case 1:
                     Kill S = new Kill();
                     S.Vibor_zashit();
                     S.Ydar();
                     S.Ataka();
                break;
                case 2:
                    Kill W = new Kill();
                    W.Block();
                    W.Vibor_zashit();
                    W.Zashita();
                    break;
                default:
                    Console.WriteLine("Вы можете вводить 1 или 2");
                    break;
            } 
            Console.WriteLine("Введите 0, если хотите выйти =(");
            d = Convert.ToInt32(Console.ReadLine());
            if(d != 0)
            {
            Console.Clear();
            goto Proba;

            }
        }
    }
    
}
