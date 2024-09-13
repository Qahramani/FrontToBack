using FrontToBackTask1.DataAccessLayer.Entities.Common;

namespace FrontToBackTask1.DataAccessLayer.Entities;

public class Teacher : BaseEntity
{
    public string Name { get; set; }
    public ICollection<TeacherGroup> TeacherGroups { get; set; } = new List<TeacherGroup>(); 
}
