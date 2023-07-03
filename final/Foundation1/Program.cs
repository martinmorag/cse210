using System;

class Program
{
    static void Main(string[] args)
    {
        Video first_video = new Video();
        first_video.Insert("Minecraft highligths", "Megaplayer2000", 450, 4);
        Comment first_comment = new Comment();
        first_comment.InsertPartTwo("Vegetta777", "this looks amazing!");
        first_comment.InsertPartTwo("WarriorMommma", "you got some good skills.");
        first_comment.InsertPartTwo("thebuilder", "you have to make a tutorial showing how to make that house of yours.");
        first_comment.InsertPartTwo("noobguy", "I wish I could play like you some day");

        Video second_video = new Video();
        second_video.Insert("House Tour", "Selena", 2400, 3);
        Comment second_comment = new Comment();
        second_comment.InsertPartTwo("MaryyAnn", "This is my dream house.");
        second_comment.InsertPartTwo("Joselyne", "Where did you buy the last painting of your video? it is lovely.");
        second_comment.InsertPartTwo("Shaniqua", "This is just like my parents house.");

        Video third_video = new Video();
        third_video.Insert("The Flash Review", "ComicGenie", 3760, 5);
        Comment third_comment =  new Comment();
        third_comment.InsertPartTwo("Gastonnn", "They just didn't want to spend a lot of money on the CGI I guess");
        third_comment.InsertPartTwo("DamianDrake", "I just spoiled myself.");
        third_comment.InsertPartTwo("FlashFandom", "I just loved the movie, got tears at the end.");
        third_comment.InsertPartTwo("MarvelRocks", "Gotta hand it to you, DC is coming back in the game.");
        third_comment.InsertPartTwo("Marianito", "It was one of the few DC movies that I really enjoyed.");

        Video fourth_video = new Video();
        fourth_video.Insert("How to make a fix a watch", "How to Fix it!", 2600, 3);
        Comment fourth_comment = new Comment();
        fourth_comment.InsertPartTwo("GoCarl", "This was really difficult but it did work! thanks a lot for the help.");
        fourth_comment.InsertPartTwo("Kelsey!!", "Don't even have a watch but wanted to know how hard it is haha.");
        fourth_comment.InsertPartTwo("ketchupGuy", "I think I'm going to need extra help in my case.");

        
        
        first_video.DisplayIt();
        first_comment.DisplayItPartTwo();
        second_video.DisplayIt();
        second_comment.DisplayItPartTwo();
        third_video.DisplayIt();
        third_comment.DisplayItPartTwo();
        fourth_video.DisplayIt();
        fourth_comment.DisplayItPartTwo();
    }

}
