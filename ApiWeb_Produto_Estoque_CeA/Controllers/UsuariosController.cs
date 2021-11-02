using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiWeb_Produto_Estoque_CeA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiWeb_Produto_Estoque_CeA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ProdutoContext _context;

        public UsuariosController(ProdutoContext context)
        {
            _context = context;
        }

        // POST: api/Usuarios/Enter
        [HttpPost("Enter")]
        public async Task<ActionResult<Usuario>> Enter(Usuario user)
        {
            var hasUsuario = await _context.Usuarios.
                    FirstOrDefaultAsync(c => c.name == user.name && c.password == user.password);

            if (hasUsuario != null)
                return Ok(hasUsuario);
            else
                return BadRequest();
        }

    }
}