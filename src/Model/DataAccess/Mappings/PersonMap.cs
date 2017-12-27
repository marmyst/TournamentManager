using FluentNHibernate.Mapping;

namespace TournamentManager.Model.DataAccess.Mappings
{
    class PersonMap : ClassMap<Domain.Person>
    {
        public PersonMap()
        {
            Map(x => x.Surname);
            Map(x => x.YearOfBirth);
        }
    }
}
