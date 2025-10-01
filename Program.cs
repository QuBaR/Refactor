using Refactor.Models;

namespace Refactor
{
    class Program
    {
        static List<Objekt> list1 = new List<Objekt>
        {
            new Objekt { id=1, sts=1, amt=99.99m, cust="A" },
            new Objekt { id=2, sts=0, amt=49.50m, cust="B" },
            new Objekt { id=3, sts=1, amt=10m,   cust="B" }
        };

        static void Main(string[] args)
        {
            string x = "0";
            while (x != "3")
            {

                Console.WriteLine("welcome");
                Console.WriteLine("1) show sum of approved");
                Console.WriteLine("2) filter by cust");
                Console.WriteLine("3) exit");
                x = Console.ReadLine();

                if (x == "1")
                {
                    if (list1 != null)
                    {
                        if (list1.Count > 0)
                        {
                            decimal s = 0;
                            foreach (var i in list1)
                            {
                                if (i.sts == 1) // 1 = approved
                                {
                                    s = s + i.amt;
                                }
                            }
                            Console.WriteLine("SUM=" + s);
                        }
                    }
                }
                else if (x == "2")
                {
                    Console.WriteLine("enter cust");
                    var c = Console.ReadLine();
                    var f = list1.Where(z => z.cust == c && z.sts == 1).ToList();
                    for (int j = 0; j < f.Count; j++)
                    {
                        Console.WriteLine("ID: " + f[j].id + " AMT: " + f[j].amt);
                    }
                }
                else if (x == "3")
                {
                    Console.WriteLine("bye");
                }
                else
                {
                    Console.WriteLine("err");
                }
            }

        }
    }
}
