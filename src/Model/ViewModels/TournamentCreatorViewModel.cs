using System;
using TournamentManager.Model.Domain;

namespace TournamentManager.Model.ViewModels
{
    public class TournamentCreatorViewModel
    {
        private Tournament _turnament;

        public string Name
        {
            get { return _turnament.Name; }
            set { _turnament.Name = value; }
        }
        public string Subname
        {
            get { return _turnament.Subname; }
            set { _turnament.Subname = value; }
        }
        public TournamentCalendarType CallendarType
        {
            get { return _turnament.CalendarType; }
            set { _turnament.CalendarType = value; }
        }
        public ShootingRange ShootingRange
        {
            get { return _turnament.ShootingRange; }
            set { _turnament.ShootingRange = value; }
        }
        public DateTime Date
        {
            get { return _turnament.Date; }
            set { _turnament.Date = value; }
        }
        public string Organizer
        {
            get { return _turnament.Name; }
            set { _turnament.Name = value; }
        }
        public string Competitions
        {
            get { return _turnament.Name; }
            set { _turnament.Name = value; }
        }

        public TournamentCreatorViewModel()
        {
            _turnament = new Tournament
            {
                Name = "Turnament Name",
                Subname = "Turnament subname"
            };
        }
    }
}
