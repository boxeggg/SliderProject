using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SliderProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {


            InitializeComponent();
            string[] quotes = ["You can't blame gravity for falling in love", "A rose by any other name would smell as sweet", "All that glitters is not gold"];
            for (int i = 0; i < quotes.Length; i++)
            {
                quotesLabel.Text =  quotesLabel.Text + "\n" + quotes[i];
            }
            
            Slider.ValueChanged += Slider_ValueChanged;


        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            string value = Slider.Value.ToString();
            SliderValueLabel.Text = ($"Font size: {value}");
            SliderValueLabel.FontSize = Slider.Value;
            quotesLabel.FontSize = Slider.Value;
        }

    }
}
