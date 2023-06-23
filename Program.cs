namespace Hometask3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            //1. Напишіть програму, яка приймає від користувача два цілі числа і виводить їх ділення.
            //   Якщо друге число дорівнює нулю, програма повинна вивести повідомлення про помилку.
            Console.WriteLine("Завдання №1");
            int num1, num2;
            Console.Write("Перше число: ");
            while (true) // num1 input
            {
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write("Перше число: ");
                }
            }
            Console.Write("Друге число: ");
            while (true) // num2 input
            {
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("Помилка! Ділення на нуль.");
                        Console.Write("Друге число: ");
                        continue;
                    } 
                    break;
                }
                catch (Exception)
                {
                    Console.Write("Друге число: ");
                }
            }
            Divide(num1, num2);

            //2. Напишіть метод, який приймає рядок і перетворює його в ціле число.Якщо рядок не може
            //   бути перетворений в ціле число, метод повинен викинути виняток.
            string str;
            Console.WriteLine("\nЗавдання №2");
            Console.Write("Введіть ваше ціле число: "); str = Console.ReadLine();
            StringToInt32(str);

            //3. Напишіть програму, яка приймає від користувача рядок і виводить його довжину.
            //   Якщо рядок є порожнім, програма повинна викинути виняток.
            Console.WriteLine("\nЗавдання №3");
            Console.Write("Введіть рядок, довжину якого хочете дізнатися: "); str = Console.ReadLine();
            try
            {
                StringLength(str);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            
            //4. Напишіть програму, яка приймає від користувача два рядки і виводить їх конкатенацію.
            //   Якщо хоча б один з рядків є порожнім, програма повинна викинути виняток.
            string str1, str2;
            Console.WriteLine("\nЗавдання №4");
            Console.Write("Перший рядок: "); str1 = Console.ReadLine();
            Console.Write("Другий рядок: "); str2 = Console.ReadLine();
            try
            {
                Concatenate(str1, str2);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

            //5. Напишіть програму, яка приймає від користувача рядок і виводить його першу літеру
            //   у верхньому регістрі.Якщо рядок є порожнім, програма повинна викинути виняток.
            Console.WriteLine("\nЗавдання №5");
            Console.Write("Введіть ваш рядок: "); str = Console.ReadLine();
            try
            {
                FirstLetter(str);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }


            //6. Напишіть метод, який приймає два цілі числа і повертає їх добуток.
            //   Якщо добуток перевищує максимальне значення типу даних, метод повинен викинути виняток.
            Console.WriteLine("\nЗавдання №1");
            Console.Write("Перше число: ");
            while (true) // num1 input
            {
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write("Перше число: ");
                }
            }
            Console.Write("Друге число: ");
            while (true) // num2 input
            {
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write("Друге число: ");
                }
            }
            try
            {
                Multiply(num1, num2);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

        static void Divide(int a, int b)
        {
            int res = a / b;
                Console.WriteLine($"Отже, {a}/{b} дорівнює " + res + ".");
        }

        //static int Divide(int a, int b)
        //{
        //    if (b == 0)
        //    {
        //        throw new DivideByZeroException("Ділення на нуль.");
        //    }
        //    return a / b;
        //}


        static void StringToInt32(string s)
        {
            try
            {
                int num = int.Parse(s);
                Console.WriteLine("Ваше число, але у типі int: " + num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //static string StringToInt32(string s)
        //{
        //    try
        //    {
        //        int num = int.Parse(s);
        //        return num.ToString();
        //    }
        //    catch (Exception)
        //    {
        //        return "А треба було ввести ціле число :(";
        //    }
        //}


        static void StringLength(string s)
        {
            int length = s.Length;
            if (s == "")
                throw new ArgumentNullException(nameof(s), "Рядок не може бути пустим.");

            Console.WriteLine("Довжина рядка дорівнює " + length);
        }

        //static int StringLength(string s)
        //{
        //    int length = s.Length;
        //    if (s == "")
        //        throw new ArgumentNullException(nameof(s), "Рядок не може бути порожнім.");

        //    return length;
        //}


        static void Concatenate(string s1, string s2)
        {
            if (s1 == "")
                throw new ArgumentNullException(nameof(s1), "Рядок не може бути порожнім.");
            else if (s2 == "")
                throw new ArgumentNullException(nameof(s1), "Рядок не може бути порожнім.");

            Console.WriteLine($"Ваш новий рядок: \"{s1+s2}\"");
        }

        //static string Concatenate(string s1, string s2)
        //{
        //    if (s1 == "")
        //        throw new ArgumentNullException(nameof(s1), "Рядок не може бути порожнім.");
        //    else if (s2 == "")
        //        throw new ArgumentNullException(nameof(s1), "Рядок не може бути порожнім.");

        //    return s1 + s2;
        //}


        static void FirstLetter(string s)
        {
            if (s == "")
                throw new ArgumentNullException(nameof(s), "Рядок не може бути порожнім.");

            char firstletter = s[0];
            Console.WriteLine("Перший символ у верхньому регістрі це " + char.ToUpper(firstletter));
        }

        //static char FirstLetter(string s)
        //{
        //    if (s == "")
        //        throw new ArgumentNullException(nameof(s), "Рядок не може бути порожнім.");

        //    char firstletter = s[0];
        //    return char.ToUpper(firstletter);
        //}


        static void Multiply(int a, int b)
        {
            if ((long)a * b > int.MaxValue)
                throw new OverflowException("Переповнення типу даних.");

            Console.WriteLine($"Отже, {a}*{b} = {a*b}");
        }

        //static string Multiply(int a, int b)
        //{
        //    if ((long)a * b > int.MaxValue)
        //        throw new OverflowException("Переповнення типу даних.");

        //    return (a*b).ToString();
        //}


    }
}