using System;
using System.Collections.Generic;
using StudentsAction.Entities;
using StudentsAction.FakeRepository;

namespace StudentsAction.Concrete
{
    public class StudentsAction : IStudentsAction
    {
        private readonly List<Group> _groups;

        public StudentsAction()
        {
            _groups = StudentsData.GetData;
        }

        public string GetGroupsData
        {
            get
            {
                string data = null;

                foreach (var item in _groups)
                {
                    data += item.ToString();
                }

                return data;
            }
        }

        public string GetStudentAverageMark(string studentName)
        {
            var studentToSearch = new Student();
            var flag = false;

            foreach (var group in _groups)
            {
                foreach (var student in group.Students)
                {
                    if (String.Equals(student.Name, studentName, StringComparison.CurrentCultureIgnoreCase))
                    {
                        studentToSearch = student;
                        flag = true;
                        break;
                    }
                }
            }

            if (flag)
            {
                double studentAvgMark = GetStudentAvg(studentToSearch.Mark);

                return $"Average {studentToSearch.Name} mark:{studentAvgMark }";
            }

            return "Wrong data";
        }

        public string GetGropAverageMark(string groupName)
        {
            var groupToSearch = new Group();
            var flag = false;

            foreach (var group in _groups)
            {
                if (String.Equals(group.Name, groupName, StringComparison.CurrentCultureIgnoreCase))
                {
                    groupToSearch = group;
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                double groupAvgMark = GetGroupAvg(groupToSearch.Students);

                return $"Average {groupToSearch.Name} mark:{groupAvgMark }";
            }

            return "Wrong data";
        }

        private double GetStudentAvg(List<int> marks)
        {
            double studentAvgMark = 0;

            foreach (var mark in marks)
            {
                studentAvgMark += mark;
            }

            studentAvgMark /= marks.Count;

            return Math.Round(studentAvgMark, 2);
        }
        private double GetGroupAvg(List<Student> students)
        {
            double groupAvg = 0;

            foreach (var student in students)
            {
                groupAvg += GetStudentAvg(student.Mark);
            }

            groupAvg /= students.Count;

            return Math.Round(groupAvg, 2);
        }
    }
}