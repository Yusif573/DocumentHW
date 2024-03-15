namespace ConsoleApp2.Documents;

public class DocumentClass : IDisposable
{
    public static int staticId { get; set; }
    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public DateTime Created { get; set; }
    public string Title { get; set; }

    public DocumentClass()
    {
        Id = staticId++;
    }
    public DocumentClass(string name, string description, string author, DateTime created, string title)
    {
        Id = staticId++;
        Name = name;
        Description = description;
        Author = author;
        Created = created;
        Title = title;

    }
    public virtual void EditDocument()
    {

        Console.WriteLine("Can Edit in Pro and Expert versions");


    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Can Save in Pro and Expert versions");


    }
    public void OpenDocument()
    {
        Console.WriteLine("Document Opened");

    }



    public virtual void Show()
    {
        Console.WriteLine($"Id: {Id}\nName: {Name}\nDescription: {Description}\nAuthor: {Author}\nCreated: {Created.Hour}/ {Created.Minute} /{Created.Second}\nTitle: {Title}\n");
    }

    public void Dispose()
    {
        Console.WriteLine("End ");
    }
}
