namespace Foundation1.Classes
{
    public class Comment
    {
        private string _commenter;
        private string _comment;

        public Comment(string commenter, string comment)
        {
            _commenter = commenter;
            _comment = comment;
        }
        public void DisplayCommentInfo()
        {
            Console.WriteLine("");
            Console.WriteLine($"{_commenter}: {_comment}");
            Console.WriteLine("");
        }
    }
}