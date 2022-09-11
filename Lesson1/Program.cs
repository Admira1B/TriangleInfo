using System;

namespace Lesson1
{
	class Program
	{
		static void Main()
		{
			string choise = "1";

			while (choise == "1")
			{
				Triangle triangle1 = new Triangle();
				triangle1.TriangleInfo();

				Console.WriteLine("\nЕсли вы хотите продолжить работу с программой введите 1. Для завершения работы программы нажмите Enter.");
				Console.Write("User: ");
				choise = Console.ReadLine();
				Console.WriteLine();	
			}
        }
	}
}