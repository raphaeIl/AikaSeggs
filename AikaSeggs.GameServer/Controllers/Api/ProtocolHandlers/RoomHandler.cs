using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class RoomHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public RoomHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Room_GetMasterData)]
        public HttpMessage RoomGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Room_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Room_GetUserData)]
        public HttpMessage RoomGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Room_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Room_CollectAll)]
        public HttpMessage RoomCollectAll()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Room_CollectAll);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}

