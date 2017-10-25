using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static void Main(string[] args)
        {
            Discount bonus = new Discount(30);
            Packaging pack = new Packaging(150, 300, "средняя");

            NY_Gift gift = new NY_Gift(bonus, pack);

            gift.Add(new Sweet(15, 25, 14, "Mars"));
            gift.Add(new Sweet(15, 25, 14, "Snikers"));
            gift.Add(new Sweet(15, 25, 14, "Alenka"));
            gift.Add(new Sweet(15, 25, 14, "Spartak"));
            gift.Add(new Sweet(15, 25, 14, "Spartak"));

            Display(gift);
            Console.WriteLine("Removing {0}", gift[1].Name.ToString());
            gift.Remove(gift[1]);
            Display(gift);

            Sweet SweetCheck = new Sweet(15, 25, 14, "Mars");
            Console.WriteLine("Chek Mars in collection: {0}\n", gift.Contains(SweetCheck).ToString());
                       

        }
    }
}
