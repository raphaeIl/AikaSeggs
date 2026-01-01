using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class ComebackHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public ComebackHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Comeback_GetMasterData)]
        public HttpMessage ComebackGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Comeback_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }
    }
}


