using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld.Models
{
    public class SearchService
    {
        private List<Search> _searches;

        public SearchService()
        {
            _searches = new List<Search>
            {
                new Search { Id = 1, Location = "West Hollywood, CA, United States", CheckIn = new DateTime(2016, 9, 1), CheckOut = new DateTime(2016, 11, 1)},
                new Search { Id = 2, Location = "Guaymallen, MZA, Argentina", CheckIn = new DateTime(2017, 12, 25), CheckOut = new DateTime(2017, 12, 31)},
            };
        }

        public IEnumerable<Search> GetSearches(string filter = null)
        {
            if (String.IsNullOrWhiteSpace(filter))
                return _searches;

            return _searches.Where(C => C.Location.Contains(filter));
        }

        public void DeleteSearch(int searchId)
        {
            var search = _searches.Where(C => C.Id == searchId).FirstOrDefault();
            _searches.Remove(search);
        }
    }
}