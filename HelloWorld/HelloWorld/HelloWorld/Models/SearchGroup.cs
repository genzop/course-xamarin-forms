using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HelloWorld.Models
{
    public class SearchGroup : ObservableCollection<Search>
    {
        public string Title { get; set; }

        public SearchGroup(string title)
        {
            Title = title;
        }
    }
}
