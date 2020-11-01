using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using u_bluedos.Interfaces;
using Xamarin.Forms;


namespace u_bluedos
{
    public partial class MainPage : ContentPage
    {
        IEnumerable<Models.Device> Devices;
        readonly IScannerService _scannerService;
        public MainPage(IScannerService scannerService)
        {
            InitializeComponent();
            _scannerService = scannerService;

            //Devices = scannerService.ScanDevices();
            //lvBluetoothDevices.ItemsSource = Devices;
            lvBluetoothDevices.SelectionMode = ListViewSelectionMode.None;
        }

        protected override void OnAppearing()
        {
            Devices = _scannerService.ScanDevices();
            lvBluetoothDevices.ItemsSource = Devices;
        }
    }
}