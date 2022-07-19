using EFCore.Dominio;
using EFCore.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCore.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public readonly HeroiContexto _contexto;

        public ValuesController(HeroiContexto contexto)
        {
            _contexto = contexto;
        }

        // GET: api/<ValuesController>
        [HttpGet("filtro/{nome}")]
        public ActionResult GetFiltro(string nome)
        {
            //var listHeroi = _contexto.Herois.ToList();
            var listaHeroi = (from heroi in _contexto.Herois
                              where heroi.Nome.Contains(nome)
                              select heroi).ToList();
            return Ok(listaHeroi);
        }

        //// GET api/<ValuesController>/5
        //[HttpGet("{nomeHeroi}")]
        //public ActionResult Get(string nomeHeroi)
        //{
        //    var heroi = new Heroi { Nome = nomeHeroi };
        //    _contexto.Herois.Add(heroi);
        //    _contexto.SaveChanges();
        //    return Ok();
        //}

        // GET api/<ValuesController>/5
        //[HttpGet("{AddRange}")]
        //public ActionResult GetAddRange()
        //{
        //    _contexto.AddRange(
        //        new Heroi { Nome = "Capitão América"},
        //        new Heroi { Nome = "Doutor Estranho" },
        //        new Heroi { Nome = "Pantera Negra" },
        //        new Heroi { Nome = "Viúva Negra" },
        //        new Heroi { Nome = "Hulk" },
        //        new Heroi { Nome = "Gavião Arqueiro" },
        //        new Heroi { Nome = "Capitão Marvel" }
        //        );
        //    _contexto.SaveChanges();
        //    return Ok();
        //}



        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpGet("Delete/{id}")]
        public void Delete(int id)
        {
            var heroi = _contexto.Herois.Where(x => x.Id == id).Single();
            _contexto.Herois.Remove(heroi);
            _contexto.SaveChanges();
        }
    }
}
