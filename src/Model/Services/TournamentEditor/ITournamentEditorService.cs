using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentManager.Model.Domain;

namespace TournamentManager.Model.Services.TournamentEditor
{
    public interface ITournamentEditorService
    {
        void CreateNew(Domain.Tournament turnament);
    }

    public class TournamentEditorService : ITournamentEditorService
    {
        public void CreateNew(Tournament turnament)
        {
            throw new NotImplementedException();
        }
    }
}
