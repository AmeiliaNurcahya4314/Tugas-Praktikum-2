using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {

        static double penambahan(double a, double b)
        {
            return a + b;
        }

        static double pengurangan(double a, double b)
        {
            return a - b;
        }

        static double perkalian(double a, double b)
        {
            return a * b;
        }

        static double pembagian(double a, double b)
        {
            return a / b;
        }


        static void Main(string[] args)
        {
            double bil1, bil2;
            char pilihan;
            menu:
            Console.WriteLine("=============================");
            Console.WriteLine("|    Program Calculator      |");
            Console.WriteLine("=============================");
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("<       Masukkan Pilihan    >");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|                ");
            Console.WriteLine("|    A. Penambahan");
            Console.WriteLine("|    B. Pengurangan");
            Console.WriteLine("|    C. Perkalian");
            Console.WriteLine("|    D. Pembagian");
            Console.WriteLine("|                ");
            Console.Write(" Pilihan menu    : ");
            pilihan = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("\n");

            if (pilihan == 'A' || pilihan == 'a')
            {
                Console.WriteLine("========================");
                Console.WriteLine("|    Masukkan Bilangan ");
                Console.WriteLine("========================");

                Console.WriteLine("               ");
                Console.Write("| Masukkan Bilangan pertama : ");
                bil1 = Double.Parse(Console.ReadLine());
                Console.Write("| Masukkan Bilangan kedua : ");
                bil2 = Double.Parse(Console.ReadLine());
                Console.WriteLine(" --------------------");
                Console.WriteLine(" | Hasilnya Adalah : " + penambahan(bil1, bil2) + "			" );
                Console.WriteLine(" --------------------");

            }

            else if (pilihan == 'B' || pilihan == 'b')
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" 					");
                Console.Write(" | Masukan Bilangan pertama : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.Write(" | Masukan Bilangan kedua : ");
                bil2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" --------------------");
                Console.WriteLine(" | Hasilnya Adalah : " + pengurangan(bil1, bil2) + "			");
                Console.WriteLine(" --------------------");
            }

            else if (pilihan == 'c' || pilihan == 'C')
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" 					");
                Console.Write(" | Masukan Bilangan pertama : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.Write(" | Masukan Bilangan kedua : ");
                bil2 = Convert.ToDouble(Console.ReadLine()); ;
                Console.WriteLine(" --------------------");
                Console.WriteLine(" | Hasilnya Adalah : " + perkalian(bil1, bil2) + "			");
                Console.WriteLine(" --------------------");

            }

            else if (pilihan == 'D' || pilihan == 'd')
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" 					");
                Console.Write(" | Masukan Bilangan pertama : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.Write(" | Masukan Bilangan kedua : ");
                bil2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" ------------------");
                Console.WriteLine(" | Hasil dari  Adalah :  "+ pembagian(bil1, bil2) + "			");
                Console.WriteLine(" ------------------");
            }


            else
            {
                Console.WriteLine("");
                Console.WriteLine("==================================================");
                Console.WriteLine("|            Maaf Menu tidak tersedia!!          |");
                Console.WriteLine("|    Silahkan pilih kembali menu yang tersedia   |");
                Console.WriteLine("==================================================");
                Console.WriteLine("");
                goto menu;
            }



            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
     }
  }
    

