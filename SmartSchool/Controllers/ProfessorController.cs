using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.Models;

namespace SmartSchool.Controllers
{

    [ApiController]
    [Route("api/[controller]")] //rota a ser seguida na minha api
    public class ProfessorController : ControllerBase
    {
        
        public ProfessorController(){}

        [HttpGet]
        public IActionResult Get() {

             return Ok("Professores: Karla,  Roberta, João,  Marco");
            
        }

    }
}