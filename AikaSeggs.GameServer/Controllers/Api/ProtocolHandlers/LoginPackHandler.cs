using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class LoginPackHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public LoginPackHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.LoginPack_GetMasterData)]
        public HttpMessage LoginPackGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.LoginPack_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.LoginPack_GetLoginPack)]
        public HttpMessage LoginPackGetLoginPack()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.LoginPack_GetLoginPack);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.LoginPack_GetUserData)]
        public HttpMessage LoginPackGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.LoginPack_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}

