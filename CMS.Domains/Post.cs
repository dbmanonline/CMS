using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domains
{
    public class Post
    {
        public Int64 ID { get; set; }
        public string PostTitle { get; set; }
        public string Slug { get; set; }
        public int PostAuthor { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime PostModified { get; set; }
        public int PostStatus { get; set; }
        public string PostDescription { get; set; }
        public string PostContent { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }

    }
}
