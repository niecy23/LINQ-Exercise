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

            Console.WriteLine("List in order by length of game name");
            Console.WriteLine("----------");

            //Creating a new list that is ordered by the length of the game names and printing it to the console.
            VideoGames.OrderBy(name => name.Length).ToList().ForEach(Console.WriteLine);
                
        }
    }
}
