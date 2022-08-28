using Balta.ContentContext;

class Program
{
    private static void Main(string[] args)
    {
        var articles = new List<Article>();
        articles.Add(new Article("Artigo 1", "Orientacao-objetos"));
        articles.Add(new Article("Artigo 2", "Orientacao-p"));
        articles.Add(new Article("Artigo 3", "Orientacao-teste"));

        foreach(var article in articles)
        {
            Console.WriteLine(article.Id);
            Console.WriteLine("");
            Console.WriteLine(article.Title);
            Console.WriteLine("");
            Console.WriteLine(article.Url);
        }
    }
}