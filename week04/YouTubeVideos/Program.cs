using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // video 1 section
        Video video1 = new Video("OneRepublic - I Ain’t Worried (From “Top Gun: Maverick”) [Official Music Video]", "OneRepublic", 154);
        Comment comment1 = new Comment("@bilal-h1z9t", "Imagine how nostalgic this would feel in 10 years");
        Comment comment2 = new Comment("@J.D.the_one", "Who’s here march 2026 Nostalgic button");
        Comment comment3 = new Comment("@dakilla4240", "Anyone December 2025 🔥");
        Comment comment4 = new Comment("@chicken", "Its March 2024, let's see how many legends are listening to this incredible song ❤");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);

        // video 2 section

        Video video2 = new Video("And Now I See | Jeffrey R. Holland | October 2025 General Conference", "General Conference of The Church of Jesus Christ", 923);
        Comment vComment1 = new Comment("@Radmrictus", "Who’s here after he passed today? You will be dearly missed ❤");
        Comment vComment2 = new Comment("@imnotajazzfan", "Im convinced if you sit for an hour or two listening to holland, you will leave a changed person");
        Comment vComment3 = new Comment("@marjoriestorland3882", "This great man did more than any other living apostle to convert my heart to my Lord and Savior Jesus Christ.");
        Comment vComment4 = new Comment("@wilsoncardoza2350", "I am so sad for Pres. Holland's passing. I feel enormous gratitude for this giant Prophet of God. His speeches, messages, books and firesides truly changed my life. I had the privilige to translate for him  when he came to my country. I hope that one day I will be able to thank him personally. I love you so much Elder Holland.");
        video2.AddComment(vComment1);
        video2.AddComment(vComment2);
        video2.AddComment(vComment3);
        video2.AddComment(vComment4);

        // video 3 section
        Video video3 = new Video("President Henry B. Eyring - Trust in God, Then Go and Do", "The Church of Jesus Christ of Latter-day Saints", 938);
        video3.AddComment(new Comment("@mayonnaise6316", "I'm cryiiing. Thank you President Eyring! even though its 2026 and in January!"));
        video3.AddComment(new Comment("@filtranscriptionists4990","THIS THE WORK OF THE LORD."));
        video3.AddComment(new Comment("@jc-oe5jx","The church of Jesus Christ of latter-day saints is true and brings joy when we follow the prophets counsel."));
        video3.AddComment(new Comment("@Frisby412","Love President B. Eyring! I am a recent convert and I am just very greatfull I have found the church and the restoration of the gospal and the prophet and apostles."));
        
        
        List<Video> videosCatalog = new List<Video>();
        videosCatalog.Add(video1);
        videosCatalog.Add(video2);
        videosCatalog.Add(video3);
        int i = 0;

        foreach (Video v in videosCatalog)
        {   
            i++;
            Console.WriteLine($"Video {i} Display");
            Console.WriteLine();
            Console.WriteLine(v.DisplayVideoInformation());
            foreach (Comment comment in v.GetComments())
            {
                Console.WriteLine(comment.GetComment());
                Console.WriteLine();
            }
        }
        
        
        
    }
}