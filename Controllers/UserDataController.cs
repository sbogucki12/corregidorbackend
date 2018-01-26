using System.Threading.Tasks;
using AutoMapper;
using corregidorApi.Controllers.Resources;
using corregidorApi.Models;
using corregidorApi.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace corregidorApi.Controllers {

    [Produces ("application/json")]
    [Route ("api/userdata")]
    public class UserDataController : Controller {
        private readonly CorregidorDbContext _context;

        public UserDataController (CorregidorDbContext context) 
        {
            _context = context;
        }

        // POST: api/userdata
        [HttpPost]
        public async Task<IActionResult> PostUserData ([FromBody] UserData userData) 
        {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            _context.UserDataContacts.Add(userData);
            await _context.SaveChangesAsync ();

            return CreatedAtAction("GetUserData", new { id = userData.Id }, userData);
        }

        // [HttpPost ("/api/userdata")]
        // public IActionResult SubmitUserData ([FromBody] UserDataResource userDataResource) {
        //     var userData = mapper.Map<UserDataResource, UserData> (userDataResource);

        //     return Ok (userData);
        // }
    }
}