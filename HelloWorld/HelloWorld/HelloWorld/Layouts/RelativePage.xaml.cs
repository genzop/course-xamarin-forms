using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RelativePage : ContentPage
	{
		public RelativePage ()
		{
			InitializeComponent ();

            #region Ejemplo RelativeLayout en código
            /*
            var layout = new RelativeLayout();
            Content = layout;

            var aquaBox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(aquaBox,
                widthConstraint: Constraint.RelativeToParent(parent => parent.Width),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height));

            var silverBox = new BoxView { Color = Color.Silver };
            layout.Children.Add(silverBox,
                yConstraint: Constraint.RelativeToView(aquaBox, (RelativeLayout, element) => element.Height + 20));
            */
            #endregion
        }
	}
}