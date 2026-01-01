using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class TutorialHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public TutorialHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Tutorial_GetMasterData)]
        public HttpMessage TutorialGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Tutorial_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }
    }
}


