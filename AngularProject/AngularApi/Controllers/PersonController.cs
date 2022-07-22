using AngularApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AngularApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly Context _context;

        public PersonController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public async  Task<IActionResult> GetPerson()
        {
            var Person =await _context.PersonInfos.ToListAsync();
            return Ok(Person);
        }
        [HttpPost]
        public IActionResult AddPerson(PersonInfo personInfo)
        {
            _context.Add(personInfo);
            _context.SaveChanges();
            return Created("",personInfo);
        }
    }
}
