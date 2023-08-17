using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FastLineSeriesSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (DataSeries != null)
            {
                DataSeries.StrokeDashArray = new double[] { 5, 10 };
            }
        }
    }
}

