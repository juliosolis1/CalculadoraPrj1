using CalculadoraPrj2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculadoraPrj2.Controllers
{
    // Ruta base: /api/calculos
    [RoutePrefix("api/calculos")]
    public class CalculosController : ApiController
    {
        private readonly CalculosRepository _repo = new CalculosRepository();

        // GET api/calculos
        // Devuelve todos los cálculos
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetTodos()
        {
            var datos = _repo.GetTodos();
            return Ok(datos);   // devuelve 200 OK + JSON
        }

        // GET api/calculos/sumas
        [HttpGet]
        [Route("sumas")]
        public IHttpActionResult GetSumas()
        {
            return Ok(_repo.GetSumas());
        }

        // GET api/calculos/restas
        [HttpGet]
        [Route("restas")]
        public IHttpActionResult GetRestas()
        {
            return Ok(_repo.GetRestas());
        }

        // GET api/calculos/multiplicaciones
        [HttpGet]
        [Route("multiplicaciones")]
        public IHttpActionResult GetMultiplicaciones()
        {
            return Ok(_repo.GetMultiplicaciones());
        }

        // GET api/calculos/divisiones
        [HttpGet]
        [Route("divisiones")]
        public IHttpActionResult GetDivisiones()
        {
            return Ok(_repo.GetDivisiones());
        }

        // GET api/calculos/cuadrados
        [HttpGet]
        [Route("cuadrados")]
        public IHttpActionResult GetCuadrados()
        {
            return Ok(_repo.GetCuadrados());
        }

        // GET api/calculos/raices
        [HttpGet]
        [Route("raices")]
        public IHttpActionResult GetRaices()
        {
            return Ok(_repo.GetRaices());
        }
    }
}

