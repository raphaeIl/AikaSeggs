using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class UserHandler : ProtocolHandlerBase
    {
        public UserHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.User_GetMasterData)]
        public HttpMessage UserGetMasterData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.User_GetMasterData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.User_GetMasterMyPageNewsData)]
        public HttpMessage UserGetMasterMyPageNewsData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.User_GetMasterMyPageNewsData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.User_GetMasterMyPageNewsData2)]
        public HttpMessage UserGetMasterMyPageNewsData2()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.User_GetMasterMyPageNewsData2);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.User_GetUserData)]
        public HttpMessage UserGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.User_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.User_Login)]
        public HttpMessage UserLogin()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.User_Login);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.User_UpdateUserPrefs)]
        public HttpMessage UpdateUserPrefs()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.User_UpdateUserPrefs);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}

