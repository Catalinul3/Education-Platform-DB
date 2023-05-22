using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.Database
{
    public static class Dependency
    {
        public static Entities _context;
        static Dependency()
        {
            _context = new Entities();
        }
    }
}
