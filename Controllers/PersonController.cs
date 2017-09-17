using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using NetCore.Simple;
using NetCore.Simple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [Route("person/{id?}")]
    public class PersonController : Controller
    {

        [HttpGet]
        public IActionResult Index(Person person) {
            var editor = new Editor();
            if (person.Get()) {
                editor.Data = person;
            }
            return View(editor);
        }

        [HttpPost]
        [ValidateModel]
        public void Add(Person person) => person.Add();

        [HttpPut]
        [ValidateModel]
        public void Update(Person person) => person.Update();

        [HttpDelete]
        public void Delete(Person person) => person.Delete();

    }
}
