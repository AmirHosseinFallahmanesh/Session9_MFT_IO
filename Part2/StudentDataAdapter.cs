using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
   public class StudentDataAdapter
    {

        public Student StudentFormatAdapter(string data)
        {
            Student result = new Student();
            string[] info= data.Split(",");
            result.Name = info[0];
            result.Surname = info[1];
            result.Age = int.Parse(info[2]);

            return result;
        }

    }
}
