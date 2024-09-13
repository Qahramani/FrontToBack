using FrontToBackTask1.DataAccessLayer.Entities.Common;

namespace FrontToBackTask1.DataAccessLayer.Entities;

public class Student : BaseEntity
{
    public string Name { get; set; }
    public int TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
}
