using FluentNHibernate.Mapping;

namespace TournamentManager.Model.DataAccess.Mappings
{
    class AddressMap : ClassMap<Domain.Address>
    {
        public AddressMap()
        {
            Id(x => x.Id);
            Map(x => x.BuildingNumber);
            Map(x => x.City);
            Map(x => x.Country);
            Map(x => x.FlatNumber);
            Map(x => x.State);
            Map(x => x.Street);
            Map(x => x.ZipCode);
        }
    }
}
