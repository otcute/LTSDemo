using System;
using DJ_LAServices.Business.StudentManager;
using DJ_LAServices.DAO;
using DJ_WebDesignCore.Entites.Student;

namespace DJ_ImplementLayer.Business.StudentManager
{
	public class StudentManager: IStudentManager
	{
		LAContext _context;
		public StudentManager(LAContext context)
		{
			_context = context;
		}

        public StudentLA createStudent(StudentLA newData)
        {
			_context.studentLAs.Add(newData);
			_context.SaveChanges();
			return newData;
        }
    }
}

