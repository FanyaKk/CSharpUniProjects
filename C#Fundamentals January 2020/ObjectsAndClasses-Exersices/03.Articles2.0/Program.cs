using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articlesList = new List<Article>();

            int numberOfArticles = int.Parse(Console.ReadLine());

            string title = "";
            string content = "";
            string author = "";

            Article article = new Article(title, content, author);

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] articles = Console.ReadLine().Split(", ");

                title = articles[0];
                content = articles[1];
                author = articles[2];

                article = new Article(title, content, author);

                articlesList.Add(article);
            }

            string orderCriteria = Console.ReadLine();

            if (orderCriteria == "title")
            {
                articlesList = articlesList
                    .OrderBy(t => t.Title).ToList();
            }
            else if (orderCriteria == "content")
            {
                articlesList = articlesList
                    .OrderBy(c => c.Content).ToList();
            }
            else if (orderCriteria == "author")
            {
                articlesList = articlesList
                    .OrderBy(a => a.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articlesList));
        }
    }
}
