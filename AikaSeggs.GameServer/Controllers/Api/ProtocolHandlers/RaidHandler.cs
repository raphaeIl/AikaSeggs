using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class RaidHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public RaidHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Raid_GetMasterData)]
        public HttpMessage RaidGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Raid_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }
    }
}


