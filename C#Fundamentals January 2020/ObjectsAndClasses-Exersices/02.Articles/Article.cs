using System;
namespace _02.Articles
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit (string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor (string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename (string newTitle)
        {
            this.Title = newTitle;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
