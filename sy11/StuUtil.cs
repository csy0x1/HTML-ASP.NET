using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csy
{
    public class StuUtil
    {
        private static IList<IStudent> _students = new List<IStudent>();
        public static void AddStu(IStudent stu)
        {
            _students.Add(stu);
        }

        public static IList<IStudent> GetStudents()
        {
            return _students;
        }
    }
}