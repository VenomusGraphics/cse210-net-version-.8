using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Video  Video1 = new ("Top 5 most deadly places", "GhostLUV_665", 500);
        Video  Video2 = new ("What actully happend in 1984 november 1st", "ThatConspiracyGuy", 1000);
        Video Video3 = new ("WarHammer 40K Factions Explanined"," Mork&Gork", 600);
        Video Video4 = new ("Budget napalm in 180 seconds (don't try this at home)","Millitary_History_ Guy", 180 );
        

        Video1.AddComment (new Comment("wacky_will_774","wow some of those places look crazy" ));
        Video1.AddComment (new Comment("Charlie_The_chocolate", "Super useful video!"));
        Video1.AddComment (new Comment("Hank_Hill", "Beautiful places."));

        Video2.AddComment (new Comment("IvySnivy", "Inspiring conspiracy vlog!"));
        Video2.AddComment (new Comment("ThereInTheWall"," the Goveronment is always listnening"));
        Video2.AddComment (new Comment("TheHills","I see"));

        Video3.AddComment (new Comment("papa_nurgle", " lies all from The imperium of man"));
        Video3.AddComment (new Comment("Khonre_The_Destoryer01", " what do you mean? who doesnt want to spill blood for the blood god?"));
        Video3.AddComment (new Comment("Vulkan_The_kind","I find this video qutie insperational"));
 
        Video4.AddComment (new Comment("Alice_In_ wonder", "Great ideas!"));
        Video4.AddComment (new Comment("I_Love_fire", "Love this!"));
        Video4.AddComment (new Comment("CatLover123", "ahh yes the kittens will love to add this to their world domination plans"));

        List <Video> videos = new List<Video> {Video1, Video2, Video3, Video4 } ;

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}