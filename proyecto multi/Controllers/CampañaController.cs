using proyecto_multi.Models;

namespace proyecto_multi.Controllers
{
    public class CampañaController
    {
        
        private readonly SostenibilidadContext _context;
        public CampañaController(SostenibilidadContext context)
        {
            this._context = context;

        }

    }
}