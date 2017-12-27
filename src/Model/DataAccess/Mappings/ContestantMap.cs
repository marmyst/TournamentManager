using FluentNHibernate.Mapping;

namespace TournamentManager.Model.DataAccess.Mappings
{
    class ContestantMap : ClassMap<Domain.Contestant>
    {
        public ContestantMap()
        {
            HasOne(x => x.License);
            References(x => x.SportsClub);
        }
    }
}
