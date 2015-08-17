using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static void Main()
        {
            long diap = 2323201302194;
            Brute(diap);
        }


        public static void Brute(long diap)
        {
            int n = 68491; //задаем некое число
            NewMessage("w8. Bruteforce working..."); //вызываем событие
            for (int i = 0; i < diap; i++) //мутим цикл
            {
                int d = i;
                int bug = 0;
                string brute = Convert.ToString(bug.Equals(n)); //сравниваем и возвращаем результат в строку

                if (brute == "True")
                {
                    BruteComplete(d.ToString()); //вызываем событие при удачном переборе
                    break;
                }
            }

            bool ok = true;

            if (ok == false)
            {
                NewMessage("Brete Failed:(");
            }
        }

        private static void BruteComplete(string toString)
        {
        }

        private static void NewMessage(string w8BruteforceWorking)
        {
        }
    }
}
