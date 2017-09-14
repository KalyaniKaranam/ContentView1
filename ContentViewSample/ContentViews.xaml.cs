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
    public partial class ContentViews : ContentView
    {
        public ContentViews()
        {
            InitializeComponent();
        }
       
        public String UserName { get { return lblUserName.Text; } set { lblUserName.Text = value; } }
        public String Password { get { return lblPwd.Text; } set { lblPwd.Text = value; } }
        public String TxtUserName { get { return txtUserName.Text; } set { txtPwd.Text=value; } }
        public String TxtPassword { get {return txtPwd.Text; } set {txtPwd.Text=value; } }

    }
}
