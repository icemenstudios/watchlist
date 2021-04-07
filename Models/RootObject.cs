using System;
using System.Collections.Generic;
namespace WatchList.Models
{
    public class RootObject
    {
        public List<Entertainment> Search { get; set; }
        public string Response { get; set; }
        public string Error { get; set; }
    }
}