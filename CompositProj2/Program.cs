using System;

namespace CompositProj2
{
    class Program
    {
        static void Main(string[] args)
        {
            var body = new ItemComposit("div");
            var p = new ItemLeaf("p", "Testing html tag library");
            var p2 = new ItemLeaf("p", "Paragraph 2");
            body.AddToGroup(p);
            body.AddToGroup(p2);

            var html = new ItemComposit("html");
            html.AddToGroup(body);

            html.ReadItem(" ");

            Console.ReadLine();
        }
    }
}
