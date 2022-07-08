using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Part2
{
    public class FileContext
    {
        private string baseAddress;
        private StudentDataAdapter studentDataAdapter;
        public FileContext(string path)
        {
            baseAddress = path;
            studentDataAdapter = new StudentDataAdapter();
        }
        public void Save(List<Student> students)
        {
            StreamWriter writer = new StreamWriter(baseAddress);
            for (int i = 0; i < students.Count; i++)
            {
                writer.WriteLine(students[i]); 
            }
            writer.Flush();
            writer.Close();
        }

        public List<Student> Load()
        {
            List<Student> result = new List<Student>();
            StreamReader streamReader = new StreamReader(baseAddress);
            while (!streamReader.EndOfStream)
            {
               string data= streamReader.ReadLine();
              Student student=
                    studentDataAdapter.StudentFormatAdapter(data);

                result.Add(student);
            }

            streamReader.Close();

            return result;
        }


    }
}
