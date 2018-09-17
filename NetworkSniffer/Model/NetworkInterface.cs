using SharpPcap;
using System;

namespace NetworkSniffer.Model
{
    class NetworkInterface
    {
        public String _interfaceName;
        public ICaptureDevice Device;

        public NetworkInterface(String name, ICaptureDevice device)
        {
            _interfaceName = name;
            Device = device;
        }

        public override string ToString()
        {
            return _interfaceName;
        }
    }
}
