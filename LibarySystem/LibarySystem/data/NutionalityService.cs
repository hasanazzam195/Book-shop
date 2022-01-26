using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibarySystem.data
{

    public class NutionalityService : INutionalityService
    {
        LibaryContext context;
        public NutionalityService(LibaryContext _context)
        {
            context = _context;
        }
        public List<Nutionality> loadAllNution()
        {
            List<Nutionality> linutionality = context.nutionalityContext.ToList();
            return linutionality;
        }
    }
}
