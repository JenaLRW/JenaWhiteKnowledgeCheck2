using System.Xml.Linq;

namespace JenaWhiteKnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");

            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Diet>();

            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var diet = new Diet();

                Console.WriteLine("Enter the name for the animal: ");

                diet.Name = Console.ReadLine();

                Console.WriteLine("Enter the species for the animal: ");

                diet.Species = Console.ReadLine();

                Console.WriteLine("Enter the sex for the animal: ");

                diet.Sex = Console.ReadLine();

                Console.WriteLine("Enter the color for the animal: ");

                diet.Color = Console.ReadLine();

                Console.WriteLine($"Enter the brand of the {diet.Name}'s food: ");

                diet.Brand = Console.ReadLine();

                Console.WriteLine($"Enter the amount of food {diet.Name} eats: ");

                diet.Amount = Console.ReadLine();



                recordList.Add(diet);
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var diet in recordList)
            {
                Console.WriteLine($"Name: {diet.Name} \t\tSpecies: {diet.Species}\t\t Sex: {diet.Sex}\t\t Color: {diet.Color}\t\t Brand: {diet.Brand}\t\t Amount: {diet.Amount}");
            }
        }
    }
}
