using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp
    {
        //Присваиваем переменным фамилии из списка сотрудников. S- сокращенно сотрудник.
        string s1 = "Иванов И.И";
        string s2 = "Зиронов Т.А";
        string s3 = "Миронов А.В";
        string s4 = "Васильев В.И";
        //Это переменная для ввода пользователем
        string s5 = "";
        /// <summary>
        /// данный метод возвращает ФИО
        ///главного инспектора автоинспекции
        /// </summary>
        /// <returns></returns>
        static public string GetInspector()
        {
            //Вывод ФИО главного инспектора
            string GetInsp = "Васильев Василий Иванович";
            Console.WriteLine($"Главный инспектор - {GetInsp}");
            Console.ReadLine();
            return GetInsp;
        }
        /// <summary>
        /// данный метод возвращает список сотрудников
        /// </summary>
        /// <returns></returns>
        public void GetWorker()
        {
            //Выводит список сотрудников
            Console.WriteLine("Полный список сотрудников:");
            Console.WriteLine($"{s1}");
            Console.WriteLine($"{s2}");
            Console.WriteLine($"{s3}");
            Console.WriteLine($"{s4}");
            Console.WriteLine($"{s5}");
        }
        /// <summary>
        /// данный метод возвращает название автоинспекции.
        /// </summary>
        /// <returns></returns>
        static public string GetСarInspection()
        {
            //Выводит название 
            string GetCar = "Автоинспекция г. Чита";
            Console.WriteLine($"Название - {GetCar}");
            Console.ReadLine();
            return GetCar;
        }
        /// <summary>
        /// данный метод изменяет ФИО
        ///главного инспектора, только если данное ФИО есть в списке сотрудников.
        /// </summary>
        /// <returns></returns>
        public string SetInspector(string fullname)
        {
            //Пользователь вводит ФИО из списка, чтобы сменить главного инспектора
            Console.WriteLine("Введите ФИО из списка сотрудников, чтобы сменить главного инспектора");
            fullname = Console.ReadLine();
            //Если ФИО, которое ввел пользователь совпало со всеми фамилиями из списка, то
            if (fullname == s1 || fullname == s2 || fullname == s3 || fullname == s4)
            {
                //Он выводит след.сообщение:
                Console.WriteLine($"Отныне, главный инспектор - {fullname}");
            }
            else
            {
                //Иначе он выводит это
                Console.WriteLine("Такого человека нет в списке сотрудников!");
            }
            Console.ReadLine();
            return fullname;
            
        }
        /// <summary>
        /// данный метод
        ///формирует из принимаемых аргументов госномер
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        static public void GenerateNumber( int number, string symbol, int code)
        {
            //Писваиваем переменной значение, переводя ее в нужный тип
            code = Convert.ToInt32("75");
            Console.WriteLine("Введите Символ");
            //Присваиваем то, что ввел пользователь
            symbol = Console.ReadLine();
            //С помощью это функции все символы буду с заглавной буквы
            symbol = symbol.ToUpper();
            Console.WriteLine("Введите трехзначное число");
            //Присваиваем то, что ввел пользователь
            number = Convert.ToInt32(Console.ReadLine());
            //Выводим окончательный госномер из того, что получилось
            Console.WriteLine($"Ваш госномер - {symbol}{number}_{code}");
            Console.ReadLine();
        }
        /// <summary>
        /// данный метод добавляет нового
        ///сотрудника в список сотрудников.
        /// </summary>
        /// <returns></returns>
        public string AddWorker()
        {
            Console.WriteLine("Введите ФИО, которое вы хотите добавить в список сотрудников");
            //Присваиваем то, что ввел пользователь
            string Newn = Console.ReadLine();
            //В переменную присваиваем значение другой переменной 
            s5 = Newn;
            Console.WriteLine("Успешно добавлен в список сотрудников:");
            Console.WriteLine($"{s1}");
            Console.WriteLine($"{s2}");
            Console.WriteLine($"{s3}");
            Console.WriteLine($"{s4}");
            Console.WriteLine($"{s5}");
            return Newn;
        }
       
    }

}
