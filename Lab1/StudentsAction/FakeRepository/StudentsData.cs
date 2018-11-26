using System.Collections.Generic;
using StudentsAction.Entities;

namespace StudentsAction.FakeRepository
{
    public static class StudentsData
    {
        private static List<Group> _groups;

        public static List<Group> GetData
        {
            get
            {
                SetData();
                return _groups;
            }
        }

        private static void SetData()
        {
            var student1 = new Student()
            {
                GroupName = "Web group",
                Name = "Valentin Gorkuy",
                Mark = new List<int>()
                {
                    4,5,6,7
                }
            };

            var student2 = new Student()
            {
                GroupName = "Web group",
                Name = "Ivan Shaveko",
                Mark = new List<int>()
                {
                    10,10,10,9,4
                }
            };

            var student3 = new Student()
            {
                GroupName = "Web group",
                Name = "Petr Voznik",
                Mark = new List<int>()
                {
                    4,4,4
                }
            };
            var student4 = new Student()
            {
                GroupName = "Economic group",
                Name = "Ararat Bulogik",
                Mark = new List<int>()
                {
                    4
                }
            };
            var student5 = new Student()
            {
                GroupName = "Economic group",
                Name = "Pavel Tehknkovich",
                Mark = new List<int>()
                {
                    7,10,8,10,10,9
                }
            };

            var webGroup = new Group()
            {
                Name = "Web group",
                Students = new List<Student>()
                {
                    student1,
                    student2,
                    student3
                }
            };

            var economicGroup = new Group()
            {
                Name = "Economic group",
                Students = new List<Student>()
                {
                    student4,
                    student5
                }
            };

            _groups = new List<Group>();
            _groups.Add(webGroup);
            _groups.Add(economicGroup);
        }
    }
}