using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Packets;
using AikaSeggs.Common.Services;
using AikaSeggs.PcapParser;
using AikaSeggs.Database;
using AikaSeggs.Database.Models;
using System;
using System.Linq;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class PictureBookHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;
        private readonly AikaSeggsContext context;

        public PictureBookHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService, AikaSeggsContext context) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
            this.context = context;
            this.AddAllPictureBook();
        }

        private void AddAllPictureBook()
        {
            // Check if picture book details already exist
            if (context.PictureBooks.Any())
            {
                return; // Picture book details already added
            }

            // Get the first account's UserCd, or create a default account if none exists
            var account = context.Accounts.FirstOrDefault();
            if (account == null)
            {
                // Create a default account
                account = new AccountDB
                {
                    UserId = Guid.NewGuid().ToString("N"),
                    UserCd = Guid.NewGuid().ToString("N"),
                    UserName = "DefaultUser",
                    Level = 1,
                    Exp = 0,
                    FreeGem = 0,
                    PaidGem = 0,
                    RegisterDate = DateTime.Now.ToString("yyyyMMddHHmmss")
                };
                context.Accounts.Add(account);
                context.SaveChanges();
            }

            int[] addCharacterIds = {
                //102901,
                //102903,
                //102904,
                102905,
                102906,
                102907,
                102908,
                102909,
                102910,
                102911,
                102912,
                102913,
                102914,
                102915,
                102916,
                102917,
                102918,
                102919,
                102920,
                102921,
                102922,
             };

            foreach (Common.Database.ExCharacterMainModel characterMain in tableService.GetTable<MasterCharacterMainData>().CharacterMain)
            {
                //if (!addCharacterIds.Contains(characterMain.CharacterId))
                //{
                //    continue;
                //}

                context.PictureBooks.Add(new PictureBookDB
                {
                    UserCd = account.UserCd,
                    CharacterId = characterMain.CharacterId,
                    CharacterGroupId = characterMain.CharacterGroupId,
                    Friendship = 0,
                    ExceedLimit = 0
                });
            }

            context.SaveChanges();
        }

        [ProtocolHandler(Protocol.PictureBook_GetUserData)]
        public HttpMessage PictureBookGetUserData()
        {
            PictureBookGetUserDataResponse resp = new PictureBookGetUserDataResponse
            {
                PictureBookBase = [],
                PictureBookDetail = []
            };

            // Add all picture book details from database
            foreach (PictureBookDB pictureBook in context.PictureBooks)
            {
                resp.PictureBookDetail.Add(new Common.Database.PictureBookDetailModel
                {
                    CharacterId = pictureBook.CharacterId,
                    Friendship = pictureBook.Friendship,
                    ExceedLimit = pictureBook.ExceedLimit
                });

                if (!resp.PictureBookBase.Any(e => e.CharacterGroupId == pictureBook.CharacterGroupId))
                {
                    resp.PictureBookBase.Add(new Common.Database.PictureBookBaseModel()
                    {
                        CharacterGroupId = pictureBook.CharacterGroupId,
                        RoomSelectCharacterId = 0
                    });
                }
            }

            return HttpMessage.Create(resp, doMsgPack: true);

            //var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.PictureBook_GetUserData);
            //HttpMessage resp2 = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            //return resp2;
        }

        [ProtocolHandler(Protocol.PictureBook_Gift)]
        public HttpMessage PictureBookGift()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.PictureBook_Gift);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }
    }
}

