﻿

namespace CleanArchitectureCQRSPatteren.Domain.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
         public string ImageUrl {  get; set; }
        public string Author { get; set; }
    }
}
