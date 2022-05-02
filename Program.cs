using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lesson 2.3 
            // 3. Консольное меню. 8 баллов.
            /*При помощи всего, что вы изучили, создать приложение, которое может обрабатывать команды.Т.е.вы создаете меню, ожидаете ввода нужной команды, после чего выполняете действие, которое присвоено этой команде.
            Примеры команд(Требуется 4 - 6 команд, придумать самим)
            SetName – установить имя
            ChangeConsoleColor - изменить цвет консоли
            SetPassword – установить пароль
            WriteName – вывести имя(после ввода пароля)
            Esc – выход из программы
            Программа не должна завершаться после ввода, пользователь сам должен выйти из программы при помощи команды.*/

            string userName;
            string userConsoleColor;
            string userPassword;

            bool exitConsole = false;

            Console.WriteLine("ВВедите имя пользователя");
            userName = Console.ReadLine();
            Console.WriteLine("ВВедите цвет консоли: 1 - Blue, 2 - Red");
            int colorCheck = int.Parse(Console.ReadLine());
            switch (colorCheck)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Выбран цвет консоли синий.");
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Выбран цвет консоли красный.");
                    break;
                default:
                    Console.WriteLine("Ошибка, цвет консоли не выбран");
                    break;
            }

            Console.WriteLine("ВВедите пароль пользователя");
            userPassword = Console.ReadLine();

            while (!exitConsole)
            {
                Console.WriteLine("Выберите действие: 1 - вывести имя пользователя, 2 - завершить программу");
                int userOptions = int.Parse(Console.ReadLine());
                switch (userOptions)
                {
                    case 1:
                        Console.WriteLine($"ВВедите пароль пользователя {userName}");
                        string userEnteredPasswd = Console.ReadLine();
                        if(userEnteredPasswd == userPassword)
                        {
                            Console.WriteLine(userName);
                        }
                        else
                        {
                            Console.WriteLine("Wrong Password");
                        }
                        break;
                    case 2:
                        exitConsole = true;
                        break;
                    default:
                        Console.WriteLine("Wrong choice again");
                        break;
                }
            }


        }
    }
}
