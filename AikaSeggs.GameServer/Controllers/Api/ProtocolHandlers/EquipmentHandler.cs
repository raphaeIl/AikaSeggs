using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class EquipmentHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public EquipmentHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Equipment_GetMasterData)]
        public HttpMessage EquipmentGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Equipment_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Equipment_GetMasterEquipmentEffectData)]
        public HttpMessage EquipmentGetMasterEquipmentEffectData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Equipment_GetMasterEquipmentEffectData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Equipment_GetMasterEquipmentEffectData2)]
        public HttpMessage EquipmentGetMasterEquipmentEffectData2()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Equipment_GetMasterEquipmentEffectData2);
            return HttpMessage.Create(tableJson, doMsgPack: true);
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

