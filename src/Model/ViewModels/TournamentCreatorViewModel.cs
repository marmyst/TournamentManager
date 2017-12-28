using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using TournamentManager.IoC;
using TournamentManager.Model.Domain;
using TournamentManager.Model.Services.TournamentEditor;

namespace TournamentManager.Model.ViewModels
{
    public class TournamentCreatorViewModel : INotifyPropertyChanged
    {
        private Tournament _turnament;

        public string Name
        {
            get { return _turnament.Name; }
            set
            {
                _turnament.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Subname
        {
            get { return _turnament.Subname; }
            set
            {
                _turnament.Subname = value;
                OnPropertyChanged(nameof(Subname));
            }
        }
        public TournamentCalendarType CallendarType
        {
            get { return _turnament.CalendarType; }
            set
            {
                _turnament.CalendarType = value;
                OnPropertyChanged(nameof(CallendarType));
            }
        }
        public ShootingRange ShootingRange
        {
            get { return _turnament.ShootingRange; }
            set
            {
                _turnament.ShootingRange = value;
                OnPropertyChanged(nameof(ShootingRange));
            }
        }
        public DateTime Date
        {
            get { return _turnament.Date; }
            set
            {
                _turnament.Date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
        public Organization Organizer
        {
            get { return _turnament.Organizer; }
            set
            {
                _turnament.Organizer = value;
                OnPropertyChanged(nameof(Organizer));
            }
        }
        public ICollection<Competition> Competitions
        {
            get { return _turnament.Competitions; }
            set
            {
                _turnament.Competitions = value;
                OnPropertyChanged(nameof(Competitions));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public ICommand AddNew { get; private set; }

        public TournamentCreatorViewModel()
        {
            _turnament = new Tournament
            {
                Name = "Turnament Name",
                Subname = "Turnament subname"
            };
            ITournamentEditorService tournamentEditorService = ObjectFactory.GetInstance<ITournamentEditorService>();
            AddNew = new AddTournament(tournamentEditorService);
        }

        protected void OnPropertyChanged(params string[] propertyNames)
        {
            if (PropertyChanged != null)
            {
                foreach(string propertyName in propertyNames)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
    }

    public class AddTournament : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private ITournamentEditorService _tournamentEditorService;

        public AddTournament(ITournamentEditorService tournamentEditorService)
        {
            _tournamentEditorService = tournamentEditorService;
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            _tournamentEditorService.CreateNew(parameter as Model.Domain.Tournament);
        }
    }
}
