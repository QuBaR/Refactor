using Refactor.Models;

namespace Refactor
{
    class Program
    {
        static List<Customers> customers = new List<Customers>
        {
            new Customers { Id=1, Status=1, Amount=99.99m, Name="A" },
            new Customers { Id=2, Status=0, Amount=49.50m, Name="B" },
            new Customers { Id=3, Status=1, Amount=10m, Name="B" }
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
<<<<<<< HEAD
                            var d = customers.Select(z => z.Name).Distinct().ToList();
                            for (int j = 0; j < d.Count; j++)
                            {
                                Console.WriteLine(d[j]);
                            }
                        }
                    }
                }
                else if (x == "1")
                {
                    if (customers != null)
                    {
                        if (customers.Count > 0)
                        {
                            decimal s = 0;
                            foreach (var i in customers)
                            {
                                if (i.Status == 1) // 1 = approved
                                {
                                    s = s + i.Amount;
=======
                            if (customers.Count > 0)
                            {
                                var d = customers.Select(z => z.cust).Distinct().ToList();
                                for (int j = 0; j < d.Count; j++)
                                {
                                    Console.WriteLine(d[j]);
>>>>>>> master
                                }
                            }
                        }
<<<<<<< HEAD
                    }
                }
                else if (x == "2")
                {
                    Console.WriteLine("Enter customer");
                    var c = Console.ReadLine();
                    var f = customers.Where(z => z.Name == c && z.Status == 1).ToList();
                    for (int j = 0; j < f.Count; j++)
                    {
                        Console.WriteLine("ID: " + f[j].Id + " Amount: " + f[j].Amount);
                    }
                }
                else if (x == "3")
                {
                    Console.WriteLine("bye");
                }
                else
                {
                    Console.WriteLine("err");
=======
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
>>>>>>> master
                }
            }

        }
    }
}
