using FluentNHibernate.Mapping;

namespace TournamentManager.Model.DataAccess.Mappings
{
    class EntityMap : ClassMap<Domain.Entity>
    {
        public EntityMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Address);
            HasMany(x => x.PreviousAddresses);
        }
    }
}
