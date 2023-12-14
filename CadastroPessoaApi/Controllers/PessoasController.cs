using CadastroPessoaApi.ViewModel;
using CADASTROPESSOAAPI.SERVICE;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace CadastroPessoasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet("getall")]
        public IEnumerable<PessoaViewModel> getall()
        {
            var service = new servicePessoa();
            return service.getall();
        }
        [HttpGet("GetById/{pessoid}")]
        public PessoaViewModel GetById(int pessoid)
        {
            var service = new servicePessoa();
            return service.GetByid(pessoid);
        }

        //[HttpGet("GetByIdprimeiroNome/{primeiroNome}")]
        //public PESSOAVIEWMODEL GetByIdprimeiroNome(string primeiroNome)
        //{
        //    var service = new SERVICEPESSOA();
        //    return service.(primeiroNome);


        //}
        [HttpPut("update/{pessoaId}/{primeiroNome}")]
        public void update(int pessoaId, string primeiroNome)
        {
            var service = new servicePessoa();
            service.Update(pessoaId, primeiroNome);
        }
        [HttpPost("create")]

        public IActionResult Create(PESSOAVIEWMODEL pessoa)
        {
            var service = new SERVICEPESSOA();
            var resultado = SERVICE.Create(pessoa);

            var result = new
            {
                Sucess = true,
                Data = "Cadastro Realizado com sucesso"
            };
            return Ok(result);


        }
    }