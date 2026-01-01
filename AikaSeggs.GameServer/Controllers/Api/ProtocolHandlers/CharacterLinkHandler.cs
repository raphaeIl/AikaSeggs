using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class CharacterLinkHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public CharacterLinkHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.CharacterLink_GetMasterData)]
        public HttpMessage CharacterLinkGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.CharacterLink_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.CharacterLink_GetUserData)]
        public HttpMessage CharacterLinkGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.CharacterLink_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}

