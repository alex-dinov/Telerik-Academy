using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Comment
    {
        private string content;

        public Comment(string content)
        {
            this.content = content;
        }

        public string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }
    }
}
