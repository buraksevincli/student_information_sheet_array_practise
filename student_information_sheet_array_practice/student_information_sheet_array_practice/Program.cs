using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_information_sheet_array_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] ogr = new string[4, 5];
            double ortalama = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("---{0}. Öğrenci Bilgileri---", i + 1);
                Console.Write("Öğrenci No: ");
                ogr[i, 0] = Console.ReadLine();
                Console.Write("Öğrenci Adı Soyadı: ");
                ogr[i, 1] = Console.ReadLine();
                Console.Write("Öğrenci Vize Notu: ");
                ogr[i, 2] = Console.ReadLine();
                Console.Write("Öğrenci Final Notu: ");
                ogr[i, 3] = Console.ReadLine();
                ortalama = double.Parse(ogr[i, 2]) * 0.4 + double.Parse(ogr[i, 3]) * 0.6;
                ortalama = Math.Round(ortalama, 2);
                ogr[i, 4] = Convert.ToString(ortalama);
                if (i == 3)
                {
                    Console.WriteLine("---Öğrenci Ortalamaları---");
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Öğrenci No:{0} Öğrenci Adı Soyadı:{1} Vize Notu:{2} Final Notu:{3} Ortalama:{4}", ogr[i, 0], ogr[i, 1], ogr[i, 2], ogr[i, 3], ogr[i, 4]);
            }
            Console.Read();
        }
    }
}
