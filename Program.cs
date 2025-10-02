using Refactor.Models;

namespace Refactor
{
    class Program
    {
        static List<Customers> customers = new List<Customers>
        {
            new Customers { Id=1, Approved=true, Amount=99.99m, Name="Edvin" },
            new Customers { Id=2, Approved=false, Amount=49.50m, Name="Nicolina" },
            new Customers { Id=3, Approved=true, Amount=10m, Name="Felix" }
        };

        static void Main(string[] args)
        {
            string x = "0";
            while (x != "3")
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------\nWelcome to the CRM\n-------------------\n");
                Console.WriteLine("1) List customers");
                Console.WriteLine("2) Show sum of approved orders");
                Console.WriteLine("3) Filter by customer");
                Console.WriteLine("4) Exit");
                x = Console.ReadLine();
                Console.WriteLine("");

                switch (x)
                {

                    case "1":
                        if (customers != null)
                        {

                            if (customers.Count > 0)
                            {
                                var d = customers.Select(z => z.Name).Distinct().ToList();
                                for (int j = 0; j < d.Count; j++)
                                {
                                    Console.WriteLine(d[j]);
                                }
                            }
                        }

                        break;

                    case "2":
                        if (customers != null)
                        {
                            if (customers.Count > 0)
                            {
                                decimal s = 0;
                                foreach (var i in customers)
                                {
                                    if (i.Approved)
                                    {
                                        s = s + i.Amount;
                                    }
                                }
                                Console.WriteLine("Sum of approved order: " + s);
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("Enter customer");
                        var c = Console.ReadLine();
                        var f = customers.Where(z => z.Name == c && z.Approved).ToList();
                        for (int j = 0; j < f.Count; j++)
                        {
                            Console.WriteLine("ID: " + f[j].Id + " Amount: " + f[j].Amount);
                        }
                        break;

                    case "4":
                        Console.WriteLine("Tack för att du använde programet");
                           
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen");
                        break;
                }
            }

        }
    }
}
