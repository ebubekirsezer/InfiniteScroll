using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InfiniteScroll
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyView : ContentPage
	{
		public MyView ()
		{
			InitializeComponent ();
		}
	}
}