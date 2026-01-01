using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class CampaignHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public CampaignHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Campaign_GetMasterData)]
        public HttpMessage CampaignGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Campaign_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }
    }
}


