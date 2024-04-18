using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class IGPost
    {
        public IGPost() { }
        public int id { get; set; }
        public string author { get; set; }
        public string image { get; set; }
        public int likes { get; set; }
        public string caption { get; set; }
        public DateTime timestamp { get; set; }

        public override string ToString()
        {
            return $"\nID: {id}\nAuthor: {author}\nCaption: {caption}\nImage: {image}\nLikes: {likes}\nTimestamp: {timestamp}";
        }
    }
}
