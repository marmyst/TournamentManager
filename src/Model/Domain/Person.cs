namespace TournamentManager.Model.Domain
{
    public class Person : Entity
    {
        public virtual string Surname { get; set; }
        public virtual short YearOfBirth { get; set; }
    }
}
