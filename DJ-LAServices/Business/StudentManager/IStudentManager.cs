using System;
using DJ_LAServices.DAO;
using DJ_WebDesignCore.Entites.Student;

namespace DJ_LAServices.Business.StudentManager
{
	public  interface IStudentManager
	{
	 StudentLA createStudent(StudentLA newData);
	}
}

