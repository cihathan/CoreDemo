using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Comment
    {
        public int commentId { get; set; }
        public string commentUserName { get; set; }
        public string commentTitle { get; set; }
        public string commentContent { get; set; }
        public DateTime commentDate { get; set; }
        public bool commentStatus { get; set; }
    }
}
