using Day44ThreadDemo.DataAccess;
using Day44ThreadDemo.DataAccess.Models;

namespace Day44ThreadDemo;

public class FileToDbService
{
    private const string TagFeedStart = @"<feeds>";
    private const string TagFeedEnd = @"</feeds>";
    private const string TagIdStart = @"<id>";
    private const string TagIdEnd = @"</id>";
    private const string TagTitleStart = @"<title>";
    private const string TagTitleEnd = @"</title>";
    private const string TagDescriptionStart = @"<description>";
    private const string TagDescriptionEnd = @"</description>";
    private const string TagLocationStart = @"<location>";
    private const string TagLocationEnd = @"</location>";
    
    public void TransferDataFromFileToDb(string filePath)
    {
        if (!File.Exists(filePath))
            Console.WriteLine($"{filePath} not found");

        var lines = File.ReadAllLines(filePath);

        var foundFeedData = false;
        Feed feed = null;
        //var feedList = new List<Feed>();

        using var context = new FeedDataDbContext();

        foreach (var line in lines)
        {
            if (foundFeedData)
            {
                if (line.Contains(TagIdStart))
                    feed.Id = GetTagData(line, TagIdStart, TagIdEnd);
                else if (line.Contains(TagTitleStart))
                    feed.Title = GetTagData(line, TagTitleStart, TagTitleEnd);
                else if (line.Contains(TagDescriptionStart))
                    feed.Description = GetTagData(line, TagDescriptionStart, TagDescriptionEnd);
                else if (line.Contains(TagLocationStart))
                {
                    feed.Location = GetTagData(line, TagLocationStart, TagLocationEnd);
                    foundFeedData = false;
                    //feedList.Add(feed);
                    context.Feeds.Add(feed);
                }
            }

            if (line.Contains(TagFeedStart))
            {
                foundFeedData = true;
                feed = new Feed();
            }
        }

        context.SaveChanges();
        Console.WriteLine("Saved Successfully!!");

        //foreach (var feed1 in feedList)
        //{
        //    Console.WriteLine(feed1);
        //}
    }

    public string GetTagData(string line, string tagStart, string tagEnd)
    {
        var positionStart = line.IndexOf(tagStart);
        if(positionStart < 0)
            return null;

        positionStart += tagStart.Length;

        var positionEnd = line.IndexOf(tagEnd);
        if (positionEnd < 0)
            return null;

        return line.Substring(positionStart, positionEnd - positionStart);
    }
}