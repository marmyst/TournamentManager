using FluentNHibernate.Mapping;

namespace TournamentManager.Model.DataAccess.Mappings
{
    class LicenseMap : ClassMap<Domain.License>
    {
        public LicenseMap()
        {
            Id(x => x.Id);
        }
    }
}
