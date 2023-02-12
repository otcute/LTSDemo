using DJ_WebDesignCore.Entites.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ_WebDesignCore.Entites.Business
{
	public class StudentLAHoliday:BaseEntity
	{
		public StudentLA? StudentLA { get; set; }
		public Holiday? Holiday { get; set; }
		public int? TotalDay { get; set; }
	}
}
