using JeanCarlosHolguinBerihueteAPI.Data;
using JeanCarlosHolguinBerihueteAPI.Models;
using Microsoft.AspNetCore.Cors;
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
    [EnableCors("AllowOrigin")]
    public class DepartmentController : Controller {

        private readonly UserContext _db;   
        
        public DepartmentController(UserContext db) {
            this._db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get() {

            try {
                var departments = await this._db.Departments.ToListAsync();
                return Ok(departments);
            } catch (Exception) {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Department department) {

            try {

                await this._db.AddAsync(department);
                await this._db.SaveChangesAsync();


                return Ok("Departamento ingresado exitosamente.");
            } catch (Exception) {

                return BadRequest();
            }
        }
    }
}
