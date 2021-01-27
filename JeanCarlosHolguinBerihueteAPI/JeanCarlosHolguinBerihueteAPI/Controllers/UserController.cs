using JeanCarlosHolguinBerihueteAPI.Data;
using JeanCarlosHolguinBerihueteAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeanCarlosHolguinBerihueteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserContext _db;

        public UserController(UserContext db) {
            this._db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get() {

            try {
                var users = await this._db.User.ToListAsync();
                return Ok(users);
            } catch (Exception) {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserDTO user) {
            try {


                var department = this._db.Departments.Where(x => x.ID == user.Department).FirstOrDefault();


                var _user = new User() { 
                    Names =  user.Names,
                    Surnames = user.Surnames,
                    Genre = user.Genre,
                    Document = user.Document,
                    Birthday = Convert.ToDateTime(user.Birthday),
                    Department = department,
                    Position = user.Position,
                    Supervisor = user.Supervisor
                };
                

                await this._db.User.AddAsync(_user);
                await this._db.SaveChangesAsync();

                return Ok("Usuario registrado exitosamente.");

            } catch (Exception) {

          
                return BadRequest();
            }
        }
    }
}
