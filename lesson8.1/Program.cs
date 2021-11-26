using lesson8._1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Settings.Default.Hello} \t {Settings.Default.Name1}");
            var name = Settings.Default.Name1;
            var age = Settings.Default.Age1.ToString();
            var profession = Settings.Default.Profession1;

            User(name, age, profession);

            NewSetting();

            Settings.Default.Save();
            Console.WriteLine("Для завершения нажмите любую кнопку");
            Console.ReadKey();
        }

        private static void User(string name, string age, string profession)
        {
            if (Check(name))
            {
                Console.WriteLine($"Имя {Settings.Default.Name1}");
            }
            if (Check(age))
            {
                Console.WriteLine($"Возрост {Settings.Default.Age1} лет");
            }
            if (Check(profession))
            {
                Console.WriteLine($"Род деятельности {Settings.Default.Profession1}");
            }
        }

        private static bool Check(string сheck)
        {
            bool Result = false;
            if (сheck != null && сheck != "" && сheck != "0")
            {
                Result = true;
            }
            return Result;
        }

        private static void NewSetting()
        {
            Console.WriteLine("Введите имя");
            Settings.Default.Name1 = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            int.TryParse(Console.ReadLine(), out int Age1);
            Settings.Default.Age1 = Age1;
            Console.WriteLine("Введите род деятельности");
            Settings.Default.Profession1 = Console.ReadLine();
        }
    }
}
