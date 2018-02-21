using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonParallelNBAStatProcessor.CommonAllPlayers
{
    class CommonAllPlayersParameter
    {
        public string LeagueID { get; set; }
        public string Season { get; set; }
        public bool IsOnlyCurrentSeason { get; set; }
    }
}
