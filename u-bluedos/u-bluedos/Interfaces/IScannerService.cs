using System;
using System.Collections.Generic;
using System.Text;
using u_bluedos.Models;

namespace u_bluedos.Interfaces
{
    public interface IScannerService
    {
        IEnumerable<Device> ScanDevices();
    }
}
