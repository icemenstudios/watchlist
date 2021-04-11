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
        public string Runtime { get; set; }
        public string Plot { get; set; }
        public Rating [] Ratings { get; set; }
        private string _rate;
        private string GetRatings()
        {

            if (Ratings != null)
            {
                for (int i = 0; i < Ratings.Length; i++)
                {
                    _rate = Ratings[0].Value;
                }
            }
           

            return _rate;
        }

        public string Rate
        {
            get { return GetRatings(); }
            
        }
        

        public static implicit operator Entertainment(List<Entertainment> v)
        {
            throw new NotImplementedException();
        }

        



    }

    public class Rating
    {
        public string Source { get; set; }
        public string Value { get; set; }
    }
}
