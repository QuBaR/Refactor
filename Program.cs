using Refactor.Models;

namespace Refactor
{
    class Program
    {
        static List<Customers> customers = new List<Customers>
        {
            new Customers { id=1, sts=1, amt=99.99m, cust="A" },
            new Customers { id=2, sts=0, amt=49.50m, cust="B" },
            new Customers { id=3, sts=1, amt=10m,   cust="B" }
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

                switch (x)
                {

                    case "0":
                        if (customers != null)
                        {
                            if (customers.Count > 0)
                            {
                                var d = customers.Select(z => z.cust).Distinct().ToList();
                                for (int j = 0; j < d.Count; j++)
                                {
                                    Console.WriteLine(d[j]);
                                }
                            }
                        }
                        break;

                    case "1":
                        if (customers != null)
                        {
                            if (customers.Count > 0)
                            {
                                decimal s = 0;
                                foreach (var i in customers)
                                {
                                    if (i.sts == 1) // 1 = approved
                                    {
                                        s = s + i.amt;
                                    }
                                }
                                Console.WriteLine("Sum of approved order: " + s);
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter customer");
                        var c = Console.ReadLine();
                        var f = customers.Where(z => z.cust == c && z.sts == 1).ToList();
                        for (int j = 0; j < f.Count; j++)
                        {
                            Console.WriteLine("ID: " + f[j].id + " AMT: " + f[j].amt);
                        }
                        break;

                    case "3":
                        Console.WriteLine("bye");
                        break;

                    default:
                        Console.WriteLine("err");
                        break;
                }
            }

        }
    }
}
