using biblio.DTOs;
using biblio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace biblio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivreController : Controller
    {
        private readonly ILivreService _livreService;
        public LivreController(ILivreService livreService) 
        { 
        
            _livreService = livreService;
        }
        [HttpGet("Lister")]
        public ActionResult<IEnumerable<LivreDTO>> ListerLivres()
        {
            try
            {
                var liste = _livreService.ListerLivres();
                return Ok(liste);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Ajout")]
        public IActionResult AjouterLivre(LivreDTO livreDTO) 
        {
            try
            {
                _livreService.AjouterLivre(livreDTO);
                return CreatedAtAction(nameof(ListerLivres),livreDTO);
            }
            catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Modifier/{id}")]
        public IActionResult ModifierLivre(int id, LivreDTO livreDTO)
        {
            try
            {
                _livreService.ModifierLivre(id, livreDTO);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    
    }
}
