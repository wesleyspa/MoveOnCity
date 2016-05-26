using MoveOn.Domain;
using MoveOn.Infra.DataContext;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MoveOn.Servico.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/av1/private")]
    public class AtendimentoController : ApiController
    {
        private MoveOnDataContext db = new MoveOnDataContext();

        [Route("atendimentos")]
        public HttpResponseMessage GetAtendimentos()
        {
            var result = db.Atendimentos.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [Route("atendimentosabertos")]
        public HttpResponseMessage GetAtendimentosAbertos()
        {
            var result = db.Atendimentos.Where(x => x.MomConclusao == null).OrderBy(x => x.MomAbertura).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [Route("atendimento/{clienteId}")]
        public HttpResponseMessage GetAtendimento(int? clienteId)
        {
            var result = db.Atendimentos.Include("Localizacao").Where(x => x.ClienteId == clienteId).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPost]
        [Route("atendimento")]
        public HttpResponseMessage PostAtendimento(Atendimento atendimento)
        {
            if (atendimento == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            else if (!(atendimento.ClienteId > 0))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Necessário informar o Id do Cliente");
            }

            var atendAberto = db.Atendimentos.Where(x => x.MomConclusao == null && x.ClienteId == atendimento.ClienteId).ToList();
            if (atendAberto.Count > 0)
            {
                //return Request.CreateResponse(HttpStatusCode.InternalServerError, "Cliente possui atendimento não concluído.");
            }

            try
            {
                db.Atendimentos.Add(atendimento);
                db.SaveChanges();

                var result = atendimento;
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao tentar abrir um novo atendimento");
            }
        }

        [HttpPatch]
        [Route("alteraratendimento")]
        public HttpResponseMessage PatchAtendimento(Atendimento atendimento)
        {
            if (atendimento == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadGateway);
            }

            try
            {
                db.Entry<Atendimento>(atendimento).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                var result = atendimento;
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao alterar Atendimento");
            }
        }

        [HttpDelete]
        [Route("removeratendimento")]
        public HttpResponseMessage DeleteAtendimento(int atendimentoId)
        {
            if (atendimentoId == 0)
            {
                return Request.CreateResponse(HttpStatusCode.BadGateway);
            }

            try
            { 
                db.Atendimentos.Remove(db.Atendimentos.Find(atendimentoId));
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Atendimento removido");
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao remover Atendimento");
            }
        }


        [Route("clientes/{Id}")]
        public HttpResponseMessage GetClientes(int? Id)
        {
            var result = db.Clientes.Include("Endereco").Where(x => x.Id == Id).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

    }
}
