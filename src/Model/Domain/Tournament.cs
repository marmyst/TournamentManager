using System;
using System.Collections.Generic;

namespace TournamentManager.Model.Domain
{
    public class Tournament
    {
        public virtual string Name { get; set; }
        public virtual string Subname { get; set; }
        public virtual TournamentCalendarType CalendarType { get; set; }
        public virtual DateTime Date { get; set; }

        public virtual Organization Organizer { get; set; }
        public virtual ShootingRange ShootingRange { get; set; }
        public virtual ICollection<Competition> Competitions { get; set; }

        public int Id
        {
            get => default(int);
            set
            {
            }
        }
    }
}
