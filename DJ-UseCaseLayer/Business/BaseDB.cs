using DJ_UseCaseLayer.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_UseCaseLayer.Business
{
    public class BaseDB
    {
        public readonly LAContext _context;

        public BaseDB()
        {
            _context = new LAContext();
        }
    }
}
