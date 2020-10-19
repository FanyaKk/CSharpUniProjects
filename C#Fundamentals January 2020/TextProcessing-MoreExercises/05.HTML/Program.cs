using System;

namespace _05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string contentArticle = Console.ReadLine();
            string comment = "";

            Console.WriteLine($"<h1>\n  {title}\n</h1>");
            Console.WriteLine($"<article>\n  {contentArticle}\n</article>");
            while ((comment = Console.ReadLine()) != "end of comments")
            {
                Console.WriteLine($"<div>\n  {comment}\n</div>");
            }
        }
    }
}
