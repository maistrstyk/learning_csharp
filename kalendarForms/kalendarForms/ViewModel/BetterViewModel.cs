using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using kalendarForms.Model;
using kalendarForms.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace kalendarForms.ViewModel
{
    public partial class BetterViewModel : ObservableObject
    {
        public ObservableCollection<DataModel> Datas { get; } = new ObservableCollection<DataModel>();

        Mservice mservice;
        public BetterViewModel(Mservice mservice)
        {
            
            this.mservice = mservice;
            
        }

        [RelayCommand]
        async Task GetMonkeysAsync()
        {
            try
            {
                var monkeys = await mservice.GetMonkeys();

                if (Datas.Count != 0)
                {
                    Datas.Clear();
                }

                foreach (var monkey in monkeys)
                {
                    Datas.Add(monkey);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!",
                    $"Unable to get monkeys: {ex.Message}", "OK");
            }
            finally
            {

            }
        }
    }
}
