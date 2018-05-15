using System;

namespace Day_8
{
    class Program
    {
        static void Main(string[] args)
        {
			//-------main------
			MasivaPiemers();
			NewStar();
        }

		static void NewStar()
		{
			string[] masivs = new string[30];

			string stars = "*";
			for (int i = 0; i < 30; i++)
			{
				
				masivs[i] = masivs[i] + stars;
				stars = stars + "*";
				Console.WriteLine(masivs[i]);
			}
		}


		static void MasivaPiemers()
		{
			int[] masivs = new int[4];
            masivs[0] = 1;
            masivs[1] = 5;
            masivs[2] = 7;
            masivs[3] = 6;
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("masīva {0} vērtība ir: {1}", i, masivs[i]);
            }
		}


    }
}
