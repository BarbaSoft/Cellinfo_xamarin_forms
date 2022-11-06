using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CellInfoXamarinForms;

namespace Cellinfo_xamarin_forms
{
    public partial class MainPage : ContentPage
    {
        Cellinfo cellinfo; 
        public MainPage()
        {
            InitializeComponent();
            cellinfo = new Cellinfo();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void button_get_infos_Clicked(object sender, EventArgs e)
        {
            var info=cellinfo.GetCellInfo();
            foreach (Infos i in info)
            {
                string identity = i.CellIdentity;
            }
        }
    }
}
