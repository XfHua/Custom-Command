using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App279
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new ViewModel();
        }     
    }

    public class ViewModel {

        public ICommand nextCommand { get;set; }

        public ViewModel() { 
            
            nextCommand = new Command(() => TestMethod());
        }

        private void TestMethod()
        {
            Console.WriteLine("TestMethod");
        }
    }
}
