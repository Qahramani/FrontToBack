using FrontToBackTask1.DataAccessLayer.Entities.Common;

namespace FrontToBackTask1.DataAccessLayer.Entities;

public class TeacherGroup : BaseEntity
{
    public int TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
    public int GrouId { get; set; }
    public Student? Student { get; set; }
}
