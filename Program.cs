using ConsoleApp2.Documents;

class Program
{
    static void selectFunc(int select)
    {
        string[] menuArr = { "1 - Basic", "2 - Pro", "3 - Expert", "4 - Exit" };
        for (int i = 0; i < menuArr.Length; i++)
        {
            if (select == i + 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(menuArr[i]);
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.WriteLine(menuArr[i]);
            }
        }
    }

    static void selectNum()
    {

        int select = 1;
        selectFunc(select);
        while (true)
        {

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
            if (consoleKeyInfo.Key == ConsoleKey.UpArrow)
            {
                if (select == 1) { select = 4; }
                else { select--; }
            }
            else if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
            {
                if (select == 4) { select = 1; }
                else { select++; }
            }

            else if (consoleKeyInfo.Key == ConsoleKey.Enter)
            {
                if (select == 1)
                {
                    DocumentClass docProgram1 = new DocumentClass("Doc", "basic", "Miri", DateTime.Now, "DocProgram");
                    docProgram1.Show();
                    docProgram1.OpenDocument();
                    docProgram1.EditDocument();
                    docProgram1.SaveDocument();
                    docProgram1.Dispose();
                    Thread.Sleep(2500);

                }
                else if (select == 2)
                {
                    DocumentClass docProgram2 = new ProDocumentClass("Doc", "basic", "Miri", DateTime.Now, "DocProgram");
                    docProgram2.Show();
                    docProgram2.OpenDocument();
                    docProgram2.EditDocument();
                    docProgram2.SaveDocument();
                    docProgram2.Dispose();
                    Thread.Sleep(2500);
                }
                else if (select == 3)
                {
                    DocumentClass docProgram3 = new ExpertDocumentClass("Doc", "basic", "Miri", DateTime.Now, "DocProgram");
                    docProgram3.Show();
                    docProgram3.OpenDocument();
                    docProgram3.EditDocument();
                    docProgram3.SaveDocument();
                    docProgram3.Dispose();
                    Thread.Sleep(2500);
                }
                else if (select == 4)
                {
                    Console.WriteLine("Bye bye");
                    Thread.Sleep(10000);

                    return;
                }
            }
            Console.Clear();
            selectFunc(select);

        }



    }
    static void Main(string[] args)
    {
        selectNum();
    }
}