using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class RaceHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public RaceHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Race_GetMasterData)]
        public HttpMessage RaceGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Race_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Race_GetUserData)]
        public HttpMessage RaceGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Race_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Race_EndRace)]
        public HttpMessage RaceEndRace()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Race_EndRace);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Race_FortifyCharacter)]
        public HttpMessage RaceFortifyCharacter()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Race_FortifyCharacter);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Race_StartRace)]
        public HttpMessage RaceStartRace()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Race_StartRace);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Race_UpdateSeason)]
        public HttpMessage RaceUpdateSeason()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Race_UpdateSeason);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}

