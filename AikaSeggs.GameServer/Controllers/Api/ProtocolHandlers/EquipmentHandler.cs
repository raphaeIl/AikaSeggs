using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class EquipmentHandler : ProtocolHandlerBase
    {
        public EquipmentHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Equipment_GetMasterData)]
        public HttpMessage EquipmentGetMasterData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Equipment_GetMasterData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Equipment_GetMasterEquipmentEffectData)]
        public HttpMessage EquipmentGetMasterEquipmentEffectData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Equipment_GetMasterEquipmentEffectData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Equipment_GetMasterEquipmentEffectData2)]
        public HttpMessage EquipmentGetMasterEquipmentEffectData2()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Equipment_GetMasterEquipmentEffectData2);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Equipment_GetUserData)]
        public HttpMessage EquipmentGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Equipment_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}

