using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Packets;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;
using Newtonsoft.Json;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class BoostHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public BoostHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Boost_GetMasterData)]
        public HttpMessage BoostGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Boost_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Boost_GetBoostUnitsList)]
        public HttpMessage BoostGetBoostUnitsList()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Boost_GetBoostUnitsList);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}

