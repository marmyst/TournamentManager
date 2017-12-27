using FluentNHibernate.Mapping;

namespace TournamentManager.Model.DataAccess.Mappings
{
    class JudgeMap : ClassMap<Domain.Judge>
    {
        public JudgeMap()
        {
            HasOne(x => x.License);
            Map(x => x.Class).CustomType<Domain.JudgeClass>();
        }
    }
}
