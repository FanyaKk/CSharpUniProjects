using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        //public void OrderByTitle(List<Article> articleList)
        //{
        //    List<Article> sortedList = articleList.OrderBy(t => t.Title).ToList();
        //    articleList = sortedList;
        //}
        //public void OrderByContent(List<Article> articleList)
        //{
        //    List<Article> sortedList = articleList.OrderBy(c => c.Content).ToList();
        //    articleList = sortedList;
        //}
        //public void OrderByAuthor(List<Article> articleList)
        //{
        //    List<Article> sortedList = articleList.OrderBy(a => a.Author).ToList();
        //    articleList = sortedList;
        //}

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
