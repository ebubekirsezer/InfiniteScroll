using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace InfiniteScroll
{
    public partial class App:Application
    {
        public App()    
        {
            MainPage = new MyView();
        }
    }
}
