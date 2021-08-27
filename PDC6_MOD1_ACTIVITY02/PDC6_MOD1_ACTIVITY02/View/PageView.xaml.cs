using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDC6_MOD1_ACTIVITY02.ViewModels;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC6_MOD1_ACTIVITY02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageView : ContentPage
    {
        public PageView()
        {
            InitializeComponent();
            BindingContext = new SubjectViewModel();
        }
    }
}