using FluentNHibernate.Mapping;

namespace TournamentManager.Model.DataAccess.Mappings
{
    class PreviousAddressMap : ClassMap<Domain.PreviousAddress>
    {
        public PreviousAddressMap()
        {
            Id(x => x.Id);
            Map(x => x.ValidUntil);
            References(x => x.Address);
        }
    }
}
