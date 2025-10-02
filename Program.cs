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
                Console.WriteLine("");
                Console.WriteLine("-------------------\nWelcome to the CRM\n-------------------\n");
                Console.WriteLine("0) List customers");
                Console.WriteLine("1) Show sum of approved orders");
                Console.WriteLine("2) Filter by customer");
                Console.WriteLine("3) Exit");
                x = Console.ReadLine();
                Console.WriteLine("");

                if (x == "0")
                {
                    if (list1 != null)
                    {
                        if (list1.Count > 0)
                        {
                            var d = list1.Select(z => z.cust).Distinct().ToList();
                            for (int j = 0; j < d.Count; j++)
                            {
                                Console.WriteLine(d[j]);
                            }
                        }
                    }
                }
                else if (x == "1")
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
                            Console.WriteLine("Sum of approved order: " + s);
                        }
                    }
                }
                else if (x == "2")
                {
                    Console.WriteLine("Enter customer");
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
