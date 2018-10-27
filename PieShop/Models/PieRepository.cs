using System.Collections.Generic;
using System.Linq;

namespace PieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _context;

        public PieRepository(AppDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _context.Pies.ToList();
        }

        public Pie GetPieById(int pieId)
        {
            return _context.Pies.FirstOrDefault(p => p.Id.Equals(pieId));
        }
    }
}