using kalendarForms.Service;
using kalendarForms.ViewModel;
using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kalendarForms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BetterMVVM : ContentPage
	{
		public BetterMVVM ()
        {
            Mservice mservice = new Mservice ();
            BetterViewModel viewModel = new BetterViewModel (mservice);

            InitializeComponent ();
            BindingContext = viewModel;
        }
	}
}