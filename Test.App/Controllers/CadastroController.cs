using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Business.Dto;
using Test.Business.Services;

namespace Test.App.Controllers
{
    public class CadastroController : Controller
    {
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CadastrarUsuario(ContatoDto contato)
        {
            try
            {
                CadastroServico cadastroServico = new CadastroServico();
                cadastroServico.CadastrarUsuario(contato);

                return Json(new { mensagem = "Usuario cadastrado com sucesso!" });
            }
            catch (Exception ex)
            {
                return Json(new { mensagem = ex.Message });
            }            
        }

        public JsonResult ListarUsuarios()
        {
            try
            {
                CadastroServico cadastroServico = new CadastroServico();

                var retorno = cadastroServico.ListarUsuarios();

                return Json(retorno, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { mensagem = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult DeletarUsuario(int id)
        {
            try
            {
                CadastroServico cadastroServico = new CadastroServico();

                cadastroServico.DeletarUsuario(id);

                return Json(new { success = "Sucesso ao deletar o usuario!"});
            }
            catch (Exception ex)
            {
                return Json(new { mensagem = ex.Message });
            }
        }
    }
}