using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TournamentManager.Model.Domain
{
    public class CompetitionResults
    {
        private Contestant Contestant;

        public ICollection<int> RoundResults
        {
            get => default(ICollection<int>);
            set
            {
            }
        }

        public int? Priority
        {
            get => default(int?);
            set
            {
            }
        }
    }
}