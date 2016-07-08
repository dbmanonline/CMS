using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.Web.Areas.Admin.Models.Categories
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public bool Active { get; set; }
    }
}