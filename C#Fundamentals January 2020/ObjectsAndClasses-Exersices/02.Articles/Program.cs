using System;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArticle = Console.ReadLine().Split(", ").ToArray();

            string title = inputArticle[0];
            string content = inputArticle[1];
            string author = inputArticle[2];

            Article article = new Article(title, content, author);

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] command = Console.ReadLine().Split(": ").ToArray();

                string currCommand = command[0];

                if (currCommand == "Edit")
                {
                    string newContent = command[1];
                    article.Edit(newContent);
                }
                else if (currCommand == "ChangeAuthor")
                {
                    string newAuthor = command[1];
                    article.ChangeAuthor(newAuthor);
                }
                else if (currCommand == "Rename")
                {
                    string newTitle = command[1];
                    article.Rename(newTitle);
                }
            }
            Console.WriteLine(article);
        }
    }
}
