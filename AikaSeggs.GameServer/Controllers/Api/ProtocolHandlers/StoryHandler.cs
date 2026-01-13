using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Packets;
using AikaSeggs.Common.Services;
using AikaSeggs.Database;
using AikaSeggs.Database.Models;
using AikaSeggs.PcapParser;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class StoryHandler : ProtocolHandlerBase
    {
        private readonly TableService tableService;
        private readonly AikaSeggsContext context;

        public StoryHandler(IProtocolHandlerFactory protocolHandlerFactory, TableService tableService, AikaSeggsContext context) 
            : base(protocolHandlerFactory)
        {
            this.tableService = tableService;
            this.context = context;
        }

        [ProtocolHandler(Protocol.Story_GetMasterData)]
        public HttpMessage StoryGetMasterData()
        {
            var tableJson = tableService.GetTableJsonByProtocol(Protocol.Story_GetMasterData);
            return HttpMessage.Create(tableJson, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Story_GetUserData)]
        public HttpMessage StoryGetUserData()
        {
            StoryGetUserDataResponse resp = new StoryGetUserDataResponse
            {
                Stories = new List<Common.Database.StoryModel>()
            };

            // Add all stories from database
            foreach (StoryDB story in context.Stories)
            {
                resp.Stories.Add(new Common.Database.StoryModel
                {
                    StoryId = story.StoryId,
                    IsRead = story.IsRead
                });
            }

            return HttpMessage.Create(resp, doMsgPack: true);
        }

        [ProtocolHandler(Protocol.Story_GetResource)]
        public HttpMessage StoryGetResource()
        {
            

            HttpMessage resp = HttpMessage.Create(@"{
    ""storyIds"": [
        100103
    ],
    ""adult"": 1,
    ""resource"": [
        {
            ""fileName"": ""download/adv/text/character/1001/adultr/100103.txt"",
            ""path"": ""61/52/ac/09"",
            ""md5"": ""0b28d5f523614f88989ca79def871b2d""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_01.mp3"",
            ""path"": ""7a/8d"",
            ""md5"": ""72fd7a2db7f273a6965aec9cb81d93fc""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_02.mp3"",
            ""path"": ""96/bc/88"",
            ""md5"": ""a51108d5af6685811f5224a53d9154a9""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_03.mp3"",
            ""path"": ""70/45"",
            ""md5"": ""ed931e9a12f305798fdf2985f23903ff""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_04.mp3"",
            ""path"": ""a7/08/be/1b"",
            ""md5"": ""c70ab6f31bc5da6df0696650c530c586""
        },
        {
            ""fileName"": ""download/character/100100/adv/image/101.jpg"",
            ""path"": ""2c/ff"",
            ""md5"": ""eab157affb1412ea7f91475f51bbf386""
        },
        {
            ""fileName"": ""download/character/100221/adv/anm/100221_01.mp4"",
            ""path"": ""46/78/b1/b4"",
            ""md5"": ""dd9acdabf7151ba50e5738ffe289b3e3""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_05.mp3"",
            ""path"": ""cb/08/a0/ea"",
            ""md5"": ""ebc4a7df4ce5f1e32691f31cf1eed1e9""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_06.mp3"",
            ""path"": ""e9/fc"",
            ""md5"": ""c4ead504083e61a149c98791f7651556""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_07.mp3"",
            ""path"": ""b6/bc/dc/ec"",
            ""md5"": ""2985c0cf9fb6d73391fd1e83ea0a6a24""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_08.mp3"",
            ""path"": ""54/91/a7/48"",
            ""md5"": ""3747d171633b5366aff47136d49a3742""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_09.mp3"",
            ""path"": ""ba/7e"",
            ""md5"": ""fca1de14a537bc60d63f87d7a1df5ac9""
        },
        {
            ""fileName"": ""download/character/100100/adv/image/102.jpg"",
            ""path"": ""fa/51/b6/a8"",
            ""md5"": ""508195a38bfe5b8ec04f9831df5c0126""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_10.mp3"",
            ""path"": ""b4/ae"",
            ""md5"": ""5c08dae4d9d626d2b43f463dbe1887f6""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_11.mp3"",
            ""path"": ""0c/7a/b8/f6"",
            ""md5"": ""20e44324fc40216e040bbca49ebcd355""
        },
        {
            ""fileName"": ""download/character/100100/adv/image/103.jpg"",
            ""path"": ""dc/c4/a9/28"",
            ""md5"": ""7a19ed071051f1475334dee7143ee204""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_12.mp3"",
            ""path"": ""44/ca/14"",
            ""md5"": ""ade53b8dd6f158cec28681c451bfa6ed""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_13.mp3"",
            ""path"": ""2a/a0/4b/d6"",
            ""md5"": ""24af90c956e00ac73fcaab4e04234fed""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_14.mp3"",
            ""path"": ""7f/4b/89/e5"",
            ""md5"": ""c335ecd6f587c9146fc5e2b75689a711""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_15.mp3"",
            ""path"": ""4b/5e"",
            ""md5"": ""ed1dad13448d4624eeeb65fb07f04eb5""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_16.mp3"",
            ""path"": ""05/93/8c/c9"",
            ""md5"": ""074aeaad5eea8f5e876a88aef425ff2b""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_17.mp3"",
            ""path"": ""07/82/60/d2"",
            ""md5"": ""486fa950f1bbcb574c239ed98836075e""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_18.mp3"",
            ""path"": ""b6/52/8a/fb"",
            ""md5"": ""d84814919a82353b3a2b8222202e3259""
        },
        {
            ""fileName"": ""download/character/100100/adv/image/104.jpg"",
            ""path"": ""22/48"",
            ""md5"": ""343e617b0e04dd88c62c909d7506c686""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_19.mp3"",
            ""path"": ""1f/27/10"",
            ""md5"": ""c62322b6eeb62a4a8fe7a3dd5509a5d5""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_20.mp3"",
            ""path"": ""cb/c1/36/f2"",
            ""md5"": ""c083945e8d1e751ffcca6d27c688bce7""
        },
        {
            ""fileName"": ""download/character/100100/adv/image/105.jpg"",
            ""path"": ""ef/61/1a"",
            ""md5"": ""bda1b0339aea6eed7da5c4c6112b51e2""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_21.mp3"",
            ""path"": ""21/b5/39"",
            ""md5"": ""cb331b48b4744859e66bad9d02ac55cf""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_22.mp3"",
            ""path"": ""96/86/c9/c4"",
            ""md5"": ""ba1699f2690b56d8ddd6ba9c9b54c449""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_23.mp3"",
            ""path"": ""06/09/38/d2"",
            ""md5"": ""81decc5b52d48cecaf09e04d749caf62""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_24.mp3"",
            ""path"": ""02/aa/a7/9b"",
            ""md5"": ""5bd4efd24eb2f694aad03280cfecffbd""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_25.mp3"",
            ""path"": ""27/a6/b0/3e"",
            ""md5"": ""39f70f3c43ca88858d9d3ef91e56012d""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_26.mp3"",
            ""path"": ""91/75"",
            ""md5"": ""7c53a3e0bc0b5dda5f67b7d61c515d01""
        },
        {
            ""fileName"": ""download/character/100100/adv/image/106.jpg"",
            ""path"": ""e6/57/8b"",
            ""md5"": ""cba874cd1e624fad6e5afb4e7c915e4b""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_27.mp3"",
            ""path"": ""76/9a/ef/cc"",
            ""md5"": ""a17a6b2912d2e55909ce4519caff934d""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_28.mp3"",
            ""path"": ""ad/47/61"",
            ""md5"": ""ffa92c2f7d3e70aec1a92c0ed408d770""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_29.mp3"",
            ""path"": ""dc/0b/bf/e7"",
            ""md5"": ""108934af9c8ba46a437bdbe80988cf5c""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_30.mp3"",
            ""path"": ""0d/4e"",
            ""md5"": ""98316c3ea77aafb1703614a7b0c07205""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_31.mp3"",
            ""path"": ""d8/f1/b6/df"",
            ""md5"": ""f50c11d25a50e9e78e0dfd15ca1209ec""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_32.mp3"",
            ""path"": ""4c/67"",
            ""md5"": ""8218c3b5e3a54ce054a3475646509e1a""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_33.mp3"",
            ""path"": ""20/7a/38/c2"",
            ""md5"": ""6524c3f6e189dc96221f3f5a19a418fb""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_34.mp3"",
            ""path"": ""31/85/ca/d1"",
            ""md5"": ""05f0e956ffaca8c4b3b901eabc8afa3f""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_35.mp3"",
            ""path"": ""02/57/97/26"",
            ""md5"": ""2956cadc507b9a1153fac8757c84b4e7""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_36.mp3"",
            ""path"": ""23/42"",
            ""md5"": ""0ded895fa0b910444f00eceb19b08048""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_37.mp3"",
            ""path"": ""cb/b5/a5/f8"",
            ""md5"": ""2cdd0268b0401becd9d174ed829d1f1f""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_38.mp3"",
            ""path"": ""3a/4a/ba/dc"",
            ""md5"": ""7e60033d4872c778ccaa0e68eda2c5e2""
        },
        {
            ""fileName"": ""download/character/100100/adv/image/107.jpg"",
            ""path"": ""bf/ca/9d/2e"",
            ""md5"": ""00e888ba27c1bb8ead61818660ba0cd2""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_39.mp3"",
            ""path"": ""c6/bc/f0/d0"",
            ""md5"": ""0cd27b7221e71af795d172e7db2bbbda""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_40.mp3"",
            ""path"": ""ed/0f/14"",
            ""md5"": ""7bc85bb967e10fedcaefec241c3a1d97""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_41.mp3"",
            ""path"": ""02/78"",
            ""md5"": ""1179651af223aaa3354ae0aaba102859""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_42.mp3"",
            ""path"": ""2a/d3"",
            ""md5"": ""e5eedc5bdbb95692b5282a41bcbbf600""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_43.mp3"",
            ""path"": ""cf/d9/a6/ed"",
            ""md5"": ""cbaf7ed16acac966affe7e06c869b831""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_44.mp3"",
            ""path"": ""1e/62/8e/5a"",
            ""md5"": ""2c27e84f827729c67c198450abe19467""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_45.mp3"",
            ""path"": ""1e/af"",
            ""md5"": ""fd0fe32804440d5cae5b5191f043be9a""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_46.mp3"",
            ""path"": ""1b/c3/b7/31"",
            ""md5"": ""835ce7d01496d1f3a93777f998d62b84""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_47.mp3"",
            ""path"": ""ad/f8/8c/dc"",
            ""md5"": ""97f6e49a1d6c88456da85a7d2bbde642""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_48.mp3"",
            ""path"": ""14/e0"",
            ""md5"": ""a943769a16a8d97e20abbbd6f8741d06""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_49.mp3"",
            ""path"": ""8b/ed/85/59"",
            ""md5"": ""fb65548b0d9ccb9dd013fd0eae3e6656""
        },
        {
            ""fileName"": ""download/adv/voice/character/1001/adu100100_01_50.mp3"",
            ""path"": ""c1/3f/65"",
            ""md5"": ""b1d5aa38cc50f9c5f803c579c9ca038c""
        }
    ]
}");
            return resp;
        }
    }
}

