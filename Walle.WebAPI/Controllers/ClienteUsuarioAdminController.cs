using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Walle.DAL;

namespace Walle.WebAPI.Controllers
{
    public class ClienteUsuarioAdminController : ApiController
    {
        private DbWalleContext db = new DbWalleContext();

        //GET: api/ClienteUsuarioAdmin
        public IHttpActionResult Gettb_cliente_usuario_admin(tb_cliente_usuario_admin acesso)
        {
             return Ok(db.tb_cliente_usuario_admin.FirstOrDefault());
        }

        // GET: api/ClienteUsuarioAdmin/5
        [ResponseType(typeof(tb_cliente_usuario_admin))]
        public IHttpActionResult Gettb_cliente_usuario_admin(int id)
        {
            tb_cliente_usuario_admin tb_cliente_usuario_admin = db.tb_cliente_usuario_admin.Find(id);
            if (tb_cliente_usuario_admin == null)
            {
                return NotFound();
            }

            return Ok(tb_cliente_usuario_admin);
        }

        // PUT: api/ClienteUsuarioAdmin/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttb_cliente_usuario_admin(int id, tb_cliente_usuario_admin tb_cliente_usuario_admin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tb_cliente_usuario_admin.Cod_Cliente_Usuario_Admin)
            {
                return BadRequest();
            }

            db.Entry(tb_cliente_usuario_admin).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tb_cliente_usuario_adminExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }


        [HttpPost]
        [Route("api/ClienteUsuarioAdmin/Autenticacao")]
        [ResponseType(typeof(tb_cliente_usuario_admin))]
        public IHttpActionResult GetAutenticacao(tb_cliente_usuario_admin obj)
        {
            try
            {
                var result = db.tb_cliente_usuario_admin.Where(e => e.Des_Email_Login == obj.Des_Email_Login && e.Des_Password == obj.Des_Password).FirstOrDefault();
                if (result == null)
                {
                    return BadRequest("Usuário não encontrado.");
                }

                    return Ok(result);
            }
            catch (Exception)
            {
               return InternalServerError();
            }
        }

        // POST: api/ClienteUsuarioAdmin
        [ResponseType(typeof(tb_cliente_usuario_admin))]
        public IHttpActionResult Posttb_cliente_usuario_admin(tb_cliente_usuario_admin tb_cliente_usuario_admin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tb_cliente_usuario_admin.Add(tb_cliente_usuario_admin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tb_cliente_usuario_admin.Cod_Cliente_Usuario_Admin }, tb_cliente_usuario_admin);
        }

        // DELETE: api/ClienteUsuarioAdmin/5
        [ResponseType(typeof(tb_cliente_usuario_admin))]
        public IHttpActionResult Deletetb_cliente_usuario_admin(int id)
        {
            tb_cliente_usuario_admin tb_cliente_usuario_admin = db.tb_cliente_usuario_admin.Find(id);
            if (tb_cliente_usuario_admin == null)
            {
                return NotFound();
            }

            db.tb_cliente_usuario_admin.Remove(tb_cliente_usuario_admin);
            db.SaveChanges();

            return Ok(tb_cliente_usuario_admin);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tb_cliente_usuario_adminExists(int id)
        {
            return db.tb_cliente_usuario_admin.Count(e => e.Cod_Cliente_Usuario_Admin == id) > 0;
        }
    }
}