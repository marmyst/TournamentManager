using System;

namespace TournamentManager.Model.Domain
{
    public class PreviousAddress
    {

        public virtual Address Address { get; set; }
        public virtual DateTime ValidUntil { get; set; }

        public int Id
        {
            get => default(int);
            set
            {
            }
        }
    }
}
