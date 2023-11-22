using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCReactApp.Server.Models;

namespace MVCReactApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class EmpleadosController : Controller
    {
        private readonly MvcreactContext _context;

        public EmpleadosController(MvcreactContext context)
        {
            _context = context;
        }

        // GET: Empleados
        [HttpGet]
        public async Task<List<Empleado>> Index()
        {
            List<Empleado> lista = await _context.Empleados.ToListAsync();
            return lista;            
        }

        
        
    }
}
