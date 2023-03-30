namespace Foundation1.Classes
{
    public class Populate
    {
        public Populate()
        {

        }
        public Video PopulateVideo1()
        {
            Video video1 = new Video("Conditions of A Punk (Audio)", "half alive", 220);
            Comment comment1 = new Comment("Bee Arts!", "I swear. You guys make bops. I want to see you guys in concert so bad!");
            Comment comment2 = new Comment("sunny", "THE VIDBES FROM THIS SONG ARE SO NICE AAAAAAA");
            Comment comment3 = new Comment("PDocDanny", "This song makes me WANT to listen to music.");

            video1.AddComment(comment1);
            video1.AddComment(comment2);
            video1.AddComment(comment3);

            return video1;
        }

        public Video PopulateVideo2()
        {
            Video video2 = new Video("Secret Project 2 Out This Weekend! + Weekly Update", "Brandon Sanderson", 376);
            Comment comment1 = new Comment("That Cosmere Chick", "WE GET JANCI'S WRITING UPDATES?!?!?!? Can we get Dan's too????");
            Comment comment2 = new Comment("Sam Aldag", "Dang felt like just yesterday that I was reading Tress! So excited for secret project #2 and thank you for all your transparency");
            Comment comment3 = new Comment("Douglas Ham Cortes", "Can't wait for Secret Project #2, thanksnfor always being transparent with us :)");

            video2.AddComment(comment1);
            video2.AddComment(comment2);
            video2.AddComment(comment3);

            return video2;
        }

        public Video PopulateVideo3()
        {
            Video video3 = new Video("This is the coolest Sheik combo ever performed", "turndownforwalt", 615);
            Comment comment1 = new Comment("Victor Padres", "We know it's THAT combo before even watching");
            Comment comment2 = new Comment("ricardo ludwig", "I instantly believed jmook would win the tournament the second this happened, what an insane combo");
            Comment comment3 = new Comment("BKM", "How does jmook even comput these inputs in his head, I couldn't TAS as sick of a combo");
            Comment comment4 = new Comment("Kevin", "knew seeing it live this was getting a classic Walt breakdown");

            video3.AddComment(comment1);
            video3.AddComment(comment2);
            video3.AddComment(comment3);
            video3.AddComment(comment4);

            return video3;
        }
    }

}