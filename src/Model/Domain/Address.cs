namespace TournamentManager.Model.Domain
{
    public class Address
    {
        public virtual string Street { get; set; }
        public virtual string BuildingNumber { get; set; }
        public virtual string FlatNumber { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Country { get; set; }

        public int Id
        {
            get => default(int);
            set
            {
            }
        }
    }
}
