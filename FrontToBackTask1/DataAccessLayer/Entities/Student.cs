using FrontToBackTask1.DataAccessLayer.Entities.Common;

namespace FrontToBackTask1.DataAccessLayer.Entities;

public class Student : BaseEntity
{
    public string Name { get; set; }
    public int GroupId { get; set; }
    public Group? Group { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, GroupId: {GroupId}, Group Name: {Group.Name}";
    }

}
