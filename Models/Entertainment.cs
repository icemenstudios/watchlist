using System;
using System.Collections.Generic;

namespace WatchList.Models
{
    public class Entertainment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string ImdbID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
        public string Trailer { get; set; }
        public Object Ratings { get; set; }
        public string Runtime { get; set; }
        public string Plot { get; set; }

        public static implicit operator Entertainment(List<Entertainment> v)
        {
            throw new NotImplementedException();
        }

        
    }
}
