namespace Foundation1.Classes
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _length;
        private List<Comment> _comments = new List<Comment>();

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
        }

        public int ReturnNumOfComments()
        {
            int count = 0;
            foreach (Comment thing in _comments)
            {
                count += 1;
            }

            return count;
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public void DisplayVideoInfo()
        {
            int num = ReturnNumOfComments();
            
            Console.WriteLine();
            Console.WriteLine(_title);
            Console.WriteLine($"A Video Created by {_author}");
            Console.WriteLine($"Length: {_length} seconds");
            Console.WriteLine($"There are {num} comments on this video.");
            foreach (Comment comment in _comments)
            {
                comment.DisplayCommentInfo();
            }
        }
    }
}