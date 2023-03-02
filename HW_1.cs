using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Input code : ");
		string code = Console.ReadLine();
		Console.Write("Input Password : ");
		double Password = int.Parse(Console.ReadLine());
		double currentnumber;
		double N1 = Math.Floor(Password / 100000);
		currentnumber = Password % 100000;
		double N2 = Math.Floor(currentnumber / 10000);
		currentnumber = currentnumber % 10000;
		double N3 = Math.Floor(currentnumber / 1000);
		currentnumber = currentnumber % 1000;
		double N4 = Math.Floor(currentnumber / 100);
		currentnumber = currentnumber % 100;
		double N5 = Math.Floor(currentnumber / 10);
		currentnumber = currentnumber % 10;
		double N6 = currentnumber;

		if (code == "CIA")
		{
			if (N6 % 3 == 0 && N5 != 1 && N5 != 3 && N5 != 5 && N3 >= 6 && N3 != 8)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
			return;
		}
		if (code == "FBI")
		{
			if (N1 >= 4 && N1 <= 7 && N4 % 2 == 0 && N4 != 6 && N2 % 2 != 0)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
			return;
		}
		if (code == "NSA")
		{
			if (30 % N6 == 0 && N4 % 3 == 0 && N4 % 2 != 0)
			{
				if (N1 == 7 || N2 == 7 || N3 == 7 || N4 == 7 || N5 == 7 || N6 == 7)
				{
					Console.WriteLine("True");
				}
				else
				{
					Console.WriteLine("False");
				}
			}
			else
            {
				Console.WriteLine("False");
			}
			return;
		}
		Console.WriteLine("False");
	}
}

