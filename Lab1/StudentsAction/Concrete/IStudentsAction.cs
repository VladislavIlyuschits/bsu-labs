namespace StudentsAction.Concrete
{
    public interface IStudentsAction
    {
        string GetStudentAverageMark(string studentName);
        string GetGropAverageMark(string groupName);
    }
}