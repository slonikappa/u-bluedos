using Android.Bluetooth;
using Java.Util.Concurrent;
using System;
using System.Collections.Generic;
using System.Text;
using u_bluedos.Interfaces;
using u_bluedos.Models;

namespace u_bluedos.Services
{
    class ScannerService : IScannerService
    {
        public ICollection<Device> ScanDevices()
        {
            BluetoothAdapter adapter = BluetoothAdapter.DefaultAdapter;
            ICollection<Device> appDevices = new List<Device>();
            // проверяем, что у нас получен адаптер (есть Bluetooth) и он включен
            if (adapter != null && adapter.IsEnabled)
            {
                // получим список связанных устройств
                ICollection<BluetoothDevice> btDevices = adapter.BondedDevices;

                // пройдем по списку устройств и будем заполнять список имен
                foreach (var device in btDevices)
                {
                    appDevices.Add(new Device
                    {
                        Name = device.Name,
                        MAC = device.Address
                    });
                }
            }


            return appDevices;
        }
    }
}
