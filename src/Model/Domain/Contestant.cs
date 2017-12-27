namespace TournamentManager.Model.Domain
{
    public class Contestant : Person
    {
        public virtual License License { get; set; }
        public virtual SportsClub SportsClub { get; set; }
    }
}
