using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lazy
{
    internal class DataRepository
    {
        private List<Game> games;

        public DataRepository(string path)
        {
            Console.WriteLine("The data repositry of " + path + " has been created");
            games = JsonSerializer.Deserialize<List<Game>>(File.ReadAllText(path));
        }

        public void print()
        {
            games.ForEach(g => Console.WriteLine($"{g.id}. {g.homeTeam} {g.homeScore}-{g.awayTeam} {g.awayScore}"));
        }
        public void printDraw()
        {
            var TekoGames = games.Where(g => g.homeScore == g.awayScore).ToList();

        }
        private Dictionary<string, int> getResultsDict()
        {
            Dictionary<string, int> resultsGroups = games.GroupBy(game => game.awayScore == game.homeScore ? "Draw" : game.homeScore > game.awayScore ? "Home win" : "Away win")
                .ToDictionary(group => group.Key, group => group.Count());

            return resultsGroups;
        }
        public void printResultDict()
        {
            Dictionary<string, int> resultsGroups = getResultsDict();
            foreach (KeyValuePair<string, int> kvp in resultsGroups)
            {
                Console.WriteLine($"\n{kvp.Key} : {kvp.Value}");
            }

        }
    }
}
