using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_43
{
    class Program
    {
        static void Main(string[] args)
        {
			NumberOne();

		}

		// Write a program and ask the user to enter a number. 
		// The number should be between 1 to 10. 
		// If the user enters a valid number, display 
		// "Valid" on the console. Otherwise, display "Invalid". 
		// (This logic is used a lot in applications where values 
		// entered into input boxes need to be validated.)
		public static void NumberOne()
		{
			while (true)
			{
				Console.WriteLine("Input a number from 1-10 ");
				var input = Console.ReadLine();
				int valid = Convert.ToInt32(input);
				if (valid >= 1 && valid <= 10)
				{
					Console.WriteLine("You did it!");
					break;
				}
				else
				{
					Console.WriteLine("Are you kidding me...Try Again...\n");
				}

			}

		}

		// Write a program which takes two numbers from the 
		// console and displays the maximum of the two.
		public static void NumberTwo()
		{
			Console.WriteLine("Enter a number: ");
			var temp = Console.ReadLine();
			int Input1 = Convert.ToInt32(temp);

			Console.WriteLine("Enter another number!: ");
			temp = Console.ReadLine();
			int Input2 = Convert.ToInt32(temp);

			var toPrint = (Input1 > Input2) ? "Your first number was bigger" : "Your second number was bigger";
			Console.WriteLine(toPrint);
		}

		//Write a program and ask the user to enter the width and height of an image. 
		// Then tell if the image is landscape or portrait.


		public static void NumberThree()
		{
			Console.WriteLine("Enter a width: ");
			var temp = Console.ReadLine();
			int width = Convert.ToInt32(temp);

			Console.WriteLine("Enter a height!: ");
			temp = Console.ReadLine();
			int height = Convert.ToInt32(temp);

			var toPrint = (width > height) ? "This image is landscape" : "This image is portrait";
			Console.WriteLine(toPrint);
		}

		// Speed Camera. User enters speed limit and car speed.
		// If speed is under limit, print "Okay". Add one demerit
		// per 5km over the speed limit. If demerits are above 12
		// display license suspended.
		public static void NumberFour()
		{
			Console.WriteLine("Enter the speed limit: ");
			var temp = Console.ReadLine();
			int speedLimit = Convert.ToInt32(temp);

			Console.WriteLine("Enter the speed of the car: ");
			temp = Console.ReadLine();
			int carSpeed = Convert.ToInt32(temp);

			int netSpeed = carSpeed - speedLimit;
			int demerit = 0;
			int totalDemerits = netSpeed / 5;

			if (netSpeed <= 0)
			{
				Console.WriteLine("Okay");
			}

			for (int i = 0; i < totalDemerits; i++)
			{
				demerit++;
			}

			Console.WriteLine("Total Demerits: " + demerit);

			if (demerit > 12)
			{
				Console.WriteLine("License suspended!1");
			}


		}
	}
}
