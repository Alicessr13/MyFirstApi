using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")] //acessa o endpoint por essa rota
    [ApiController] //precisa colocar para identificar que é um controller
    public class UserController : ControllerBase
    {
        //controllerbase = herança, atraves dele acessar funções importantes
        
        //IActionResult = endpoint sempre devolve essa interface
        [HttpGet]//declarando o tipo da função
        //[Route("{id}")] //passando informação pela rota (path)
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]//especificando os tipos de respostas que cada endpoint pode retornar
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        //public IActionResult Get(int id) //passando parametros pela url (query string)
        public IActionResult GetById([FromHeader]int id, [FromHeader] string nickname)
        //[] especificando de onde o valor vem, se não colocar nada ele vem da query string, para vir do header precisa especificar (para deixar opcional string?)
        {
            var response = new User
            {
                Id = 1,
                Age = 10,
                Name = "Alice"
            };

            return Ok(response);
            //ok(); = função que devolve um ok
        }
    }
}
