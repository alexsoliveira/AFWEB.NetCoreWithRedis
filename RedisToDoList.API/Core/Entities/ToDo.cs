namespace RedisToDoList.API.Core.Entities;

public class ToDo
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public bool Done { get; private set; }

    public ToDo(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
        Done = false;
    }

}