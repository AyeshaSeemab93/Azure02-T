using Azure02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Azure02.Controller
{
    [ApiController]
    [Route("api/[Controller]")]

    public class ValueController : ControllerBase
    {
        

        // methods
        [HttpGet("GetAllPersons")]
        public async Task<IActionResult> GetAllPersons()
        {
            
            return Ok("you are here");
        }



    }

}