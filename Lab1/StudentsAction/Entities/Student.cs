using System.Collections.Generic;

namespace StudentsAction.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public string GroupName { get; set; }
        public List<int> Mark { get; set; }

        public override string ToString()
        {
            string markString = null;

            foreach (var mark in Mark)
            {
                markString += $"{mark} ";
            }

            return $"Group:{GroupName}\t Name:{Name}, Marks: {markString}\n";
        }
    }
}
