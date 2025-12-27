using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class WarehouseHandler : ProtocolHandlerBase
    {
        public WarehouseHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Warehouse_GetCharacterCount)]
        public HttpMessage WarehouseGetCharacterCount()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetCharacterCount);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetCharacterList)]
        public HttpMessage WarehouseGetCharacterList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetCharacterList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetEquipmentCount)]
        public HttpMessage WarehouseGetEquipmentCount()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetEquipmentCount);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetEquipmentList)]
        public HttpMessage WarehouseGetEquipmentList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetEquipmentList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetMaterialCount)]
        public HttpMessage WarehouseGetMaterialCount()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetMaterialCount);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Warehouse_GetMaterialList)]
        public HttpMessage WarehouseGetMaterialList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Warehouse_GetMaterialList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}

