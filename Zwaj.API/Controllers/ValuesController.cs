using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Zwaj.API.Data;
using Zwaj.API.Models;

namespace Zwaj.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            this._context = context;

        }
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {  
            var _value = await _context.Values.ToListAsync();
            return Ok(_value) ;
        }
         [HttpGet("{Id}")]
         public async Task<IActionResult> GetValue(int Id)
        {  
            var _value = await _context.Values.Where(Get => Get.Id == Id).FirstOrDefaultAsync();
            if(_value == null)
            {
                return Ok(null);
            }
            return Ok(_value) ;
        }
    }
}