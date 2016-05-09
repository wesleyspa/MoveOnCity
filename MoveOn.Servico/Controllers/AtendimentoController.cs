using MoveOn.Domain;
using MoveOn.Infra.DataContext;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoveOn.Servico.Controllers
{
    public class AtendimentoController : ApiController
    {
        private MoveOnDataContext db = new MoveOnDataContext();
        
        [Route("atendimentos")]
        public HttpResponseMessage GetAtendimentos()
        {
            var result = db.Atendimentos.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

    }
}
