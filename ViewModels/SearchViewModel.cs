using System;
namespace IndyBooks.ViewModels
{
    public class SearchViewModel
    {
        public String Title { get; set; }

        //TODO: Add properties needed for searching
        public string Author { get; set; }
        public string Edition { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public string Year { get; set; }
    }
}
