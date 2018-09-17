using Sniffer.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NetworkSniffer.Model
{
    internal class Transmission
    {
        public int ID;
        public String AddressInitial;
        public String PortInitial;
        public String AddressFinal;
        public String PortFinal;
        public bool IsCript;
        public List<MyPacket> Packets = new List<MyPacket>();

        public String clNroTransmissao
        {
            get { return ID.ToString(); }
        }

        public String clIP1
        {
            get { return AddressInitial; }
        }

        public String clPorta1
        {
            get { return PortInitial; }
        }

        public String clIP2
        {
            get { return AddressFinal; }
        }

        public String clPorta2
        {
            get { return PortFinal; }
        }

        public int clQtdPacotes
        {
            get { return Packets.Count(); }
        }


        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var t = (Transmission) obj;

            if ((t.AddressInitial == AddressInitial && t.PortInitial == PortInitial && t.AddressFinal == AddressFinal && t.PortFinal == PortFinal) ||
                 (t.AddressInitial == AddressFinal && t.PortInitial == PortFinal && t.AddressFinal == AddressInitial && t.PortFinal == PortInitial))
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = -1563341452;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AddressInitial);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PortInitial);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AddressFinal);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PortFinal);
            hashCode = hashCode * -1521134295 + IsCript.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<MyPacket>>.Default.GetHashCode(Packets);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clNroTransmissao);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clIP1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clPorta1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clIP2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clPorta2);
            hashCode = hashCode * -1521134295 + clQtdPacotes.GetHashCode();
            return hashCode;
        }
    }
}