using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmptyStackBug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            int count = Navigation.NavigationStack.Count; //    count has value 0 in this case.
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            int count = Navigation.NavigationStack.Count; //    count has value 2 in this case.
        }
    }
}