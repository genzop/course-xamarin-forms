using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
        private int position;
        private string[] quotes;

		public QuotesPage ()
		{
			InitializeComponent ();

            quotes = new string[]
            {
                "Don't cry because it's over, smile because it happened.",
                "Be yourself; everyone else is already taken.",
                "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.",
                "So many books, so little time.",
                "A room without books is like a body without a soul."
            };

            position = 0;
            quote.Text = quotes[position];
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            position = position < 4 ? position + 1 : 0;
            quote.Text = quotes[position];
        }
	}
}