using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Gerir.API.Dominios;
using Senai.Gerir.API.Interfaces;
using Senai.Gerir.API.Repositorios;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gerir.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaRepositorio _tarefarepositorio;

        public TarefaController()
        {
            _tarefarepositorio = new TarefaRepositorio();
        }

        [HttpPost]
        public IActionResult Cadastrar(Tarefa tarefa)
        {
            try
            {
                _tarefarepositorio.Cadastrar(tarefa);

                return Ok(tarefa);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        //[Authorize]
        [HttpGet("{IdUsuario}")]
        public IActionResult MinhasTarefas(Guid IdUsuario)
        {
            try
            {
                var Listadetarefas = _tarefarepositorio.ListarTodos(IdUsuario);

                return Ok(Listadetarefas);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPut]
        public IActionResult Editar(Tarefa tarefa)
        {
            try
            {   
                _tarefarepositorio.Editar(tarefa);
                return Ok(tarefa);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [Authorize]
        [HttpDelete("{Idtarefa}")]

        public IActionResult Remover(Guid Idtarefa)
        {
            try
            {

                _tarefarepositorio.Remover(Idtarefa);

                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

         
        [HttpPut("alterarstatus/{IdTarefa}")]
        public IActionResult AlterarStatus(Guid Idtarefa)
        {
            try
            {

                _tarefarepositorio.AlterarStatus(Idtarefa);

                return Ok(Idtarefa);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
