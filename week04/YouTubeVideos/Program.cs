using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video(900, "Kody Cornett", "Hiking Shed-roof Divide");
        Video video2 = new Video(90, "Rekotdeew", "COD Highlights");
        Video video3 = new Video(120, "Swatty", "Broken but Beating");

        video1.AddComment("Kyle12221", "great Vid 10/10");
        video1.AddComment("Swatty240", "I hated it! Long walk.");
        video1.AddComment("Donnycakes8181", "Your camera was off for half the video!");

        video2.AddComment("Swatty240", "@62 secs was sick!");
        video2.AddComment("Kody C", "@16 Dude that was me!!");
        video2.AddComment("Donnycakes8181", "first!!");

        video3.AddComment("Kody C", "I love you Sis!!");
        video3.AddComment("Kyle12221", "Such a powerful story!");
        video3.AddComment("Donnycakes8181", "first!!");

        Console.Clear();
        video1.DisplayVideo();
        video2.DisplayVideo();
        video3.DisplayVideo();

    }
}