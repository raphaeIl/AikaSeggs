using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Packets;
using AikaSeggs.Common.Services;
using AikaSeggs.Database;
using AikaSeggs.Database.Models;
using AikaSeggs.PcapParser;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class UserHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;
        private readonly AikaSeggsContext context;

        public UserHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService, AikaSeggsContext context) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
            this.context = context;

            this.AddAllStories();
        }

        [ProtocolHandler(Protocol.User_Login)]
        public UserLoginResponse UserLogin()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.User_Login);

            UserLoginResponse resp = JsonConvert.DeserializeObject<UserLoginResponse>(pcap.Packet.ToString()) ?? new UserLoginResponse();

            resp.Stories = new List<Common.Database.StoryModel>();

            // Add all stories from database
            foreach (StoryDB story in context.Stories)
            {
                resp.Stories.Add(new Common.Database.StoryModel
                {
                    StoryId = story.StoryId,
                    IsRead = story.IsRead
                });
            }

            return resp;
        }

        private void AddAllStories()
        {
            // Check if stories already exist
            if (context.Stories.Any())
            {
                return; // Stories already added
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

            MasterStoryData storyTable = tableService.GetTable<MasterStoryData>();

            // Track which StoryIds we've already added to avoid duplicates
            HashSet<int> addedStoryIds = new HashSet<int>();

            // Helper function to add a story if it hasn't been added yet
            Action<dynamic> addStoryIfNotExists = (story) =>
            {
                if (!addedStoryIds.Contains(story.StoryId))
                {
                    context.Stories.Add(new StoryDB
                    {
                        StoryId = story.StoryId,
                        IsRead = 1,
                        UserCd = account.UserCd
                    });
                    addedStoryIds.Add(story.StoryId);
                }
            };

            // Add all stories from all lists
            storyTable.FreeStory?.ForEach(addStoryIfNotExists);
            storyTable.StoryCabin?.ForEach(addStoryIfNotExists);
            storyTable.StoryEvent?.ForEach(addStoryIfNotExists);
            storyTable.StoryGacha?.ForEach(addStoryIfNotExists);
            storyTable.StoryMemorial?.ForEach(addStoryIfNotExists);
            storyTable.StoryMemorialEventOther?.ForEach(addStoryIfNotExists);
            storyTable.StoryOther?.ForEach(addStoryIfNotExists);
            storyTable.StoryPictureBook?.ForEach(addStoryIfNotExists);
            storyTable.StoryQuest?.ForEach(addStoryIfNotExists);
            storyTable.StoryRoom?.ForEach(addStoryIfNotExists);
            storyTable.StoryTutorial?.ForEach(addStoryIfNotExists);
            storyTable.StoryVoice?.ForEach(addStoryIfNotExists);

            context.SaveChanges();
        }

        [ProtocolHandler(Protocol.User_GetMasterData)]
        public HttpMessage UserGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.User_GetMasterData);
            return HttpMessage.Create(tableJson!, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.User_GetMasterMyPageNewsData)]
        public HttpMessage UserGetMasterMyPageNewsData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.User_GetMasterMyPageNewsData);
            return HttpMessage.Create(tableJson!, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.User_GetMasterMyPageNewsData2)]
        public HttpMessage UserGetMasterMyPageNewsData2()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.User_GetMasterMyPageNewsData2);
            return HttpMessage.Create(tableJson!, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.User_GetUserData)]
        public HttpMessage UserGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.User_GetUserData);
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

