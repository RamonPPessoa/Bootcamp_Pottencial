using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CriandoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()

            };
            return Ok(obj);
        }

        [HttpGet("Apresentar/{name}")]
        public IActionResult Apresentar( string name)
        {
            var mensagem = $"Hello, {name} welcome !!";
            return Ok(new {mensagem});
        }
    }
}