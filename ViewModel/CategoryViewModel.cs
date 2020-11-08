using System;

namespace FluentAPI.ViewModel
{
    public class CategoryViewModel
    {
        public string CategoryName{get; set;}
        public ICollection<PostViewModel> pview{get; set;}
    }
}