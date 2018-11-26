using System.Collections.Generic;

namespace StudentsAction.Entities
{
    public class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public override string ToString()
        {
            string groups = null;

            foreach (var student in Students)
            {
                groups += $"{student}";
            }

            return $"{groups}";
        }
    }
}