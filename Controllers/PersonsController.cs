using Azure02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Azure02.Controller
{
    [ApiController]
    [Route("api/[Controller]")]

    public class PersonsController : ControllerBase
    {
        //constructor:
        private readonly Myazure02Context _context;
        public PersonsController(Myazure02Context context)
        {
            _context = context;
        }

        // methods
        [HttpGet("GetAllPersons")]
        public async Task<IActionResult> GetAllPersons()
        {
            var persons = await _context.Persons.ToListAsync();
            return Ok(persons);
        }

        [HttpGet("GetPersonById")]
        public async Task<IActionResult> GetPersonById(int id)
        {
            var person = await _context.Persons.FindAsync(id);
            // if (person == null)
            // {
            //     return NotFound("This person does not exist");
            // }
            return Ok(person);

        }

        [HttpPost]
        public async Task<IActionResult> CreatePerson(Person person)
        {
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPersonById), new { id = person.Id }, person);
            // return Ok("Saved Successfully");
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            var customer = await _context.Persons.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            _context.Persons.Remove(customer);
            await _context.SaveChangesAsync();

            return Ok("Deleted Successfully");
        }




    }

}