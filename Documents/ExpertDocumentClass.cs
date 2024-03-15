namespace ConsoleApp2.Documents;

public class ExpertDocumentClass : ProDocumentClass, IDisposable
{
    public ExpertDocumentClass() 
        : base()
    {

    }
    public ExpertDocumentClass(string name, string description, string author, DateTime created, string title) 
        : base(name, description, author, created, title)

    {

    }

    public void Dispose()
    {
        Console.WriteLine("End ");
    }

    public void Edit()
    {
        Console.WriteLine(" Document Edited");
    }

    public void Open()
    {
        Console.WriteLine(" Document Opened");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Document Saved ");
    }
}
