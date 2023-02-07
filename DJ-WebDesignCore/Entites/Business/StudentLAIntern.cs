using DJ_WebDesignCore.Entites.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Business
{
    public class StudentLAIntern : BaseEntity
    {
        public int? StudentLAId { get; set; }
        public StudentLA? StudentLA { get; set; }
        public int? InternId { get; set; }
        public Intern? Intern { get; set; }
        public DateTime? JoinDateTime { get; set; }
    }
}
