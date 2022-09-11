using System;

namespace ExceptionTraining
{
    class Program
    {
        public static void Main()
        {
            Exception[] exceptions = new Exception[] {new ArgumentException(), new IndexOutOfRangeException(),new InputException(),new DivideByZeroException(), new FormatException()};
            
            foreach (var exception in exceptions)
            {
                try
                {
                    throw exception;
                }
                catch (Exception ex)
                {
                    if (ex is InputException)
                    {
                        Console.WriteLine("Ошибка ввода!");
                    }
                    else
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
