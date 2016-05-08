using MoveOn.Domain;
using MoveOn.Infra.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoveOn.Servico.Controllers
{
    [RoutePrefix("api/v1/private")]
    public class AtendimentoController : ApiController
    {
        private MoveOnDataContext db = new MoveOnDataContext();
        

        [Route("novoatendimento")]
        public HttpResponseMessage InserirAtendimento(Atendimento atendimento)
        {
            //var result = db.Atendimentos.Include("Category").ToList();

            var result = atendimento;
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [Route("atendimentos/{clienteId}")]
        //public HttpResponseMessage RetornarAtendimentosPorCliente(int? clienteId)
        public HttpResponseMessage RetornarAtendimentosPorCliente()
        {
            var result = db.Atendimentos.Include("Localizacao").Include("Servico").Include("Responsavel").Include("Veiculo").Include("Status").Where(x => x.ClienteId == clienteId).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

    }
}
