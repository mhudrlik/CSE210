using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "http://www.journalpromptgenerator.com/#";
        HttpClient client = new HttpClient();
        string content = await client.GetStringAsync(url);

        string startTag = "<div class=\"prompt\" id=\"prompt\" style=\"padding-bottom: 40px;\">";
        string endTag = "</div>";
        int startIndex = content.IndexOf(startTag) + startTag.Length;
        int endIndex = content.IndexOf(endTag, startIndex);
        string prompt = content.Substring(startIndex, endIndex - startIndex).Trim();

        Console.WriteLine(prompt);
    }
}
