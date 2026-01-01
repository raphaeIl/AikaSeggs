using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class PaymentHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;

        public PaymentHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
        }

        [ProtocolHandler(Protocol.Payment_GetMasterData)]
        public HttpMessage PaymentGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Payment_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }
    }
}


