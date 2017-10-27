using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NY_Gift.Interfaces;

namespace NY_Gift.Classes
{
    class Program 
    {
        public static void Display(NY_Gift swList)
        {
            Console.WriteLine("\n{0, 15}", "Gift");
            Console.WriteLine("\nName\tPrice\tSugar\tWeight");
            foreach (Sweet sw in swList)
            {
                Console.WriteLine("{0}\t{1}\t{2}%\t{3}",
                    sw.Name, sw.Price.ToString(), sw.Sugar.ToString(), sw.Weight.ToString());
            }
            Console.WriteLine("\nDiscount thicket");
            Console.WriteLine("{0}", swList.Bonus, swList.Packaging);
            Console.WriteLine("\nPackaging");
            Console.WriteLine("{0}", swList.Packaging);
            Console.WriteLine("--------------------------------------\n");
        }

        public static void Calority(ICalority sweet)
        {
            ICalority obj = sweet as ICalority;

            Console.WriteLine(sweet.GetCalority());
            
        }

        public static void GiftWeight(NY_Gift gift)
        {
            Console.WriteLine(gift.GetWeight());
        }

        static void Main(string[] args)
        {
            Discount bonus = new Discount(30);
            Packaging pack = new Packaging(150, 300, "средняя");

            NY_Gift gift = new NY_Gift(bonus, pack);

            gift.Add(new Sweet(15, 30, 25, "Mars"));
            gift.Add(new Sweet(25, 45, 28, "Snikers"));
            gift.Add(new Sweet(15, 35, 14, "Alenka"));
            gift.Add(new Sweet(45, 25, 50, "Spartak"));
            gift.Add(new Sweet(15, 15, 64, "Spartak"));

            Display(gift);
            Console.WriteLine("Removing {0}", gift[0].Name.ToString());
            gift.Remove(gift[0]);
            Display(gift);

            Sweet SweetCheck = new Sweet(15, 25, 14, "Mars");
            Console.WriteLine("Chek Mars in collection: {0}\n", gift.Contains(SweetCheck).ToString());


            Sweet[] array = new Sweet[gift.Count];
            gift.CopyTo(array, 0);

            Array.Sort(array);

            Console.WriteLine("\nSorting by Weight\n");
            Console.WriteLine("Name\tPrice\tSugar\tWeighn");
            foreach (Sweet sw in array)
            {
                Console.WriteLine("{0}\t{1}\t{2}%\t{3}",
                    sw.Name, sw.Price.ToString(), sw.Sugar.ToString(), sw.Weight.ToString());
            }
            Console.WriteLine();

            Console.Write("Find calority of sweet: ");
            Calority(new Wafer(45, 25, 50, "Spartak"));

            Console.Write("\nCommon weight: ");
            GiftWeight(gift);
        }
    }
}
