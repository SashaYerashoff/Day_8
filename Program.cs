using System;

namespace Day_8
{
    class Program
    {
        static void Main(string[] args)
        {
			string yesno = "y";
			string ekrans = "n";
			do
			{
				if (ekrans == "y")
				{
					Console.Beep();
					Console.Clear();

				}
				//MasivaPiemers();
				//Console.WriteLine("-------------------------------------");
				//NewStar();
				//Console.WriteLine("-------------------------------------");
				//DivdimensijuMasivs();
				Console.WriteLine("-------------------------------------");
				MasivsArIevadu();

				Console.Write("vēlies turpināt? (y/n): ");
				yesno = Console.ReadLine();

				if (yesno == "y")
				{
					Console.Write("Vēlies attīrīt ekrānu? (y/n) ");
					ekrans = Console.ReadLine();
				}
			}
			while (yesno == "y");
        }
		static void MasivsArIevadu()
		{
			int[] masivs = new int[5];
			for (int i = 0; i < 5; i++)
			{
				Console.Write("Ievadi masīva elementu [{0}]: ", i);
				masivs[i] = ReadInt32();       
			}
			Console.WriteLine("-------------------------------------");
			int a = 0;
			for (int i = 0; i < 5; i++)
            {
				Console.WriteLine("masīva elements [{0}] satur: {1} ", i, masivs[i]);
				a = masivs[i] + a;
                
            }
			Console.WriteLine("-------------------------------------");
			Console.WriteLine("Masīva elementu summa = {0}", a);
		}

		static void DivdimensijuMasivs()
		{
			int[,] masivs = new int[10, 5];
			for (int i = 0; i < 10; i++)
			{
				for (int n = 0; n < 5; n++)
				{
					masivs[i, n] = n + 1;
					Console.WriteLine("Masīva elements {0} - {1} = {2}",i, n, masivs[i, n]);

				}
			}
		}

		static void NewStar()
		{
			string[] masivs = new string[30];

			string stars = "*";
			for (int i = 0; i < 4; i++)
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

		static int ReadInt32() //Ievada funkcija un pārbaude uz Int32
        {
            int checkOk; // ar šo mainīgo atgriežam funkcijas darbības rezultātu
            int output;  //šeit glabāsim starprezultātu ja TryParse atgriezīs "true"
            string input; // ar šo mainīgo nolasam ievadu
            string mistake = "It's almost certainly not an integer!"; // Teksts paziņojumam par kļūdu (šīs mainīgais nav obligāts)
            string whatToDo = "Please, try to input the digit with no coma - it certainly shoud work then: "; // Teksts kas paskaidro, ko vajag ievadīt (šīs mainīgais nav obligāts)
            bool result; // TryParse pārbaudīs mūsu ievadu un ja tas būs Int32, atgriezīs true 

            input = Console.ReadLine(); // Ievads
            result = Int32.TryParse(input, out output); // Pārbaude

            while (result == false) //Kamēr netiks saņemts Int32, cikls ziņos par kļūdu un prasīs jaunu ievadu  
            {
                Console.WriteLine(mistake); //izvada paziņojumu par kļūdu
                Console.Write(whatToDo);    //Piedāvā vēlreiz ievadīt skaitli

                input = Console.ReadLine(); // nolasa ievadu

                result = Int32.TryParse(input, out output); // pārbauda vai ir skaitlis un vai vajag atkartot visu no jauna
            }
            checkOk = output; //Ja ievadā bija skaitlis (TryParse == true) tad piešķiram to funkcijas izvadam

            return checkOk; // funkcijas izvads
        } // Šīs ir ReadInt32() funkcijas beigas


    }
}
