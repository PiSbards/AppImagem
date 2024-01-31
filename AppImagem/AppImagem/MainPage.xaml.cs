using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppImagem
{
    public partial class MainPage : ContentPage
    {
        int click;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnMudar_Clicked(object sender, EventArgs e)
        {
            click = click + 1;
            if(click == 1)
            {
                Button bt = (Button)sender;
                foto.Source = "imagem2";
            }
            if (click == 2)
            {
                Button bt = (Button)sender;
                foto.Source = "imagem3";
            }
            if (click == 3)
            {
                click = 0;
                Button bt = (Button)sender;
                foto.Source = "imagem1";
            }
            
        }

        private void btnImagem2_Clicked(object sender, EventArgs e)
        {            
            click = click - 1;
            if (click == 2)
            {
                Button bt = (Button)sender;
                foto.Source = "imagem2";
            }
            if (click == 1)
            {
                Button bt = (Button)sender;
                foto.Source = "imagem3";
            }
            if(click == 0)
            {
                click = 3;
                Button bt = (Button)sender;
                foto.Source = "imagem1";
            }
        }

        private void btnImagem3_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
