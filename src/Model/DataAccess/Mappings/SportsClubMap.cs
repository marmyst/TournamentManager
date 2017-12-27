using FluentNHibernate.Mapping;

namespace TournamentManager.Model.DataAccess.Mappings
{
    class SportsClubMap : ClassMap<Domain.SportsClub>
    {
        public SportsClubMap()
        {
            HasMany(x => x.Members);
        }
    }
}
