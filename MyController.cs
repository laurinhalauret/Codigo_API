using Microsoft.AspNetCore.Mvc;
using MeuProjeto.Services;

namespace MeuProjeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyController : ControllerBase
    {
        private readonly IService<MyEntity> _service;

        public MyController(IService<MyEntity> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Exemplo de uso do serviço
            return Ok("Funcionando!");
        }
    }
}
