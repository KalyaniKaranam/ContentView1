using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContentViewSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChangePwd : ContentPage
	{
        
        public ChangePwd ()
		{
			InitializeComponent ();
            btnchangePwd.Clicked += OnClick;
		}

        public void OnClick(object sender, EventArgs e)
        {
            
        }
    }
}
