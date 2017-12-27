namespace TournamentManager.Model.Domain
{
    public class Judge : Person
    {
        public virtual License License { get; set; }
        public virtual JudgeClass Class { get; set; }
    }
}
