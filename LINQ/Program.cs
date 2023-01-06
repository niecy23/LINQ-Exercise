namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating a list and adding the game names.
            var VideoGames = new List<string>()
            {
                "Mario Kart",
                "Blur",
                "Need For Speed",
                "Call of Duty",
                "Roblox",
                "Sims"
            };

            //Creating a new list that is ordered by the length of the game names.
            var OrderedList = VideoGames.OrderBy(name => name.Length);

            //Printing the new list to the console.
            Console.WriteLine("List in order by length of game name");
            Console.WriteLine("----------"); 
            foreach (var game in OrderedList)
            {
                Console.WriteLine($"{game}"); 
            }

        }
    }
}
