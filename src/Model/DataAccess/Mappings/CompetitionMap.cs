using FluentNHibernate.Mapping;

namespace TournamentManager.Model.DataAccess.Mappings
{
    class CompetitionMap : ClassMap<Domain.Competition>
    {
        public CompetitionMap()
        {
            Id(x => x.Id);
        }
    }
}
