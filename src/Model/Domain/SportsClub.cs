using System.Collections.Generic;

namespace TournamentManager.Model.Domain
{
    public class SportsClub : Organization
    {
        public virtual ICollection<Person> Members { get; set; }
    }
}
