using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DevIO.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext meuDbContext) 
            => _contexto = meuDbContext;
        

        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Deivid Roger",
                SobreNome = "Oliveira Santos",
                DataNascimento = DateTime.Now,
                Email = "deivid@deividroger.net"
            };

            _contexto.Alunos.Add(aluno);

            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            var aluno3 = _contexto.Alunos.FirstOrDefault(x => x.Email == "deivid@deividroger.net");
            var aluno4 = _contexto.Alunos.Where(x => x.Nome == "Deivid");
            
            aluno.Nome = "João";
            _contexto.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();


            return View("_Layout");
        }
    }
}