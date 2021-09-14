using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class StudentController : Controller
    {
        List<Student> _ostudents = new List<Student>()
        {
            new Student(){Id=1, Nome= "Luca", Fileira = 1001},
             new Student(){Id=2, Nome= "Leo", Fileira = 1002},
              new Student(){Id=3, Nome= "Lara", Fileira = 1003},
               new Student(){Id=4, Nome= "Ana", Fileira = 1004},
                new Student(){Id=5, Nome= "Anderson", Fileira = 1005},
                 new Student(){Id=6, Nome= "Andreia", Fileira = 1006},
                  new Student(){Id=7, Nome= "Adriana", Fileira = 1007},
                   new Student(){Id=8, Nome= "Anselmo", Fileira = 1008},
                    new Student(){Id=9, Nome= "Gustavo", Fileira = 1009},
                     new Student(){Id=10, Nome= "Fred", Fileira = 1010},

        };

        [HttpGet("id")]
        public IActionResult Gets()
        {
            if (_ostudents.Count == 0)
            {
                return NotFound("Nenhuma lista encontrada");
            }
            return Ok(_ostudents);
        }

        [HttpGet("GetStudent")]
        public IActionResult Get(int id)
        {
            var oStudent = _ostudents.SingleOrDefault(x => x.Id == id);
            if (oStudent == null)
            {
                return NotFound("Nenhum aluno encontrado");
            }
            return Ok(oStudent);
        }

        [HttpPost("id")]
        public IActionResult Save(Student oStudent)
        {
            _ostudents.Add(oStudent);
            if (_ostudents.Count == 0)
            {
                return NotFound("Nenhuma lista encontrada");
            }
            return Ok(_ostudents);
        }

        [HttpDelete("id")]
        public IActionResult DeleteStudent(int id)
        {
            var oStudent = _ostudents.SingleOrDefault(x => x.Id == id);
            if (oStudent == null)
            {
                return NotFound("Nenhuma lista encontrada");
            }
            _ostudents.Remove(oStudent);
            if (_ostudents.Count == 0)
            {
                return NotFound("Nenhuma lista encontrada");
            }
            return Ok(_ostudents);
        }
        [HttpPut("id")]
        public IActionResult Put(int id, Student _ostudent)
        {
            var oStudent = _ostudents.SingleOrDefault(x => x.Id == id);
            
            if (oStudent == null)
            {
                return NotFound("Nenhuma lista encontrada");
            }
            _ostudents.Add(oStudent);
            if (_ostudents.Count == 0)
            {
                return NotFound("Nenhuma lista encontrada");
            }
            return Ok(_ostudents);
        }
    }
}

