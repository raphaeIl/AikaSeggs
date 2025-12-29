using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class ItemHandler : ProtocolHandlerBase
    {
        public ItemHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Item_GetMasterData)]
        public HttpMessage ItemGetMasterData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Item_GetMasterData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), doMsgPack: true);
            return resp;
        }

        [ProtocolHandler(Protocol.Item_GetMasterItemSetData)]
        public HttpMessage ItemGetMasterItemSetData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Item_GetMasterItemSetData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Item_GetMasterItemSetData2)]
        public HttpMessage ItemGetMasterItemSetData2()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Item_GetMasterItemSetData2);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Item_GetUserData)]
        public HttpMessage ItemGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Item_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }

        [ProtocolHandler(Protocol.Item_Use)]
        public HttpMessage ItemUse()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Item_Use);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString());
            return resp;
        }
    }
}

