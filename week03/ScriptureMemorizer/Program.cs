using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Genesis", 1, 1), "In the beginning God created the heaven and the earth."),
            new Scripture(new Reference("Exodus", 20, 3), "Thou shalt have no other gods before me."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want."),
            new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
            new Scripture(new Reference("Isaiah", 41, 10), "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."),
            new Scripture(new Reference("Matthew", 5, 14), "Ye are the light of the world. A city that is set on a hill cannot be hid."),
            new Scripture(new Reference("Matthew", 11, 28), "Come unto me, all ye that labour and are heavy laden, and I will give you rest."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("John", 14, 6), "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me."),
            new Scripture(new Reference("Acts", 3, 19), "Repent ye therefore, and be converted, that your sins may be blotted out, when the times of refreshing shall come from the presence of the Lord."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."),
            new Scripture(new Reference("2 Corinthians", 5, 7), "For we walk by faith, not by sight."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("1 Peter", 5, 7), "Casting all your care upon him; for he careth for you."),
            new Scripture(new Reference("Revelation", 3, 20), "Behold, I stand at the door, and knock: if any man hear my voice, and open the door, I will come in to him, and will sup with him, and he with me."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("2 Nephi", 2, 27), "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man."),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Mosiah", 24, 14), "And I will ease the burdens which are put upon your shoulders, that even you cannot feel them upon your backs."),
            new Scripture(new Reference("Alma", 37, 6), "By small and simple things are great things brought to pass."),
            new Scripture(new Reference("Alma", 41, 10), "Wickedness never was happiness."),
            new Scripture(new Reference("Helaman", 5, 12), "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation."),
            new Scripture(new Reference("3 Nephi", 27, 20), "Now this is the commandment: Repent, all ye ends of the earth, and come unto me and be baptized in my name."),
            new Scripture(new Reference("Mormon", 9, 28), "Behold, I will show unto the world that I will show miracles unto the children of men."),
            new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness."),
            new Scripture(new Reference("Moroni", 7, 47), "But charity is the pure love of Christ, and it endureth forever."),
            new Scripture(new Reference("D&C", 1, 37), "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled."),
            new Scripture(new Reference("D&C", 58, 42), "I, the Lord, forgive sins unto those who confess their sins before me and ask forgiveness."),
            new Scripture(new Reference("D&C", 19, 16), "For behold, I, God, have suffered these things for all, that they might not suffer if they would repent."),
            new Scripture(new Reference("D&C", 76, 22), "And they saw the heavens opened, and they were filled with the glory of God."),
            new Scripture(new Reference("D&C", 88, 63), "Draw near unto me and I will draw near unto you."),
            new Scripture(new Reference("D&C", 133, 52), "And they shall see eye to eye when the Lord shall bring again Zion."),
            new Scripture(new Reference("D&C", 130, 18), "Whatever principle of intelligence we attain unto in this life, it will rise with us in the resurrection."),
            new Scripture(new Reference("D&C", 121, 45), "Let thy bowels be full of charity towards all men, and to the household of faith."),
            new Scripture(new Reference("D&C", 64, 33), "Wherefore, be not weary in well-doing, for ye are laying the foundation of a great work."),
            new Scripture(new Reference("D&C", 82, 10), "I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise."),
            new Scripture(new Reference("D&C", 84, 88), "And whosoever receiveth you, there I will be also, for I will go before your face."),
            new Scripture(new Reference("D&C", 121, 9), "Therefore, let your hearts be comforted concerning Zion; for all flesh is in mine hands; be still and know that I am God.")
        };

        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);

        Console.Clear();

        Scripture scripture = scriptures[randomIndex];
        Reference reference = scripture.Reference;

        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter when ready...");
            Console.ReadLine();
            scripture.HideRandomWords();
        }

        Console.WriteLine("\nCongrats on Memorizing a scripture!");



        //loop 
        // display, hide, check if need to quit
        // Use the functions in the scripture class.


    }
}
