using System;
using System.Collections.Generic;

namespace FluentAPI.DomianModels
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}