using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.Models;

namespace SmartSchool.Controllers
{

    [ApiController]
    [Route("api/[controller]")] //rota a ser seguida na minha api
    public class AlunoController : ControllerBase
    {

        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno (){
                Id = 1,
                Name = "Marta",
                Sobrenome = "Maria",
                Telefone = "4586955666"
            },
            new Aluno (){
                Id = 2,
                Name = "Joana",
                Sobrenome = "Cristina",
                Telefone = "45865556126"
            },
            new Aluno (){
                Id = 3,
                Name = "João",
                Sobrenome = "Luiz",
                Telefone = "4586955666"
            },

        };

        public AlunoController(){}

        [HttpGet]
        public IActionResult Get() {

             return Ok(Alunos);
            
        }
            // rota por id
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id) {

            var aluno = Alunos.FirstOrDefault( a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não foi encontrado");

             return Ok(aluno);
            
        }
            //rota por nome
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string Sobrenome) {

            var aluno = Alunos.FirstOrDefault( a => 
            
            a.Name.Contains(nome) && a.Sobrenome.Contains(Sobrenome)
            );

            if (aluno == null) return BadRequest("Aluno não foi encontrado");

             return Ok(aluno);
            
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno) {

             return Ok(aluno);
            
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno) {

             return Ok(aluno);
            
        }

         [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno) {

             return Ok(aluno);
            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {

             return Ok();
            
        }

    }
}