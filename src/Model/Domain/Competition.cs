namespace TournamentManager.Model.Domain
{
    public class Competition
    {
        public int Id
        {
            get => default(int);
            set
            {
            }
        }

        public CompetitionType CompetitionType { get; set; }

        public int Distance
        {
            get => default(int);
            set
            {
            }
        }

        public int RatedShots
        {
            get => default(int);
            set
            {
            }
        }

        public int TrialShots
        {
            get => default(int);
            set
            {
            }
        }

        public int Caliber
        {
            get => default(int);
            set
            {
            }
        }

        public TargetType TargetType { get; set; }

        public CompetitionResults Results
        {
            get => default(CompetitionResults);
            set
            {
            }
        }
    }
}
