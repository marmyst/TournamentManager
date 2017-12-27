using System.Collections.Generic;

namespace TournamentManager.Model.Domain
{
    public abstract class Entity
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<PreviousAddress> PreviousAddresses { get; set; }
    }
}