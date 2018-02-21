using Newtonsoft.Json;
using NonParallelNBAStatProcessor.CommonAllPlayers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

//links:
// nbastats: https://stats.nba.com/stats/commonallplayers/?LeagueID=00&Season=1996-97&IsOnlyCurrentSeason=0
// nbastatsp:http://stats.nba.com/stats/playercareerstats/?PlayerID=201566&PerMode=Totals
// nbadata:  http://data.nba.net/10s//prod/v1/2017/players.json
// github:   https://api.github.com/repos/restsharp/restsharp/releases

namespace NonParallelNBAStatProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            client.Headers.Add("accept-encoding", "Accepflate, sdch");
            client.Headers.Add("Accept-Language", "en");
            client.Headers.Add("origin", "http://stats.nba.com");
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.133 Safari/537.36");
            var response = client.DownloadString("https://stats.nba.com/stats/commonallplayers/?LeagueID=00&Season=1996-97&IsOnlyCurrentSeason=0");
            CommonAllPlayersResult capr = JsonConvert.DeserializeObject<CommonAllPlayersResult>(response);

            for(int i = 0; i < capr.resultSets[0].rowSet.Length; i++)
            {
                Console.WriteLine(capr.resultSets[0].rowSet[i][2]);
            }

            Console.ReadLine();
        }
    }
}
