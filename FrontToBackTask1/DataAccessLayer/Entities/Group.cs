using FrontToBackTask1.DataAccessLayer.Entities.Common;

namespace FrontToBackTask1.DataAccessLayer.Entities;

public class Group : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Student> Students { get; set; } = new List<Student>();
    public ICollection<TeacherGroup> TeachersGroups { get; set; } = new List<TeacherGroup>();

    public override string ToString()
    {
        return $"Name:";
    }
}
