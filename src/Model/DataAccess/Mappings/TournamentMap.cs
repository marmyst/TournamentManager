using FluentNHibernate.Mapping;

namespace TournamentManager.Model.DataAccess.Mappings
{
    class TournamentMap : ClassMap<Domain.Tournament>
    {
        public TournamentMap()
        {
            HasMany(x => x.Competitions);
            Id(x => x.Id);
            Map(x => x.Date);
            Map(x => x.Name);
            Map(x => x.Subname);
            Map(x => x.CalendarType).CustomType<Domain.TournamentCalendarType>();
            References(x => x.CalendarType);
            References(x => x.Organizer);
            References(x => x.ShootingRange);
        }
    }
}
