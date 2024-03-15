namespace ConsoleApp2.Documents;

public class ProDocumentClass : DocumentClass , IDisposable
{

    public ProDocumentClass() 
        : base() { }
    public ProDocumentClass(string name, string description, string author, DateTime created, string title) 
        : base(name, description, author, created, title)
    {

    }

    public void Open() { Console.WriteLine("Document Opened"); }

    public sealed override void EditDocument()
    {
        Console.WriteLine("Document Edited  ");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
    }

    public void Dispose()
    {
        Console.WriteLine("End ");

    }
}
