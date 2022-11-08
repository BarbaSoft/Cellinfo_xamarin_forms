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

            string CallState=cellinfo.CallState; //retrive call state
            string TelephoneModel=cellinfo.TelephoneModel; //Telephone Model
            string OperatorName=cellinfo.NetworkOperatorName; //Network Operator
            string SimOperatorName=cellinfo.SimOperatorName; //SIM Operator

            foreach (Infos i in info)
            {
                string identity = i.CellIdentity;
                int Level_dBm = i.SignalLeveldBm;
                string ConnectionStatus = i.CellConnectionStatus;
            }
        }
    }
}
