// See https://aka.ms/new-console-template for more information
namespace ahmad2DArrays;
class Program
{
    static void Main(string[] args)
    {
               {
            string[,] studentA =
            {
            { "Ahmad", "Tunde", "Hakeem"},
            { "Shade", "Toyin", "Shola" },
            { "Charles", "Tony", "Brian" }
        };
            string[,] facultyA =
            {
            {"Agricultural Economics", "Fisheries", "Forestry" },
            {"Animal Science", "Agricultural Extension", "Wilde Life & Ecotourism" }
        };
            if (studentA == facultyA)
            {
                Console.WriteLine("invalid User name");
            }
            else
            {
                Console.WriteLine("You are a registerd user! from " + facultyA[0, 0] + " and your name is " + studentA[1,2] + ".");
            }
            Console.ReadLine();
        }
    
    }
    

    
}
