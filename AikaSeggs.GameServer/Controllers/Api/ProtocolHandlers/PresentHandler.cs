using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class PresentHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public PresentHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Present_GetMasterData)]
        public HttpMessage PresentGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Present_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Present_GetList)]
        public HttpMessage PresentGetList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Present_GetList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Present_Receive)]
        public HttpMessage PresentReceive()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Present_Receive);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}

