using Sniffer.Model;
using System.Collections.Generic;

namespace NetworkSniffer.Model
{
    internal class Demonstration
    {
        public List<MyPacket> AllPackets;
        public List<Transmission> AllTransmissions;
        public List<Transmission> AllOpenedTransmissions;

        public int NumberTransmissions;
        public int NumberCriptTransmissions;
        public int NumberOpenedTransmissions;


        public Demonstration()
        {
            AllPackets = new List<MyPacket>();
            AllTransmissions = new List<Transmission>();
            AllOpenedTransmissions = new List<Transmission>();
            NumberTransmissions = 0;
            NumberCriptTransmissions = 0;
            NumberOpenedTransmissions = 0;
        }

        public void LimpaListas()
        {
            AllPackets.Clear();
            AllTransmissions.Clear();
            AllOpenedTransmissions.Clear();

            NumberTransmissions = 0;
            NumberCriptTransmissions = 0;
            NumberOpenedTransmissions = 0;
        }
    }
}
