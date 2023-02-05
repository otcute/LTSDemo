using DJ_LAUseCase.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_LAServices.Business
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
