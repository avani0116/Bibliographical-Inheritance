using System;
namespace BiblioInheritance
{
class Program
{
            static void Main(string[] args)
            {
                Resource test = new Resource("Test Resource", "General");
                test.GetInfo();
                test.UpdateStatus();
                Console.WriteLine($"\nAfter UpdateStatus(), test.Status: {test.Status}");
                Console.WriteLine("\n-------------------------------------------------");
                Book codeBook = new Book(
                    "Code: The Hidden Language of Computer Hardware and Software",
                    "Charles Petzold",
                    "Non-Fiction",
                    396
                );
                codeBook.GetInfo();
                Console.WriteLine("\n-------------------------------------------------");
                Periodical p = new Periodical("Wired", "Technology", "Monthly");
                p.UpdateStatus();
                Console.WriteLine($"Periodical Status after UpdateStatus(): {p.Status}");
                p.GetInfo();
                Console.WriteLine("\n-------------------------------------------------");
                Video v = new Video(
                    "Ex Machina",
                    "Alex Garland",
                    "Sci-Fi",
                    108,
                    "On-Demand"
                );
                v.GetInfo();
            }
    }
}
