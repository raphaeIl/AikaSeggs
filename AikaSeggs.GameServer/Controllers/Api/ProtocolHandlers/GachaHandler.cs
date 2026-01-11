using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Database;
using AikaSeggs.Common.Packets;
using AikaSeggs.PcapParser;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace AikaSeggs.GameServer.Controllers.Api.ProtocolHandlers
{
    public class GachaHandler : ProtocolHandlerBase
    {
        public GachaHandler(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Gacha_GetUserData)]
        public HttpMessage GachaGetUserData()
        {
            var pcap = PcapParser.PcapParser.Instance.GetPcapPacket(Protocol.Gacha_GetUserData);
            HttpMessage resp = HttpMessage.Create(pcap.Packet.ToString(), pcap.IsMsgpack);
            return resp;
        }

        [ProtocolHandler(Protocol.Gacha_GetDetail)]
        public HttpMessage GachaGetDetail()
        {
            GachaGetDetailResponse resp = new GachaGetDetailResponse
            {
                GachaId = 20730,
                Caution = "・このガチャでは1日1回限定で5連ガチャを引くことが出来ます。\r\n\r\n・こちらのガチャでは確定枠はございません。\r\n\r\n・サーバーとの通信状況やその他の原因により、ガチャ演出がスキップされたり、演出の一部が正常ではない状態で表示されることがありますが、ユニットの追加は正常に完了しております。\r\nギフトボックスをご確認ください。\r\n\r\n・同一ユニットを複数入手しても同一の編成に加えることはできませんのでご注意ください。\r\n\r\n・ユニットは重複して同一のものが出現することがあります。\r\n\r\n・ユニット提供割合にて表示している確率は少数第三位までの表記となっておりますので、合算しても100%ではない可能性があります。",
                Description = new CharacterTextModel
                {
                    Title = "",
                    Text = ""
                },
                Odds = new List<OddsDynamicModel>
                {
                    new OddsDynamicModel
                    {
                        Name = "通常提供割合",
                        DrawCount = 5,
                        Rarity1 = 0,
                        Rarity2 = 870,
                        Rarity3 = 100,
                        Rarity4 = 30,
                        Lineup = new List<LineupDynamicModel>
                        {
                            new LineupDynamicModel()
                            {

                                Items = new List<ItemsDynamicModel>
                                {
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100102, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100202, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100302, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100402, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100502, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100702, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100802, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100902, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101002, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101102, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101202, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101302, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101502, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101802, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101902, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102002, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102102, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102202, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102302, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102402, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102502, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101602, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101702, Count = 1, Rate = 0.043478260869565216, IconType = 0, IsPossession = 1 }
                                },
                                Rarity = "2"
                            },

                            new LineupDynamicModel()
                            {

                                Items = new List<ItemsDynamicModel>
                                {
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100705, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101505, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101205, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102803, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102903, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101905, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103103, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100406, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103203, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102006, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103004, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100506, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101207, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102705, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101906, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100708, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101705, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103205, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101907, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103604, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100408, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100807, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100409, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102806, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101209, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103105, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102708, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102910, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103807, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101507, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103006, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103106, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101312, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102710, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100910, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103907, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103608, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101313, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104807, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104808, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103108, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103812, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101811, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103413, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100713, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104809, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100805, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101105, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102703, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100106, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100405, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102505, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100905, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103003, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102405, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102105, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101306, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102506, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101806, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100207, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102306, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100306, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103303, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100707, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102507, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102007, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102805, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101107, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102207, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101006, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101807, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102107, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103005, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103603, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102308, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100907, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103406, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101208, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102407, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100709, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100908, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103803, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101808, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103206, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103903, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101309, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101908, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100710, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101007, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102508, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102807, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104003, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101707, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101108, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101809, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103207, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101610, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103906, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101109, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102509, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104503, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103408, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102409, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101909, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100410, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102312, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102809, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102011, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102810, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101380, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102012, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103409, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101009, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101810, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100808, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101708, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103209, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104803, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102711, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100809, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101910, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102510, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102209, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101212, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102109, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103210, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104903, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101911, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102313, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103411, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100481, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 105003, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 181508, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 105103, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101614, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100103, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100203, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100303, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100403, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100503, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100703, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100803, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100903, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101003, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101103, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101203, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101303, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101503, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101803, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101903, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102003, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102103, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102203, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102303, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102403, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102503, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101603, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101703, Count = 1, Rate = 0.006329113924050633, IconType = 0, IsPossession = 0 }
                                },
                                Rarity = "3"
                            },

                            new LineupDynamicModel()
                            {

                                Items = new List<ItemsDynamicModel>
                                {
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100105, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100505, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101305, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101805, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102005, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100806, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102305, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101106, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101206, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102804, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102106, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103104, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103404, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103204, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102406, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103405, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100308, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100407, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103505, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102906, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101308, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100508, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100309, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103306, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103605, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103904, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103805, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102010, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101609, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104104, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101311, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100510, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102709, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102912, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104304, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102808, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103606, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102913, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103512, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103007, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104204, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103208, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103312, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103107, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104506, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103313, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103410, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103607, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104508, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103809, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103908, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104010, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104806, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100511, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102108, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103317, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104512, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100123, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103610, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100314, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 105005, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100218, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103519, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104011, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 103719, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 181607, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 104114, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 105204, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100104, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100204, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100304, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100404, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100504, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100704, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100804, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 100904, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101004, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101104, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101204, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101304, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101504, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101804, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101904, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102004, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102104, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102204, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102304, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102404, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 102504, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101604, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 1 },
                                    new ItemsDynamicModel { ItemType = 910, ItemId = 101704, Count = 1, Rate = 0.01098901098901099, IconType = 0, IsPossession = 0 }
                                },
                                Rarity = "4"
                            }
                        }
                    }
                },
                Presents = new List<List<dynamic>>
                {
                    new List<dynamic>()
                },
                SelectPickInfo = new SelectPickInfoDynamicModel
                {
                    UserLineup = new List<dynamic>(),
                    TargetInfo = new List<dynamic>(),
                    SelectGrpupInfoArray = new List<dynamic>()
                },
            };
            return HttpMessage.Create(resp);
        }

        [ProtocolHandler(Protocol.Gacha_GetList)]
        public HttpMessage GachaGetList()
        {


            //new UserGachaModel
            //{
            //    GachaId = 20302,
            //    GachaName = "2025チケットガチャ",
            //    GachaText = "2025チケットガチャ",
            //    GachaType = 3,
            //    GachaGroupId = 0,
            //    Order = 999946,
            //    WeekType = "",
            //    FromDate = "",
            //    ToDate = "",
            //    ConditionType = 0,
            //    ConditionFrom = 0,
            //    ConditionTo = 0,
            //    Banners = new List<dynamic>
            //        {
            //            new { contentsId = 20302, order = 2, text = "スチル1", bannerFile = "2030201", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
            //        },
            //    Buttons = new List<dynamic>
            //        {
            //            new { gachaId = 20302, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781458, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
            //            new { gachaId = 20302, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781458, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
            //        },
            //    AddLayoutType = 0
            //},


            // not
            //new UserGachaModel
            //{
            //    GachaId = 20730,
            //    GachaName = "1日1回 5連無料ガチャ",
            //    GachaText = "1日1回 5連無料ガチャ",
            //    GachaType = 1,
            //    GachaGroupId = 0,
            //    Order = 199992,
            //    WeekType = "",
            //    FromDate = "20251230170000",
            //    ToDate = "20260113235959",
            //    ConditionType = 0,
            //    ConditionFrom = 0,
            //    ConditionTo = 0,
            //    Banners = new List<dynamic>
            //        {
            //            new { contentsId = 20730, order = 1, text = "スチル1", bannerFile = "2073001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
            //        },
            //    Buttons = new List<dynamic>
            //        {
            //            new { gachaId = 20730, buttonId = "1", buttonType = 2, isPlayGacha = true, step = 0, drawCount = 5, costType = 101, costId = 101001, costCount = 0, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
            //        },
            //    AddLayoutType = 0
            //},


            GachaGetListResponse resp = new GachaGetListResponse
            {
                Gacha = new List<UserGachaModel>
    {

                new UserGachaModel
                {
                    GachaId = 10000,
                    GachaName = "プラチナガチャ",
                    GachaText = "プラチナガチャ",
                    GachaType = 1,
                    GachaGroupId = 0,
                    Order = 9999999,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10000, order = 2, text = "スチル1", bannerFile = "1000001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 },
                        new { contentsId = 10000, order = 1, text = "スチル2", bannerFile = "1000002", characterId = 100104, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 2, stepFrom = 0, stepTo = 0 },
                        new { contentsId = 10000, order = 3, text = "スチル3", bannerFile = "1000003", characterId = 100204, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 2, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10000, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 101, costId = 101001, costCount = 300, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10000, buttonId = "3", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 11, costType = 101, costId = 101001, costCount = 3000, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 7, index = 1, itemType = 801, itemId = 801011, itemCount = 3, rate = 1000, rateFrom = 0, rateTo = 1000 } } }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10001,
                    GachaName = "2020チケットガチャ",
                    GachaText = "2020チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999999,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10001, order = 2, text = "スチル1", bannerFile = "1000101", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 },
                        new { contentsId = 10001, order = 1, text = "スチル2", bannerFile = "1000102", characterId = 100104, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 2, stepFrom = 0, stepTo = 0 },
                        new { contentsId = 10001, order = 3, text = "スチル3", bannerFile = "1000103", characterId = 100204, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 2, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10001, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781001, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10001, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781001, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10004,
                    GachaName = "プラチナガチャ",
                    GachaText = "プラチナガチャ",
                    GachaType = 1,
                    GachaGroupId = 0,
                    Order = 9999998,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10008, order = 2, text = "スチル1", bannerFile = "1000001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 },
                        new { contentsId = 10008, order = 1, text = "スチル2", bannerFile = "1000002", characterId = 100104, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 2, stepFrom = 0, stepTo = 0 },
                        new { contentsId = 10008, order = 3, text = "スチル3", bannerFile = "1000003", characterId = 100204, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 2, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10004, buttonId = "1", buttonType = 2, isPlayGacha = true, step = 0, drawCount = 1, costType = 102, costId = 102001, costCount = 100, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 135, index = 1, itemType = 801, itemId = 801011, itemCount = 1, rate = 1000, rateFrom = 0, rateTo = 1000 }, new { presentGroupId = 135, index = 2, itemType = 801, itemId = 801134, itemCount = 1, rate = 1000, rateFrom = 0, rateTo = 1000 } } },
                        new { gachaId = 10004, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 102, costId = 102001, costCount = 300, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 135, index = 1, itemType = 801, itemId = 801011, itemCount = 1, rate = 1000, rateFrom = 0, rateTo = 1000 }, new { presentGroupId = 135, index = 2, itemType = 801, itemId = 801134, itemCount = 1, rate = 1000, rateFrom = 0, rateTo = 1000 } } },
                        new { gachaId = 10004, buttonId = "3", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 11, costType = 102, costId = 102001, costCount = 3000, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 133, index = 1, itemType = 801, itemId = 801011, itemCount = 10, rate = 1000, rateFrom = 0, rateTo = 1000 }, new { presentGroupId = 133, index = 2, itemType = 801, itemId = 801134, itemCount = 10, rate = 1000, rateFrom = 0, rateTo = 1000 } } }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10005,
                    GachaName = "SR以上確定ガチャ",
                    GachaText = "SR以上確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999998,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10005, order = 1, text = "スチル1", bannerFile = "1000501", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10005, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781006, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10005, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781006, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10006,
                    GachaName = "SSR確定ガチャ",
                    GachaText = "SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999997,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10006, order = 1, text = "スチル1", bannerFile = "1000601", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10006, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781004, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10006, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781004, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10010,
                    GachaName = "SSR50%ガチャ",
                    GachaText = "SSR50%ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999996,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10010, order = 1, text = "スチル1", bannerFile = "1001001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10010, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781007, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10010, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781007, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10011,
                    GachaName = "SSR30%ガチャ",
                    GachaText = "SSR30%ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999995,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10011, order = 1, text = "スチル1", bannerFile = "1001101", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10011, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781008, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10011, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781008, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10012,
                    GachaName = "SSR10%ガチャ",
                    GachaText = "SSR10%ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999994,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10012, order = 1, text = "スチル1", bannerFile = "1001201", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10012, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781009, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10012, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781009, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10013,
                    GachaName = "2021チケットガチャ",
                    GachaText = "2021チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999993,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10013, order = 2, text = "スチル1", bannerFile = "1001301", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10013, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781017, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10013, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781017, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10014,
                    GachaName = "2022チケットガチャ",
                    GachaText = "2022チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999992,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10014, order = 2, text = "スチル1", bannerFile = "1001401", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10014, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781082, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10014, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781082, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10015,
                    GachaName = "2020年SSR確定ガチャ",
                    GachaText = "2020年SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999991,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10015, order = 1, text = "スチル1", bannerFile = "1001501", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10015, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781196, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10016,
                    GachaName = "2021年SSR確定ガチャ",
                    GachaText = "2021年SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999990,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10016, order = 1, text = "スチル1", bannerFile = "1001601", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10016, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781197, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10017,
                    GachaName = "2022年SSR確定ガチャ",
                    GachaText = "2022年SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999989,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10017, order = 1, text = "スチル1", bannerFile = "1001701", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10017, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781198, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10903,
                    GachaName = "SR以上確定! SSR50％ガチャ",
                    GachaText = "SR以上確定! SSR50％ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999988,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10903, order = 1, text = "スチル1", bannerFile = "1090301", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10903, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781010, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10903, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781010, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10904,
                    GachaName = "火属性SSR確定ガチャ",
                    GachaText = "火属性SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999987,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10904, order = 1, text = "スチル1", bannerFile = "1090401", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10904, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781011, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10904, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781011, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10905,
                    GachaName = "水属性SSR確定ガチャ",
                    GachaText = "水属性SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999986,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10905, order = 1, text = "スチル1", bannerFile = "1090501", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10905, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781011, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10905, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781011, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10906,
                    GachaName = "雷属性SSR確定ガチャ",
                    GachaText = "雷属性SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999984,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10906, order = 1, text = "スチル1", bannerFile = "1090601", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10906, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781011, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10906, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781011, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10907,
                    GachaName = "風属性SSR確定ガチャ",
                    GachaText = "風属性SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999985,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10907, order = 1, text = "スチル1", bannerFile = "1090701", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10907, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781011, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10907, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781011, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10908,
                    GachaName = "光属性SSR確定ガチャ",
                    GachaText = "光属性SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999983,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10908, order = 1, text = "スチル1", bannerFile = "1090801", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10908, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781011, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10908, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781011, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10909,
                    GachaName = "闇属性SSR確定ガチャ",
                    GachaText = "闇属性SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999982,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10909, order = 1, text = "スチル1", bannerFile = "1090901", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10909, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781011, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 10909, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781011, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 10910,
                    GachaName = "引き直せる!!カムバックサマーガチャ",
                    GachaText = "引き直せる!!カムバックサマーガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999981,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 10910, order = 1, text = "スチル1", bannerFile = "1091001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 10910, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 5, costType = 781, costId = 781012, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 11203,
                    GachaName = "引き直せる!!お月見チケットガチャ",
                    GachaText = "引き直せる!!お月見チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999980,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 11203, order = 1, text = "スチル1", bannerFile = "1120301", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 11203, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 5, costType = 781, costId = 781013, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 16211,
                    GachaName = "期間限定入りチケットガチャ",
                    GachaText = "期間限定入りチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999979,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 16211, order = 1, text = "スチル1", bannerFile = "1621101", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 16211, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781098, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 16211, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781098, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 16212,
                    GachaName = "期間限定入りSSR確定ガチャチケット",
                    GachaText = "期間限定入りSSR確定ガチャチケット",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999978,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 16212, order = 1, text = "スチル1", bannerFile = "1621201", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 16212, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781099, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 16212, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781099, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 16809,
                    GachaName = "SSR当選時 期間限定確定チケットガチャ",
                    GachaText = "SSR当選時 期間限定確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999977,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 16809, order = 1, text = "スチル1", bannerFile = "1680901", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 16809, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781106, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 16809, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781106, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 17011,
                    GachaName = "SSR確定カムバック11連チケットガチャ",
                    GachaText = "SSR確定カムバック11連チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999976,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 17011, order = 1, text = "スチル1", bannerFile = "1701101", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 17011, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 11, costType = 781, costId = 781115, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 17409,
                    GachaName = "特別期間限定確定チケットガチャ",
                    GachaText = "特別期間限定確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999975,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 17409, order = 1, text = "スチル1", bannerFile = "1740901", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 17409, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781118, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 17409, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781118, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 17410,
                    GachaName = "期間限定入りSSR確定ガチャチケット",
                    GachaText = "期間限定入りSSR確定ガチャチケット",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999974,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 17410, order = 1, text = "スチル1", bannerFile = "1741001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 17410, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781119, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19010,
                    GachaName = "2.5th Anniversaryチケットガチャ",
                    GachaText = "2.5th Anniversaryチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999973,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19010, order = 1, text = "スチル1", bannerFile = "1901001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19010, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781161, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19253,
                    GachaName = "2023チケットガチャ",
                    GachaText = "2023チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999972,
                    WeekType = "",
                    FromDate = "20230104170000",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19253, order = 2, text = "スチル1", bannerFile = "1925301", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19253, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781170, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 19253, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781170, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19634,
                    GachaName = "2023サマーチケットガチャ",
                    GachaText = "2023サマーチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999966,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19634, order = 1, text = "スチル1", bannerFile = "1963401", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19634, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781228, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 19634, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781228, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19635,
                    GachaName = "SSR確定2023サマーチケットガチャ",
                    GachaText = "SSR確定2023サマーチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999965,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19635, order = 1, text = "スチル1", bannerFile = "1963501", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19635, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781229, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19698,
                    GachaName = "期間限定SSR確定ガチャ",
                    GachaText = "期間限定SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999964,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19698, order = 1, text = "スチル1", bannerFile = "1969801", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19698, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781252, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19728,
                    GachaName = "7月未所持確定 期間限定入りガチャ",
                    GachaText = "7月未所持確定 期間限定入りガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999963,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19728, order = 1, text = "スチル1", bannerFile = "1972801", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19728, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781261, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19729,
                    GachaName = "8月未所持確定 期間限定入りガチャ",
                    GachaText = "8月未所持確定 期間限定入りガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999962,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19729, order = 1, text = "スチル1", bannerFile = "1972901", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19729, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781262, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19730,
                    GachaName = "9月未所持確定 期間限定入りガチャ",
                    GachaText = "9月未所持確定 期間限定入りガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999961,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19730, order = 1, text = "スチル1", bannerFile = "1973001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19730, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781263, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19861,
                    GachaName = "10月未所持確定 期間限定入りガチャ",
                    GachaText = "10月未所持確定 期間限定入りガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999960,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19861, order = 1, text = "スチル1", bannerFile = "1986101", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19861, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781291, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19862,
                    GachaName = "11月未所持確定 期間限定入りガチャ",
                    GachaText = "11月未所持確定 期間限定入りガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999959,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19862, order = 1, text = "スチル1", bannerFile = "1986201", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19862, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781292, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19863,
                    GachaName = "12月未所持確定 期間限定入りガチャ",
                    GachaText = "12月未所持確定 期間限定入りガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999958,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19863, order = 1, text = "スチル1", bannerFile = "1986301", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19863, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781293, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19873,
                    GachaName = "2024チケットガチャ",
                    GachaText = "2024チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999957,
                    WeekType = "",
                    FromDate = "20190101000000",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19873, order = 2, text = "スチル1", bannerFile = "1987301", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19873, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781297, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 19873, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781297, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19956,
                    GachaName = "1月未所持確定 期間限定入りガチャ",
                    GachaText = "1月未所持確定 期間限定入りガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999956,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19956, order = 1, text = "スチル1", bannerFile = "1995601", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19956, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781335, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19957,
                    GachaName = "2月未所持確定 期間限定入りガチャ",
                    GachaText = "2月未所持確定 期間限定入りガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999955,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19957, order = 1, text = "スチル1", bannerFile = "1995701", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19957, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781336, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 19958,
                    GachaName = "3月未所持確定 期間限定入りガチャ",
                    GachaText = "3月未所持確定 期間限定入りガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999954,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 19958, order = 1, text = "スチル1", bannerFile = "1995801", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 19958, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781337, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20079,
                    GachaName = "4月未所持確定 期間限定入りガチャ",
                    GachaText = "4月未所持確定 期間限定入りガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999953,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20079, order = 1, text = "スチル1", bannerFile = "2007901", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20079, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781378, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20080,
                    GachaName = "5月未所持確定 期間限定入りガチャ",
                    GachaText = "5月未所持確定 期間限定入りガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999952,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20080, order = 1, text = "スチル1", bannerFile = "2008001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20080, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781379, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20081,
                    GachaName = "6月未所持確定 期間限定入りガチャ",
                    GachaText = "6月未所持確定 期間限定入りガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999951,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20081, order = 1, text = "スチル1", bannerFile = "2008101", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20081, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781380, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20115,
                    GachaName = "2024サマーチケットガチャ",
                    GachaText = "2024サマーチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999950,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20115, order = 1, text = "スチル1", bannerFile = "2011501", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20115, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781391, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20115, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781391, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20116,
                    GachaName = "SSR確定2024サマーチケットガチャ",
                    GachaText = "SSR確定2024サマーチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999949,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20116, order = 1, text = "スチル1", bannerFile = "2011601", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20116, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781392, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20116, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781392, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20206,
                    GachaName = "4.5周年直前！期間限定入りSSR確定チケットガチャ",
                    GachaText = "4.5周年直前！期間限定入りSSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999948,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20206, order = 1, text = "スチル1", bannerFile = "2020601", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20206, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781427, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20207,
                    GachaName = "4.5周年直前！期間限定SSR確定チケットガチャ",
                    GachaText = "4.5周年直前！期間限定SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999947,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20207, order = 1, text = "スチル1", bannerFile = "2020701", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20207, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781428, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20302,
                    GachaName = "2025チケットガチャ",
                    GachaText = "2025チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999946,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20302, order = 2, text = "スチル1", bannerFile = "2030201", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20302, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781458, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20302, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781458, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20379,
                    GachaName = "期間限定SSR確定ガチャ",
                    GachaText = "期間限定SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999945,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20379, order = 1, text = "スチル1", bannerFile = "2037901", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20379, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781490, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20410,
                    GachaName = "5周年直前！期間限定入りSSR確定チケットガチャ",
                    GachaText = "5周年直前！期間限定入りSSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999944,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20410, order = 1, text = "スチル1", bannerFile = "2041001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20410, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781504, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20411,
                    GachaName = "5周年直前！期間限定SSR確定チケットガチャ",
                    GachaText = "5周年直前！期間限定SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999943,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20411, order = 1, text = "スチル1", bannerFile = "2041101", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20411, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781505, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20460,
                    GachaName = "2020年期間限定SSR確定チケットガチャ",
                    GachaText = "2020年期間限定SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999942,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20460, order = 1, text = "スチル1", bannerFile = "2046001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20460, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781521, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20461,
                    GachaName = "2021年期間限定SSR確定チケットガチャ",
                    GachaText = "2021年期間限定SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999941,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20461, order = 1, text = "スチル1", bannerFile = "2046101", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20461, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781522, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20462,
                    GachaName = "2022年期間限定SSR確定チケットガチャ",
                    GachaText = "2022年期間限定SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999940,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20462, order = 1, text = "スチル1", bannerFile = "2046201", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20462, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781523, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20463,
                    GachaName = "2023年期間限定SSR確定チケットガチャ",
                    GachaText = "2023年期間限定SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999939,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20463, order = 1, text = "スチル1", bannerFile = "2046301", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20463, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781524, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20464,
                    GachaName = "2024年期間限定SSR確定チケットガチャ",
                    GachaText = "2024年期間限定SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999938,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20464, order = 1, text = "スチル1", bannerFile = "2046401", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20464, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781525, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20465,
                    GachaName = "期間限定SSR確定チケットガチャ",
                    GachaText = "期間限定SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999937,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20465, order = 1, text = "スチル1", bannerFile = "2046501", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20465, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781526, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20494,
                    GachaName = "期間限定SSR確定ガチャ",
                    GachaText = "期間限定SSR確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999936,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20494, order = 1, text = "スチル1", bannerFile = "2049401", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20494, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781538, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20499,
                    GachaName = "2025サマー10連チケットガチャ",
                    GachaText = "2025サマー10連チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999935,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20499, order = 1, text = "スチル1", bannerFile = "2049901", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20499, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781541, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20500,
                    GachaName = "領界侵犯発売記念！SSR確定チケットガチャ",
                    GachaText = "領界侵犯発売記念！SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999934,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20500, order = 1, text = "スチル1", bannerFile = "2050001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20500, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781547, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20501,
                    GachaName = "領界侵犯発売記念！SR以上確定チケットガチャ",
                    GachaText = "領界侵犯発売記念！SR以上確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999933,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20501, order = 1, text = "スチル1", bannerFile = "2050101", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20501, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781548, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20535,
                    GachaName = "未所持SSR確定チケットガチャ",
                    GachaText = "未所持SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999932,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20535, order = 1, text = "スチル1", bannerFile = "2053501", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20535, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781558, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20536,
                    GachaName = "期間限定SSR確定チケットガチャ",
                    GachaText = "期間限定SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999931,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20536, order = 1, text = "スチル1", bannerFile = "2053601", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20536, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781557, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20561,
                    GachaName = "忌杯完結記念！アナザー・期間限定入り未所持SSR確定チケットガチャ",
                    GachaText = "忌杯完結記念！アナザー・期間限定入り未所持SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999930,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20561, order = 1, text = "スチル1", bannerFile = "2056101", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20561, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781565, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20591,
                    GachaName = "一部期間限定入り未所持確定チケットガチャ",
                    GachaText = "一部期間限定入り未所持確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999929,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20591, order = 1, text = "スチル1", bannerFile = "2059101", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20591, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781576, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20627,
                    GachaName = "奇々戯る踊月妖夜チケットガチャ",
                    GachaText = "奇々戯る踊月妖夜チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799523,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20627, order = 1, text = "スチル1", bannerFile = "2062701,2062711", characterId = 0, detailIds = "103522", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20627, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781588, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20627, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781588, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20628,
                    GachaName = "奇々戯る踊月妖夜チケットガチャ",
                    GachaText = "奇々戯る踊月妖夜チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799522,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20628, order = 1, text = "スチル1", bannerFile = "2062801,2062811", characterId = 0, detailIds = "105205", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20628, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781589, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20628, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781589, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20629,
                    GachaName = "期間限定入りチケットガチャ",
                    GachaText = "期間限定入りチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799521,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20629, order = 1, text = "スチル1", bannerFile = "2062901", characterId = 0, detailIds = "", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20629, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781590, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20629, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781590, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20636,
                    GachaName = "第9回　トライアルチケットガチャ",
                    GachaText = "第9回　トライアルチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799520,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20636, order = 1, text = "スチル1", bannerFile = "2063601,2063611", characterId = 0, detailIds = "100315", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20636, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781591, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20636, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781591, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20638,
                    GachaName = "5.5周年直前！期間限定入りSSR確定チケットガチャ",
                    GachaText = "5.5周年直前！期間限定入りSSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999928,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20638, order = 1, text = "スチル1", bannerFile = "2063801", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20638, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781592, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20639,
                    GachaName = "5.5周年直前！期間限定SSR確定チケットガチャ",
                    GachaText = "5.5周年直前！期間限定SSR確定チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999927,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20639, order = 1, text = "スチル1", bannerFile = "2063901", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20639, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781593, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20645,
                    GachaName = "紫陽花 ピックアップチケットガチャ",
                    GachaText = "紫陽花 ピックアップチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799519,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20645, order = 1, text = "スチル1", bannerFile = "2064501,2064511", characterId = 0, detailIds = "181106", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20645, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781594, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20645, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781594, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20646,
                    GachaName = "復刻紫陽花 チケットガチャ",
                    GachaText = "復刻紫陽花 チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799518,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20646, order = 1, text = "スチル1", bannerFile = "2064601,2064611", characterId = 0, detailIds = "181105", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20646, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781595, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20646, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781595, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20649,
                    GachaName = "5周年生放送アンケート推し衣装チケットガチャ",
                    GachaText = "5周年生放送アンケート推し衣装チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799517,
                    WeekType = "",
                    FromDate = "20251107213000",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20649, order = 1, text = "スチル1", bannerFile = "2064901,2064911", characterId = 0, detailIds = "100129", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20649, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781596, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20649, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781596, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20655,
                    GachaName = "幻夢咲く絢繚燦花チケットガチャ",
                    GachaText = "幻夢咲く絢繚燦花チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799516,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20655, order = 1, text = "スチル1", bannerFile = "2065501,2065511", characterId = 0, detailIds = "100185", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20655, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781597, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20655, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781597, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20656,
                    GachaName = "幻夢咲く絢繚燦花チケットガチャ",
                    GachaText = "幻夢咲く絢繚燦花チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799515,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20656, order = 1, text = "スチル1", bannerFile = "2065601,2065611", characterId = 0, detailIds = "104185", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20656, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781598, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20656, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781598, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20657,
                    GachaName = "幻夢咲く絢繚燦花チケットガチャ",
                    GachaText = "幻夢咲く絢繚燦花チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799514,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20657, order = 1, text = "スチル1", bannerFile = "2065701,2065711", characterId = 0, detailIds = "104708", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20657, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781599, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20657, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781599, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20662,
                    GachaName = "5周年生放送アンケート推し衣装チケットガチャ",
                    GachaText = "5周年生放送アンケート推し衣装チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799513,
                    WeekType = "",
                    FromDate = "20251114170000",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20662, order = 1, text = "スチル1", bannerFile = "2066201,2066211", characterId = 0, detailIds = "104219", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20662, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781600, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20662, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781600, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20670,
                    GachaName = "Wユニットチケットガチャ",
                    GachaText = "Wユニットチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799512,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20670, order = 1, text = "スチル1", bannerFile = "2067001,2067011", characterId = 0, detailIds = "200031", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20670, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781601, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20670, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781601, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20673,
                    GachaName = "5周年生放送アンケート推し衣装チケットガチャ",
                    GachaText = "5周年生放送アンケート推し衣装チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799511,
                    WeekType = "",
                    FromDate = "20251121170000",
                    ToDate = "20260131235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20673, order = 1, text = "スチル1", bannerFile = "2067301,2067311", characterId = 0, detailIds = "102923", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20673, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781602, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20673, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781602, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20676,
                    GachaName = "愛綾織る情爛チケットガチャ",
                    GachaText = "愛綾織る情爛チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799510,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260228235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20676, order = 1, text = "スチル1", bannerFile = "2067601,2067611", characterId = 0, detailIds = "105008", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20676, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781604, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20676, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781604, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20677,
                    GachaName = "愛綾織る情爛チケットガチャ",
                    GachaText = "愛綾織る情爛チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799509,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260228235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20677, order = 1, text = "スチル1", bannerFile = "2067701,2067711", characterId = 0, detailIds = "181512", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20677, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781605, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20677, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781605, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20687,
                    GachaName = "白冬に澄む青天チケットガチャ",
                    GachaText = "白冬に澄む青天チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799508,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260228235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20687, order = 1, text = "スチル1", bannerFile = "2068701,2068711", characterId = 0, detailIds = "100513", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20687, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781606, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20687, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781606, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20688,
                    GachaName = "白冬に澄む青天チケットガチャ",
                    GachaText = "白冬に澄む青天チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799507,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260228235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20688, order = 1, text = "スチル1", bannerFile = "2068801,2068811", characterId = 0, detailIds = "105706", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20688, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781607, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20688, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781607, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20689,
                    GachaName = "期間限定入りチケットガチャ",
                    GachaText = "期間限定入りチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799506,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260228235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20689, order = 1, text = "スチル1", bannerFile = "2068901", characterId = 0, detailIds = "", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20689, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781608, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20689, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781608, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20694,
                    GachaName = "第10回　トライアルチケットガチャ",
                    GachaText = "第10回　トライアルチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799505,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260228235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20694, order = 1, text = "スチル1", bannerFile = "2069401,2069411", characterId = 0, detailIds = "100221", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20694, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781609, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20694, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781609, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20703,
                    GachaName = "聖夜に瞬く耀星チケットガチャ",
                    GachaText = "聖夜に瞬く耀星チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799504,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260228235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20703, order = 1, text = "スチル1", bannerFile = "2070301,2070311", characterId = 0, detailIds = "181608", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20703, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781610, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20703, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781610, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20704,
                    GachaName = "聖夜に瞬く耀星チケットガチャ",
                    GachaText = "聖夜に瞬く耀星チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799503,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260228235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20704, order = 1, text = "スチル1", bannerFile = "2070401,2070411", characterId = 0, detailIds = "104220", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20704, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781611, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20704, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781611, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20705,
                    GachaName = "聖夜に瞬く耀星チケットガチャ",
                    GachaText = "聖夜に瞬く耀星チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799502,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "20260228235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20705, order = 1, text = "スチル1", bannerFile = "2070501,2070511", characterId = 0, detailIds = "105108", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20705, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781612, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20705, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781612, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20706,
                    GachaName = "クリスマス記念！期間限定入り未所持確定ガチャ",
                    GachaText = "クリスマス記念！期間限定入り未所持確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999926,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20706, order = 1, text = "スチル1", bannerFile = "2070601", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20706, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781613, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20715,
                    GachaName = "クリスマス記念10連チケットガチャ",
                    GachaText = "クリスマス記念10連チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799501,
                    WeekType = "",
                    FromDate = "20251224000000",
                    ToDate = "20260228235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20715, order = 1, text = "スチル1", bannerFile = "2071501", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20715, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781615, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20720,
                    GachaName = "新・覚醒追加記念チケットガチャ",
                    GachaText = "新・覚醒追加記念チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799500,
                    WeekType = "",
                    FromDate = "20251226170000",
                    ToDate = "20260331235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20720, order = 1, text = "スチル1", bannerFile = "2072001,2072011", characterId = 0, detailIds = "104810", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20720, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781614, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20720, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781614, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20722,
                    GachaName = "瑞春に希む久慶ガチャ",
                    GachaText = "瑞春に希む久慶ガチャ",
                    GachaType = 1,
                    GachaGroupId = 0,
                    Order = 398505,
                    WeekType = "",
                    FromDate = "20251230170000",
                    ToDate = "20260113140000",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20722, order = 1, text = "スチル1", bannerFile = "2072201,2072211", characterId = 0, detailIds = "104117,101320,181107", detailPosX = 250, detailPosY = -300, bannerType = 4, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20722, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 101, costId = 101001, costCount = 300, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 921, index = 1, itemType = 801, itemId = 803143, itemCount = 1, rate = 1000, rateFrom = 0, rateTo = 1000 } } },
                        new { gachaId = 20722, buttonId = "3", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 11, costType = 101, costId = 101001, costCount = 0, discountType = 1, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 922, index = 1, itemType = 801, itemId = 803143, itemCount = 10, rate = 1000, rateFrom = 0, rateTo = 1000 } } }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20723,
                    GachaName = "瑞春に希む久慶ガチャ",
                    GachaText = "瑞春に希む久慶ガチャ",
                    GachaType = 1,
                    GachaGroupId = 0,
                    Order = 398504,
                    WeekType = "",
                    FromDate = "20251230170000",
                    ToDate = "20260113140000",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20723, order = 1, text = "スチル1", bannerFile = "2072301,2072311", characterId = 0, detailIds = "104117,101320,181107", detailPosX = 250, detailPosY = -300, bannerType = 4, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20723, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 102, costId = 102001, costCount = 300, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 921, index = 1, itemType = 801, itemId = 803143, itemCount = 1, rate = 1000, rateFrom = 0, rateTo = 1000 } } },
                        new { gachaId = 20723, buttonId = "3", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 11, costType = 102, costId = 102001, costCount = 1500, discountType = 1, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 922, index = 1, itemType = 801, itemId = 803143, itemCount = 10, rate = 1000, rateFrom = 0, rateTo = 1000 } } }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20726,
                    GachaName = "瑞春に希む久慶ガチャ",
                    GachaText = "瑞春に希む久慶ガチャ",
                    GachaType = 1,
                    GachaGroupId = 0,
                    Order = 398501,
                    WeekType = "",
                    FromDate = "20260103170000",
                    ToDate = "20260106140000",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20726, order = 1, text = "スチル1", bannerFile = "2072601,2072611", characterId = 0, detailIds = "181107", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20726, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 102, costId = 102001, costCount = 300, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 921, index = 1, itemType = 801, itemId = 803143, itemCount = 1, rate = 1000, rateFrom = 0, rateTo = 1000 } } },
                        new { gachaId = 20726, buttonId = "3", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 11, costType = 102, costId = 102001, costCount = 1500, discountType = 1, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 922, index = 1, itemType = 801, itemId = 803143, itemCount = 10, rate = 1000, rateFrom = 0, rateTo = 1000 } } }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20727,
                    GachaName = "瑞春に希む久慶チケットガチャ",
                    GachaText = "瑞春に希む久慶チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799499,
                    WeekType = "",
                    FromDate = "20251230170000",
                    ToDate = "20260331235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20727, order = 1, text = "スチル1", bannerFile = "2072701,2072711", characterId = 0, detailIds = "104117", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20727, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781616, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20727, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781616, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20728,
                    GachaName = "瑞春に希む久慶チケットガチャ",
                    GachaText = "瑞春に希む久慶チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799498,
                    WeekType = "",
                    FromDate = "20251230170000",
                    ToDate = "20260331235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20728, order = 1, text = "スチル1", bannerFile = "2072801,2072811", characterId = 0, detailIds = "101320", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20728, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781617, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20728, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781617, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20729,
                    GachaName = "瑞春に希む久慶チケットガチャ",
                    GachaText = "瑞春に希む久慶チケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 799497,
                    WeekType = "",
                    FromDate = "20251230170000",
                    ToDate = "20260331235959",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20729, order = 1, text = "スチル1", bannerFile = "2072901,2072911", characterId = 0, detailIds = "181107", detailPosX = 250, detailPosY = -300, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20729, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781618, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 20729, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781618, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20730,
                    GachaName = "1日1回 5連無料ガチャ",
                    GachaText = "1日1回 5連無料ガチャ",
                    GachaType = 1,
                    GachaGroupId = 0,
                    Order = 199992,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20730, order = 1, text = "スチル1", bannerFile = "2073001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20730, buttonId = "1", buttonType = 2, isPlayGacha = true, step = 0, drawCount = 5, costType = 101, costId = 101001, costCount = 0, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20731,
                    GachaName = "スペシャルルーム家具GET‼ ステップアップガチャ",
                    GachaText = "スペシャルルーム家具GET‼ ステップアップガチャ",
                    GachaType = 2,
                    GachaGroupId = 0,
                    Order = 398498,
                    WeekType = "",
                    FromDate = "20260101000000",
                    ToDate = "20260108140000",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20731, order = 1, text = "スチル1", bannerFile = "2073101,2073111", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20731, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 1, drawCount = 11, costType = 101, costId = 101001, costCount = 3000, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20734,
                    GachaName = "晴れ着ユニット確定ガチャ",
                    GachaText = "晴れ着ユニット確定ガチャ",
                    GachaType = 2,
                    GachaGroupId = 0,
                    Order = 398500,
                    WeekType = "",
                    FromDate = "20260101000000",
                    ToDate = "20260113140000",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20734, order = 1, text = "スチル1", bannerFile = "2073401", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20734, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 1, drawCount = 11, costType = 101, costId = 101001, costCount = 1500, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 506, index = 1, itemType = 801, itemId = 801011, itemCount = 10, rate = 1000, rateFrom = 0, rateTo = 1000 } } }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 20735,
                    GachaName = "未所持晴れ着ユニット確定ガチャ",
                    GachaText = "未所持晴れ着ユニット確定ガチャ",
                    GachaType = 2,
                    GachaGroupId = 0,
                    Order = 398499,
                    WeekType = "",
                    FromDate = "20260101000000",
                    ToDate = "20260113140000",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 20735, order = 1, text = "スチル1", bannerFile = "2073501", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 20735, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 1, drawCount = 11, costType = 102, costId = 102001, costCount = 1500, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 136, index = 1, itemType = 801, itemId = 801134, itemCount = 10, rate = 1000, rateFrom = 0, rateTo = 1000 } } }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 30000,
                    GachaName = "メモリアガチャ",
                    GachaText = "メモリアガチャ",
                    GachaType = 1,
                    GachaGroupId = 0,
                    Order = 9999997,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 30000, order = 1, text = "スチル1", bannerFile = "3000001", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 30000, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 101, costId = 101001, costCount = 300, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 441, index = 1, itemType = 801, itemId = 801564, itemCount = 1, rate = 1000, rateFrom = 0, rateTo = 1000 } } },
                        new { gachaId = 30000, buttonId = "3", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 11, costType = 101, costId = 101001, costCount = 3000, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic> { new { presentGroupId = 442, index = 1, itemType = 801, itemId = 801564, itemCount = 10, rate = 1000, rateFrom = 0, rateTo = 1000 } } }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 30002,
                    GachaName = "SRメモリア確定10連ガチャ",
                    GachaText = "SRメモリア確定10連ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999971,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 30002, order = 1, text = "スチル1", bannerFile = "3000201", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 30002, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781211, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 30003,
                    GachaName = "紅タイプピックSRメモリア確定ガチャ",
                    GachaText = "紅タイプピックSRメモリア確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999970,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 30003, order = 1, text = "スチル1", bannerFile = "3000301", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 30003, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781210, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 30004,
                    GachaName = "蒼タイプピックSRメモリア確定ガチャ",
                    GachaText = "蒼タイプピックSRメモリア確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999969,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 30004, order = 1, text = "スチル1", bannerFile = "3000401", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 30004, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781210, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 30005,
                    GachaName = "翠タイプピックSRメモリア確定ガチャ",
                    GachaText = "翠タイプピックSRメモリア確定ガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999968,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 30005, order = 1, text = "スチル1", bannerFile = "3000501", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 30005, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781210, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                },

                new UserGachaModel
                {
                    GachaId = 30006,
                    GachaName = "メモリアチケットガチャ",
                    GachaText = "メモリアチケットガチャ",
                    GachaType = 3,
                    GachaGroupId = 0,
                    Order = 999967,
                    WeekType = "",
                    FromDate = "",
                    ToDate = "",
                    ConditionType = 0,
                    ConditionFrom = 0,
                    ConditionTo = 0,
                    Banners = new List<dynamic>
                    {
                        new { contentsId = 30006, order = 1, text = "スチル1", bannerFile = "3000601", characterId = 0, detailIds = "", detailPosX = 0, detailPosY = 0, bannerType = 0, stepFrom = 0, stepTo = 0 }
                    },
                    Buttons = new List<dynamic>
                    {
                        new { gachaId = 30006, buttonId = "1", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 1, costType = 781, costId = 781212, costCount = 1, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() },
                        new { gachaId = 30006, buttonId = "2", buttonType = 1, isPlayGacha = true, step = 0, drawCount = 10, costType = 781, costId = 781212, costCount = 10, discountType = 0, advanceRate = 500, skuId = 0, gachaGroupId = 0, coinPresent = new List<dynamic>() }
                    },
                    AddLayoutType = 0
                }
    }
            };

            foreach (var gacha in resp.Gacha)
            {
                gacha.FromDate = "";
                gacha.ToDate = "";
            }

            return HttpMessage.Create(resp);
        }

        [ProtocolHandler(Protocol.Gacha_Play)]
        public GachaPlayResponse GachaPlay()
        {
            GachaPlayResponse resp = new GachaPlayResponse()
            {
                PictureBookDetail = new List<PictureBookDetailModel>
                {
                    new PictureBookDetailModel { CharacterId = 102308, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102708, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100100, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104200, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104300, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100502, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100402, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100302, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100202, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100103, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100200, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100300, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100400, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100500, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100600, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100700, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100800, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100900, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101000, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101100, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101200, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101300, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101400, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101403, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101500, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101600, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101700, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101800, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101900, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102000, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102100, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102200, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102300, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102400, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102500, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102600, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102700, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102900, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102800, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103000, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103100, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103200, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103400, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103300, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103600, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103700, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103800, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103900, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104000, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104100, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104500, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104700, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104800, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104900, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101902, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100902, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100204, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101804, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100104, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101701, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101601, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102501, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102401, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102301, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102001, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101901, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102201, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102101, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101801, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101501, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101301, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101201, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101101, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101001, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100901, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100801, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100701, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100501, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100401, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100301, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100201, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101102, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102402, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101002, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102804, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100102, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102107, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102502, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102711, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102003, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104003, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101302, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102102, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102302, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101003, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100802, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103004, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 181500, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100705, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101905, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101202, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102006, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100710, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103003, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101107, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102202, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101602, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100702, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102810, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102306, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103107, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102807, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101502, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102509, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103906, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101702, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100907, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101507, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100403, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100309, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101802, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103207, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103606, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100805, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103303, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102002, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100903, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101306, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100203, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101105, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102903, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100207, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102209, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101004, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102503, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100306, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100406, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101803, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102312, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103206, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104903, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100405, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100807, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101106, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102510, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 105000, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104803, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102303, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101380, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104808, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102409, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100409, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100703, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101108, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102507, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102109, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101103, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101604, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101203, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103409, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102007, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102108, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103108, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104600, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 105100, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103312, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100803, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 181507, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100809, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103907, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102504, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102981, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104907, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101208, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101907, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101810, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102207, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102407, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100308, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101906, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100709, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103006, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101109, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102405, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101708, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103007, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103903, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100908, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102305, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104503, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103408, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100481, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100504, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100808, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101910, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103411, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101805, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104807, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102406, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103812, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102809, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100503, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102506, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 105003, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101303, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101209, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101806, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101312, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103210, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100505, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101911, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101503, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101009, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100303, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103103, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103413, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101909, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102806, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104215, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101309, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101212, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101603, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103204, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103205, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102010, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 195304, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103604, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101807, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101207, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 195104, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101505, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102710, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100511, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102011, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102921, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 181508, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103607, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 195204, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102203, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100218, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103608, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103406, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102508, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102403, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102803, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100404, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101908, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101811, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100704, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 102505, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103306, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 181600, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 105700, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101308, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 105200, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104806, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101904, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104114, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101305, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 181100, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101705, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101205, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100506, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 105103, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101614, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103404, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103603, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100905, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103106, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 101313, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103005, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 103809, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100410, Friendship = 0, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 104852, Friendship = 100, ExceedLimit = 0 },
                    new PictureBookDetailModel { CharacterId = 100101, Friendship = 20, ExceedLimit = 0 }
                },
                Missions = new()
                {
                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d117",
                        MissionGroupId = 100001,
                        MissionId = 10000123,
                        MissionType = 102,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d11a",
                        MissionGroupId = 100001,
                        MissionId = 10000126,
                        MissionType = 102,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d119",
                        MissionGroupId = 100001,
                        MissionId = 10000125,
                        MissionType = 102,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d118",
                        MissionGroupId = 100001,
                        MissionId = 10000124,
                        MissionType = 102,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d11b",
                        MissionGroupId = 100001,
                        MissionId = 10000127,
                        MissionType = 102,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d11c",
                        MissionGroupId = 100001,
                        MissionId = 10000128,
                        MissionType = 102,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d11d",
                        MissionGroupId = 100001,
                        MissionId = 10000129,
                        MissionType = 102,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d11e",
                        MissionGroupId = 100001,
                        MissionId = 10000130,
                        MissionType = 102,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d11f",
                        MissionGroupId = 100001,
                        MissionId = 10000131,
                        MissionType = 102,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d130",
                        MissionGroupId = 100001,
                        MissionId = 10000160,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d131",
                        MissionGroupId = 100001,
                        MissionId = 10000161,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d132",
                        MissionGroupId = 100001,
                        MissionId = 10000162,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d13c",
                        MissionGroupId = 100001,
                        MissionId = 10000172,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d13d",
                        MissionGroupId = 100001,
                        MissionId = 10000173,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d13e",
                        MissionGroupId = 100001,
                        MissionId = 10000174,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d13f",
                        MissionGroupId = 100001,
                        MissionId = 10000175,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d140",
                        MissionGroupId = 100001,
                        MissionId = 10000176,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d142",
                        MissionGroupId = 100001,
                        MissionId = 10000178,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d141",
                        MissionGroupId = 100001,
                        MissionId = 10000177,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d143",
                        MissionGroupId = 100001,
                        MissionId = 10000179,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d144",
                        MissionGroupId = 100001,
                        MissionId = 10000180,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d147",
                        MissionGroupId = 100001,
                        MissionId = 10000183,
                        MissionType = 203,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d145",
                        MissionGroupId = 100001,
                        MissionId = 10000181,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d146",
                        MissionGroupId = 100001,
                        MissionId = 10000182,
                        MissionType = 203,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d148",
                        MissionGroupId = 100001,
                        MissionId = 10000184,
                        MissionType = 203,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d149",
                        MissionGroupId = 100001,
                        MissionId = 10000185,
                        MissionType = 203,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d14a",
                        MissionGroupId = 100001,
                        MissionId = 10000186,
                        MissionType = 203,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d14b",
                        MissionGroupId = 100001,
                        MissionId = 10000187,
                        MissionType = 203,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d14c",
                        MissionGroupId = 100001,
                        MissionId = 10000191,
                        MissionType = 204,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d14d",
                        MissionGroupId = 100001,
                        MissionId = 10000192,
                        MissionType = 204,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d14e",
                        MissionGroupId = 100001,
                        MissionId = 10000193,
                        MissionType = 204,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d14f",
                        MissionGroupId = 100001,
                        MissionId = 10000194,
                        MissionType = 303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d150",
                        MissionGroupId = 100001,
                        MissionId = 10000195,
                        MissionType = 303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d153",
                        MissionGroupId = 100001,
                        MissionId = 10000198,
                        MissionType = 303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d154",
                        MissionGroupId = 100001,
                        MissionId = 10000199,
                        MissionType = 303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d151",
                        MissionGroupId = 100001,
                        MissionId = 10000196,
                        MissionType = 303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d152",
                        MissionGroupId = 100001,
                        MissionId = 10000197,
                        MissionType = 303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d155",
                        MissionGroupId = 100001,
                        MissionId = 10000200,
                        MissionType = 303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d156",
                        MissionGroupId = 100001,
                        MissionId = 10000201,
                        MissionType = 303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d158",
                        MissionGroupId = 100001,
                        MissionId = 10000203,
                        MissionType = 301,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d157",
                        MissionGroupId = 100001,
                        MissionId = 10000202,
                        MissionType = 303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d159",
                        MissionGroupId = 100001,
                        MissionId = 10000204,
                        MissionType = 301,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d15a",
                        MissionGroupId = 100001,
                        MissionId = 10000205,
                        MissionType = 301,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d15c",
                        MissionGroupId = 100001,
                        MissionId = 10000207,
                        MissionType = 301,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d15b",
                        MissionGroupId = 100001,
                        MissionId = 10000206,
                        MissionType = 301,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d15d",
                        MissionGroupId = 100001,
                        MissionId = 10000208,
                        MissionType = 301,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d169",
                        MissionGroupId = 100001,
                        MissionId = 10000220,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d168",
                        MissionGroupId = 100001,
                        MissionId = 10000219,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d16a",
                        MissionGroupId = 100001,
                        MissionId = 10000221,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d16b",
                        MissionGroupId = 100001,
                        MissionId = 10000222,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d16c",
                        MissionGroupId = 100001,
                        MissionId = 10000223,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d16d",
                        MissionGroupId = 100001,
                        MissionId = 10000224,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d16e",
                        MissionGroupId = 100001,
                        MissionId = 10000225,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d16f",
                        MissionGroupId = 100001,
                        MissionId = 10000226,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d170",
                        MissionGroupId = 100001,
                        MissionId = 10000227,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d173",
                        MissionGroupId = 100001,
                        MissionId = 10000230,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d171",
                        MissionGroupId = 100001,
                        MissionId = 10000228,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d172",
                        MissionGroupId = 100001,
                        MissionId = 10000229,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d174",
                        MissionGroupId = 100001,
                        MissionId = 10000231,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d175",
                        MissionGroupId = 100001,
                        MissionId = 10000232,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d176",
                        MissionGroupId = 100001,
                        MissionId = 10000233,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d177",
                        MissionGroupId = 100001,
                        MissionId = 10000234,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d178",
                        MissionGroupId = 100001,
                        MissionId = 10000235,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d179",
                        MissionGroupId = 100001,
                        MissionId = 10000236,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d17a",
                        MissionGroupId = 100001,
                        MissionId = 10000237,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d17b",
                        MissionGroupId = 100001,
                        MissionId = 10000238,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d17c",
                        MissionGroupId = 100001,
                        MissionId = 10000239,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d17d",
                        MissionGroupId = 100001,
                        MissionId = 10000240,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d17e",
                        MissionGroupId = 100001,
                        MissionId = 10000241,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d17f",
                        MissionGroupId = 100001,
                        MissionId = 10000242,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d181",
                        MissionGroupId = 100001,
                        MissionId = 10000244,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d180",
                        MissionGroupId = 100001,
                        MissionId = 10000243,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d182",
                        MissionGroupId = 100001,
                        MissionId = 10000245,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d184",
                        MissionGroupId = 100001,
                        MissionId = 10000247,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d183",
                        MissionGroupId = 100001,
                        MissionId = 10000246,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d185",
                        MissionGroupId = 100001,
                        MissionId = 10000248,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d186",
                        MissionGroupId = 100001,
                        MissionId = 10000249,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d187",
                        MissionGroupId = 100001,
                        MissionId = 10000250,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d188",
                        MissionGroupId = 100001,
                        MissionId = 10000251,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d189",
                        MissionGroupId = 100001,
                        MissionId = 10000252,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d18a",
                        MissionGroupId = 100001,
                        MissionId = 10000253,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d18b",
                        MissionGroupId = 100001,
                        MissionId = 10000254,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d18c",
                        MissionGroupId = 100001,
                        MissionId = 10000255,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d18d",
                        MissionGroupId = 100001,
                        MissionId = 10000256,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d190",
                        MissionGroupId = 100001,
                        MissionId = 10000259,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d199",
                        MissionGroupId = 100001,
                        MissionId = 10000268,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d19a",
                        MissionGroupId = 100001,
                        MissionId = 10000269,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1af",
                        MissionGroupId = 100001,
                        MissionId = 10000290,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1b0",
                        MissionGroupId = 100001,
                        MissionId = 10001000,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1b1",
                        MissionGroupId = 100001,
                        MissionId = 10001001,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1b2",
                        MissionGroupId = 100001,
                        MissionId = 10001002,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1b3",
                        MissionGroupId = 100001,
                        MissionId = 10001003,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1b4",
                        MissionGroupId = 100001,
                        MissionId = 10001004,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1b5",
                        MissionGroupId = 100001,
                        MissionId = 10001005,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1b6",
                        MissionGroupId = 100001,
                        MissionId = 10001006,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1b7",
                        MissionGroupId = 100001,
                        MissionId = 10001007,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1b9",
                        MissionGroupId = 100001,
                        MissionId = 10001009,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1b8",
                        MissionGroupId = 100001,
                        MissionId = 10001008,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ba",
                        MissionGroupId = 100001,
                        MissionId = 10001010,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1bc",
                        MissionGroupId = 100001,
                        MissionId = 10001012,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1bb",
                        MissionGroupId = 100001,
                        MissionId = 10001011,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1bd",
                        MissionGroupId = 100001,
                        MissionId = 10001013,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1be",
                        MissionGroupId = 100001,
                        MissionId = 10001014,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1bf",
                        MissionGroupId = 100001,
                        MissionId = 10001015,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1c0",
                        MissionGroupId = 100001,
                        MissionId = 10001016,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1c3",
                        MissionGroupId = 100001,
                        MissionId = 10001019,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1c1",
                        MissionGroupId = 100001,
                        MissionId = 10001017,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1c2",
                        MissionGroupId = 100001,
                        MissionId = 10001018,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1c5",
                        MissionGroupId = 100001,
                        MissionId = 10001021,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1c4",
                        MissionGroupId = 100001,
                        MissionId = 10001020,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1c6",
                        MissionGroupId = 100001,
                        MissionId = 10001022,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1c7",
                        MissionGroupId = 100001,
                        MissionId = 10001023,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1c8",
                        MissionGroupId = 100001,
                        MissionId = 10001024,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1c9",
                        MissionGroupId = 100001,
                        MissionId = 10001025,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ca",
                        MissionGroupId = 100001,
                        MissionId = 10001026,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1cb",
                        MissionGroupId = 100001,
                        MissionId = 10001027,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1cd",
                        MissionGroupId = 100001,
                        MissionId = 10001029,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1cc",
                        MissionGroupId = 100001,
                        MissionId = 10001028,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ce",
                        MissionGroupId = 100001,
                        MissionId = 10001030,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1d0",
                        MissionGroupId = 100001,
                        MissionId = 10001032,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1cf",
                        MissionGroupId = 100001,
                        MissionId = 10001031,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1d2",
                        MissionGroupId = 100001,
                        MissionId = 10001034,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1d1",
                        MissionGroupId = 100001,
                        MissionId = 10001033,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1d3",
                        MissionGroupId = 100001,
                        MissionId = 10001035,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1d4",
                        MissionGroupId = 100001,
                        MissionId = 10001036,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1d5",
                        MissionGroupId = 100001,
                        MissionId = 10001037,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1d6",
                        MissionGroupId = 100001,
                        MissionId = 10001038,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1d9",
                        MissionGroupId = 100001,
                        MissionId = 10001041,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1db",
                        MissionGroupId = 100001,
                        MissionId = 10001043,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1d7",
                        MissionGroupId = 100001,
                        MissionId = 10001039,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1d8",
                        MissionGroupId = 100001,
                        MissionId = 10001040,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1da",
                        MissionGroupId = 100001,
                        MissionId = 10001042,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1de",
                        MissionGroupId = 100001,
                        MissionId = 10001046,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1dc",
                        MissionGroupId = 100001,
                        MissionId = 10001044,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1dd",
                        MissionGroupId = 100001,
                        MissionId = 10001045,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1df",
                        MissionGroupId = 100001,
                        MissionId = 10001047,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1e0",
                        MissionGroupId = 100001,
                        MissionId = 10001048,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1e1",
                        MissionGroupId = 100001,
                        MissionId = 10001049,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1e2",
                        MissionGroupId = 100001,
                        MissionId = 10001050,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1e4",
                        MissionGroupId = 100001,
                        MissionId = 10001052,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1e3",
                        MissionGroupId = 100001,
                        MissionId = 10001051,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1e5",
                        MissionGroupId = 100001,
                        MissionId = 10001053,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1e6",
                        MissionGroupId = 100001,
                        MissionId = 10001054,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1e7",
                        MissionGroupId = 100001,
                        MissionId = 10001055,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1e8",
                        MissionGroupId = 100001,
                        MissionId = 10001056,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1e9",
                        MissionGroupId = 100001,
                        MissionId = 10001057,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1eb",
                        MissionGroupId = 100001,
                        MissionId = 10001059,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ea",
                        MissionGroupId = 100001,
                        MissionId = 10001058,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ec",
                        MissionGroupId = 100001,
                        MissionId = 10001060,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ed",
                        MissionGroupId = 100001,
                        MissionId = 10001061,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ee",
                        MissionGroupId = 100001,
                        MissionId = 10001062,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ef",
                        MissionGroupId = 100001,
                        MissionId = 10001063,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1f0",
                        MissionGroupId = 100001,
                        MissionId = 10001064,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1f2",
                        MissionGroupId = 100001,
                        MissionId = 10001066,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1f1",
                        MissionGroupId = 100001,
                        MissionId = 10001065,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1f6",
                        MissionGroupId = 100001,
                        MissionId = 10001070,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1f3",
                        MissionGroupId = 100001,
                        MissionId = 10001067,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1f4",
                        MissionGroupId = 100001,
                        MissionId = 10001068,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1f5",
                        MissionGroupId = 100001,
                        MissionId = 10001069,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1f7",
                        MissionGroupId = 100001,
                        MissionId = 10001071,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1f8",
                        MissionGroupId = 100001,
                        MissionId = 10001072,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1fa",
                        MissionGroupId = 100001,
                        MissionId = 10001074,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1f9",
                        MissionGroupId = 100001,
                        MissionId = 10001073,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1fb",
                        MissionGroupId = 100001,
                        MissionId = 10001075,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1fc",
                        MissionGroupId = 100001,
                        MissionId = 10001076,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1fd",
                        MissionGroupId = 100001,
                        MissionId = 10001077,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1fe",
                        MissionGroupId = 100001,
                        MissionId = 10001078,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ff",
                        MissionGroupId = 100001,
                        MissionId = 10001079,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d200",
                        MissionGroupId = 100001,
                        MissionId = 10001080,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d201",
                        MissionGroupId = 100001,
                        MissionId = 10001081,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d202",
                        MissionGroupId = 100001,
                        MissionId = 10001082,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d203",
                        MissionGroupId = 100001,
                        MissionId = 10001083,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d204",
                        MissionGroupId = 100001,
                        MissionId = 10001084,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d205",
                        MissionGroupId = 100001,
                        MissionId = 10001085,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d206",
                        MissionGroupId = 100001,
                        MissionId = 10001086,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d207",
                        MissionGroupId = 100001,
                        MissionId = 10001087,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d208",
                        MissionGroupId = 100001,
                        MissionId = 10001088,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d209",
                        MissionGroupId = 100001,
                        MissionId = 10001089,
                        MissionType = 2002,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d20b",
                        MissionGroupId = 100001,
                        MissionId = 10001091,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d20a",
                        MissionGroupId = 100001,
                        MissionId = 10001090,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d20c",
                        MissionGroupId = 100001,
                        MissionId = 10001092,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d20d",
                        MissionGroupId = 100001,
                        MissionId = 10001093,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d20e",
                        MissionGroupId = 100001,
                        MissionId = 10001094,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d210",
                        MissionGroupId = 100001,
                        MissionId = 10001096,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d211",
                        MissionGroupId = 100001,
                        MissionId = 10001097,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d213",
                        MissionGroupId = 100001,
                        MissionId = 10001099,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d20f",
                        MissionGroupId = 100001,
                        MissionId = 10001095,
                        MissionType = 2004,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d212",
                        MissionGroupId = 100001,
                        MissionId = 10001098,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d214",
                        MissionGroupId = 100001,
                        MissionId = 10001100,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d215",
                        MissionGroupId = 100001,
                        MissionId = 10001101,
                        MissionType = 2006,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d217",
                        MissionGroupId = 100001,
                        MissionId = 10001103,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d219",
                        MissionGroupId = 100001,
                        MissionId = 10001105,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d218",
                        MissionGroupId = 100001,
                        MissionId = 10001104,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d216",
                        MissionGroupId = 100001,
                        MissionId = 10001102,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d21a",
                        MissionGroupId = 100001,
                        MissionId = 10001106,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d21b",
                        MissionGroupId = 100001,
                        MissionId = 10001107,
                        MissionType = 2008,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d21c",
                        MissionGroupId = 100001,
                        MissionId = 10001108,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d21e",
                        MissionGroupId = 100001,
                        MissionId = 10001110,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d21f",
                        MissionGroupId = 100001,
                        MissionId = 10001111,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d21d",
                        MissionGroupId = 100001,
                        MissionId = 10001109,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d220",
                        MissionGroupId = 100001,
                        MissionId = 10001112,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d221",
                        MissionGroupId = 100001,
                        MissionId = 10001113,
                        MissionType = 2010,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d222",
                        MissionGroupId = 100001,
                        MissionId = 10001114,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d223",
                        MissionGroupId = 100001,
                        MissionId = 10001115,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d224",
                        MissionGroupId = 100001,
                        MissionId = 10001116,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d225",
                        MissionGroupId = 100001,
                        MissionId = 10001117,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d227",
                        MissionGroupId = 100001,
                        MissionId = 10001119,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d226",
                        MissionGroupId = 100001,
                        MissionId = 10001118,
                        MissionType = 2012,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d228",
                        MissionGroupId = 100001,
                        MissionId = 10001120,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d229",
                        MissionGroupId = 100001,
                        MissionId = 10001121,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d22b",
                        MissionGroupId = 100001,
                        MissionId = 10001123,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d22c",
                        MissionGroupId = 100001,
                        MissionId = 10001124,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d22a",
                        MissionGroupId = 100001,
                        MissionId = 10001122,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d22d",
                        MissionGroupId = 100001,
                        MissionId = 10001125,
                        MissionType = 2014,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "664d5108605bff2f770067a9",
                        MissionGroupId = 100001,
                        MissionId = 10000291,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "67c6e282c6c5130e2b505b6e",
                        MissionGroupId = 100001,
                        MissionId = 10000292,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d10d",
                        MissionGroupId = 100001,
                        MissionId = 10000101,
                        MissionType = 501,
                        ClearCount = 10,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d10e",
                        MissionGroupId = 100001,
                        MissionId = 10000102,
                        MissionType = 501,
                        ClearCount = 20,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d10f",
                        MissionGroupId = 100001,
                        MissionId = 10000103,
                        MissionType = 501,
                        ClearCount = 30,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d110",
                        MissionGroupId = 100001,
                        MissionId = 10000104,
                        MissionType = 501,
                        ClearCount = 40,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d111",
                        MissionGroupId = 100001,
                        MissionId = 10000105,
                        MissionType = 501,
                        ClearCount = 50,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d112",
                        MissionGroupId = 100001,
                        MissionId = 10000106,
                        MissionType = 501,
                        ClearCount = 60,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d114",
                        MissionGroupId = 100001,
                        MissionId = 10000108,
                        MissionType = 501,
                        ClearCount = 80,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d113",
                        MissionGroupId = 100001,
                        MissionId = 10000107,
                        MissionType = 501,
                        ClearCount = 70,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d121",
                        MissionGroupId = 100001,
                        MissionId = 10000133,
                        MissionType = 504,
                        ClearCount = 10,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d120",
                        MissionGroupId = 100001,
                        MissionId = 10000132,
                        MissionType = 504,
                        ClearCount = 3,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d124",
                        MissionGroupId = 100001,
                        MissionId = 10000136,
                        MissionType = 504,
                        ClearCount = 70,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d125",
                        MissionGroupId = 100001,
                        MissionId = 10000137,
                        MissionType = 504,
                        ClearCount = 100,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d122",
                        MissionGroupId = 100001,
                        MissionId = 10000134,
                        MissionType = 504,
                        ClearCount = 30,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d123",
                        MissionGroupId = 100001,
                        MissionId = 10000135,
                        MissionType = 504,
                        ClearCount = 50,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d126",
                        MissionGroupId = 100001,
                        MissionId = 10000138,
                        MissionType = 504,
                        ClearCount = 130,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d127",
                        MissionGroupId = 100001,
                        MissionId = 10000139,
                        MissionType = 504,
                        ClearCount = 160,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d128",
                        MissionGroupId = 100001,
                        MissionId = 10000140,
                        MissionType = 504,
                        ClearCount = 200,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d129",
                        MissionGroupId = 100001,
                        MissionId = 10000141,
                        MissionType = 504,
                        ClearCount = 300,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d12b",
                        MissionGroupId = 100001,
                        MissionId = 10000155,
                        MissionType = 110,
                        ClearCount = 50,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d12a",
                        MissionGroupId = 100001,
                        MissionId = 10000142,
                        MissionType = 504,
                        ClearCount = 400,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d15e",
                        MissionGroupId = 100001,
                        MissionId = 10000209,
                        MissionType = 1,
                        ClearCount = 10,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d15f",
                        MissionGroupId = 100001,
                        MissionId = 10000210,
                        MissionType = 1,
                        ClearCount = 20,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d160",
                        MissionGroupId = 100001,
                        MissionId = 10000211,
                        MissionType = 1,
                        ClearCount = 30,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d163",
                        MissionGroupId = 100001,
                        MissionId = 10000214,
                        MissionType = 1,
                        ClearCount = 120,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d161",
                        MissionGroupId = 100001,
                        MissionId = 10000212,
                        MissionType = 1,
                        ClearCount = 60,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d162",
                        MissionGroupId = 100001,
                        MissionId = 10000213,
                        MissionType = 1,
                        ClearCount = 90,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d164",
                        MissionGroupId = 100001,
                        MissionId = 10000215,
                        MissionType = 1,
                        ClearCount = 200,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d165",
                        MissionGroupId = 100001,
                        MissionId = 10000216,
                        MissionType = 1,
                        ClearCount = 250,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d166",
                        MissionGroupId = 100001,
                        MissionId = 10000217,
                        MissionType = 1,
                        ClearCount = 300,
                        ReceiveCount = 1
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d115",
                        MissionGroupId = 100001,
                        MissionId = 10000109,
                        MissionType = 501,
                        ClearCount = 83,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d116",
                        MissionGroupId = 100001,
                        MissionId = 10000110,
                        MissionType = 501,
                        ClearCount = 83,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d19b",
                        MissionGroupId = 100001,
                        MissionId = 10000270,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d19c",
                        MissionGroupId = 100001,
                        MissionId = 10000271,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d19d",
                        MissionGroupId = 100001,
                        MissionId = 10000272,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1a2",
                        MissionGroupId = 100001,
                        MissionId = 10000277,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d18e",
                        MissionGroupId = 100001,
                        MissionId = 10000257,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1a4",
                        MissionGroupId = 100001,
                        MissionId = 10000279,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1a6",
                        MissionGroupId = 100001,
                        MissionId = 10000281,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d19e",
                        MissionGroupId = 100001,
                        MissionId = 10000273,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ae",
                        MissionGroupId = 100001,
                        MissionId = 10000289,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1a9",
                        MissionGroupId = 100001,
                        MissionId = 10000284,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1a0",
                        MissionGroupId = 100001,
                        MissionId = 10000275,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ad",
                        MissionGroupId = 100001,
                        MissionId = 10000288,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1a8",
                        MissionGroupId = 100001,
                        MissionId = 10000283,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ac",
                        MissionGroupId = 100001,
                        MissionId = 10000287,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1a7",
                        MissionGroupId = 100001,
                        MissionId = 10000282,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d18f",
                        MissionGroupId = 100001,
                        MissionId = 10000258,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d19f",
                        MissionGroupId = 100001,
                        MissionId = 10000274,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1a1",
                        MissionGroupId = 100001,
                        MissionId = 10000276,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1aa",
                        MissionGroupId = 100001,
                        MissionId = 10000285,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1ab",
                        MissionGroupId = 100001,
                        MissionId = 10000286,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1a5",
                        MissionGroupId = 100001,
                        MissionId = 10000280,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d167",
                        MissionGroupId = 100001,
                        MissionId = 10000218,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d1a3",
                        MissionGroupId = 100001,
                        MissionId = 10000278,
                        MissionType = 1,
                        ClearCount = 355,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d12d",
                        MissionGroupId = 100001,
                        MissionId = 10000157,
                        MissionType = 110,
                        ClearCount = 50,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d191",
                        MissionGroupId = 100001,
                        MissionId = 10000260,
                        MissionType = 110,
                        ClearCount = 1,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d196",
                        MissionGroupId = 100001,
                        MissionId = 10000265,
                        MissionType = 110,
                        ClearCount = 1,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d12e",
                        MissionGroupId = 100001,
                        MissionId = 10000158,
                        MissionType = 110,
                        ClearCount = 50,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d192",
                        MissionGroupId = 100001,
                        MissionId = 10000261,
                        MissionType = 110,
                        ClearCount = 1,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d12c",
                        MissionGroupId = 100001,
                        MissionId = 10000156,
                        MissionType = 110,
                        ClearCount = 50,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d12f",
                        MissionGroupId = 100001,
                        MissionId = 10000159,
                        MissionType = 110,
                        ClearCount = 50,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d198",
                        MissionGroupId = 100001,
                        MissionId = 10000267,
                        MissionType = 110,
                        ClearCount = 1,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d195",
                        MissionGroupId = 100001,
                        MissionId = 10000264,
                        MissionType = 110,
                        ClearCount = 1,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d197",
                        MissionGroupId = 100001,
                        MissionId = 10000266,
                        MissionType = 110,
                        ClearCount = 1,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d193",
                        MissionGroupId = 100001,
                        MissionId = 10000262,
                        MissionType = 110,
                        ClearCount = 1,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d194",
                        MissionGroupId = 100001,
                        MissionId = 10000263,
                        MissionType = 110,
                        ClearCount = 1,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d139",
                        MissionGroupId = 100001,
                        MissionId = 10000169,
                        MissionType = 702,
                        ClearCount = 4,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d13b",
                        MissionGroupId = 100001,
                        MissionId = 10000171,
                        MissionType = 702,
                        ClearCount = 4,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d136",
                        MissionGroupId = 100001,
                        MissionId = 10000166,
                        MissionType = 702,
                        ClearCount = 4,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d134",
                        MissionGroupId = 100001,
                        MissionId = 10000164,
                        MissionType = 702,
                        ClearCount = 4,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d135",
                        MissionGroupId = 100001,
                        MissionId = 10000165,
                        MissionType = 702,
                        ClearCount = 4,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d138",
                        MissionGroupId = 100001,
                        MissionId = 10000168,
                        MissionType = 702,
                        ClearCount = 4,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d137",
                        MissionGroupId = 100001,
                        MissionId = 10000167,
                        MissionType = 702,
                        ClearCount = 4,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d13a",
                        MissionGroupId = 100001,
                        MissionId = 10000170,
                        MissionType = 702,
                        ClearCount = 4,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d133",
                        MissionGroupId = 100001,
                        MissionId = 10000163,
                        MissionType = 702,
                        ClearCount = 4,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34c7",
                        MissionGroupId = 200004,
                        MissionId = 20000402,
                        MissionType = 502,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34cb",
                        MissionGroupId = 200004,
                        MissionId = 20000406,
                        MissionType = 901,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34c8",
                        MissionGroupId = 200004,
                        MissionId = 20000403,
                        MissionType = 502,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34c6",
                        MissionGroupId = 200004,
                        MissionId = 20000401,
                        MissionType = 502,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34ca",
                        MissionGroupId = 200004,
                        MissionId = 20000405,
                        MissionType = 1303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34c9",
                        MissionGroupId = 200004,
                        MissionId = 20000404,
                        MissionType = 1303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34d0",
                        MissionGroupId = 300005,
                        MissionId = 30000505,
                        MissionType = 1202,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34ce",
                        MissionGroupId = 300005,
                        MissionId = 30000503,
                        MissionType = 201,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34cc",
                        MissionGroupId = 300005,
                        MissionId = 30000501,
                        MissionType = 502,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34d1",
                        MissionGroupId = 300005,
                        MissionId = 30000506,
                        MissionType = 901,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34cf",
                        MissionGroupId = 300005,
                        MissionId = 30000504,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34cd",
                        MissionGroupId = 300005,
                        MissionId = 30000502,
                        MissionType = 101,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427ac",
                        MissionGroupId = 400602,
                        MissionId = 40060211,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427b4",
                        MissionGroupId = 400602,
                        MissionId = 40060219,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427b9",
                        MissionGroupId = 400602,
                        MissionId = 40060224,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427b6",
                        MissionGroupId = 400602,
                        MissionId = 40060221,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427ba",
                        MissionGroupId = 400602,
                        MissionId = 40060225,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427be",
                        MissionGroupId = 400602,
                        MissionId = 40060229,
                        MissionType = 1202,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427b8",
                        MissionGroupId = 400602,
                        MissionId = 40060223,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427bd",
                        MissionGroupId = 400602,
                        MissionId = 40060228,
                        MissionType = 1202,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427b0",
                        MissionGroupId = 400602,
                        MissionId = 40060215,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427b2",
                        MissionGroupId = 400602,
                        MissionId = 40060217,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427b1",
                        MissionGroupId = 400602,
                        MissionId = 40060216,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427b5",
                        MissionGroupId = 400602,
                        MissionId = 40060220,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427ae",
                        MissionGroupId = 400602,
                        MissionId = 40060213,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427c0",
                        MissionGroupId = 400602,
                        MissionId = 40060231,
                        MissionType = 1202,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427b7",
                        MissionGroupId = 400602,
                        MissionId = 40060222,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427bf",
                        MissionGroupId = 400602,
                        MissionId = 40060230,
                        MissionType = 1202,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427aa",
                        MissionGroupId = 400602,
                        MissionId = 40060209,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427b3",
                        MissionGroupId = 400602,
                        MissionId = 40060218,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427bb",
                        MissionGroupId = 400602,
                        MissionId = 40060226,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427a9",
                        MissionGroupId = 400602,
                        MissionId = 40060208,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427ad",
                        MissionGroupId = 400602,
                        MissionId = 40060212,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427ab",
                        MissionGroupId = 400602,
                        MissionId = 40060210,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427c1",
                        MissionGroupId = 400602,
                        MissionId = 40060232,
                        MissionType = 1202,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427c2",
                        MissionGroupId = 400602,
                        MissionId = 40060233,
                        MissionType = 1202,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427af",
                        MissionGroupId = 400602,
                        MissionId = 40060214,
                        MissionType = 511,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427bc",
                        MissionGroupId = 400602,
                        MissionId = 40060227,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34d8",
                        MissionGroupId = 400602,
                        MissionId = 40060207,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34d6",
                        MissionGroupId = 400602,
                        MissionId = 40060205,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34d4",
                        MissionGroupId = 400602,
                        MissionId = 40060203,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34d7",
                        MissionGroupId = 400602,
                        MissionId = 40060206,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34d3",
                        MissionGroupId = 400602,
                        MissionId = 40060202,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34d2",
                        MissionGroupId = 400602,
                        MissionId = 40060201,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34d5",
                        MissionGroupId = 400602,
                        MissionId = 40060204,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427d7",
                        MissionGroupId = 400603,
                        MissionId = 40060321,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427d9",
                        MissionGroupId = 400603,
                        MissionId = 40060323,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427de",
                        MissionGroupId = 400603,
                        MissionId = 40060328,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427d8",
                        MissionGroupId = 400603,
                        MissionId = 40060322,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427e0",
                        MissionGroupId = 400603,
                        MissionId = 40060330,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427d0",
                        MissionGroupId = 400603,
                        MissionId = 40060314,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427da",
                        MissionGroupId = 400603,
                        MissionId = 40060324,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427dd",
                        MissionGroupId = 400603,
                        MissionId = 40060327,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427ce",
                        MissionGroupId = 400603,
                        MissionId = 40060312,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427d6",
                        MissionGroupId = 400603,
                        MissionId = 40060320,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427d5",
                        MissionGroupId = 400603,
                        MissionId = 40060319,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427df",
                        MissionGroupId = 400603,
                        MissionId = 40060329,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427e1",
                        MissionGroupId = 400603,
                        MissionId = 40060331,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427db",
                        MissionGroupId = 400603,
                        MissionId = 40060325,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427cf",
                        MissionGroupId = 400603,
                        MissionId = 40060313,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427d3",
                        MissionGroupId = 400603,
                        MissionId = 40060317,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427d4",
                        MissionGroupId = 400603,
                        MissionId = 40060318,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427dc",
                        MissionGroupId = 400603,
                        MissionId = 40060326,
                        MissionType = 1501,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427e3",
                        MissionGroupId = 400603,
                        MissionId = 40060333,
                        MissionType = 1502,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427cd",
                        MissionGroupId = 400603,
                        MissionId = 40060311,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427d2",
                        MissionGroupId = 400603,
                        MissionId = 40060316,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427e2",
                        MissionGroupId = 400603,
                        MissionId = 40060332,
                        MissionType = 1502,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6953fa7cfebbb60bfe0427d1",
                        MissionGroupId = 400603,
                        MissionId = 40060315,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34dc",
                        MissionGroupId = 400603,
                        MissionId = 40060304,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34d9",
                        MissionGroupId = 400603,
                        MissionId = 40060301,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34e1",
                        MissionGroupId = 400603,
                        MissionId = 40060309,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34da",
                        MissionGroupId = 400603,
                        MissionId = 40060302,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34db",
                        MissionGroupId = 400603,
                        MissionId = 40060303,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34de",
                        MissionGroupId = 400603,
                        MissionId = 40060306,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34e2",
                        MissionGroupId = 400603,
                        MissionId = 40060310,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34df",
                        MissionGroupId = 400603,
                        MissionId = 40060307,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34e0",
                        MissionGroupId = 400603,
                        MissionId = 40060308,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "695a80f0a40fb80cb67c34dd",
                        MissionGroupId = 400603,
                        MissionId = 40060305,
                        MissionType = 512,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d25d",
                        MissionGroupId = 1300001,
                        MissionId = 130000103,
                        MissionType = 201,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d263",
                        MissionGroupId = 1300001,
                        MissionId = 130000109,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d264",
                        MissionGroupId = 1300001,
                        MissionId = 130000110,
                        MissionType = 901,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d25b",
                        MissionGroupId = 1300001,
                        MissionId = 130000101,
                        MissionType = 601,
                        ClearCount = 1,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d25e",
                        MissionGroupId = 1300001,
                        MissionId = 130000104,
                        MissionType = 702,
                        ClearCount = 1,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d260",
                        MissionGroupId = 1300001,
                        MissionId = 130000106,
                        MissionType = 502,
                        ClearCount = 1,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d262",
                        MissionGroupId = 1300001,
                        MissionId = 130000108,
                        MissionType = 504,
                        ClearCount = 9,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d261",
                        MissionGroupId = 1300001,
                        MissionId = 130000107,
                        MissionType = 501,
                        ClearCount = 5,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d25c",
                        MissionGroupId = 1300001,
                        MissionId = 130000102,
                        MissionType = 101,
                        ClearCount = 3,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d25f",
                        MissionGroupId = 1300001,
                        MissionId = 130000105,
                        MissionType = 104,
                        ClearCount = 1,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d267",
                        MissionGroupId = 1300002,
                        MissionId = 130000203,
                        MissionType = 303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d266",
                        MissionGroupId = 1300002,
                        MissionId = 130000202,
                        MissionType = 301,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d268",
                        MissionGroupId = 1300002,
                        MissionId = 130000204,
                        MissionType = 203,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d269",
                        MissionGroupId = 1300002,
                        MissionId = 130000205,
                        MissionType = 201,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d26e",
                        MissionGroupId = 1300002,
                        MissionId = 130000210,
                        MissionType = 901,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d26c",
                        MissionGroupId = 1300002,
                        MissionId = 130000208,
                        MissionType = 504,
                        ClearCount = 20,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d26a",
                        MissionGroupId = 1300002,
                        MissionId = 130000206,
                        MissionType = 502,
                        ClearCount = 10,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d26b",
                        MissionGroupId = 1300002,
                        MissionId = 130000207,
                        MissionType = 501,
                        ClearCount = 10,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d26d",
                        MissionGroupId = 1300002,
                        MissionId = 130000209,
                        MissionType = 1,
                        ClearCount = 2,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d265",
                        MissionGroupId = 1300002,
                        MissionId = 130000201,
                        MissionType = 101,
                        ClearCount = 10,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d270",
                        MissionGroupId = 1300003,
                        MissionId = 130000302,
                        MissionType = 102,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d271",
                        MissionGroupId = 1300003,
                        MissionId = 130000303,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d276",
                        MissionGroupId = 1300003,
                        MissionId = 130000308,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d272",
                        MissionGroupId = 1300003,
                        MissionId = 130000304,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d278",
                        MissionGroupId = 1300003,
                        MissionId = 130000310,
                        MissionType = 901,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d275",
                        MissionGroupId = 1300003,
                        MissionId = 130000307,
                        MissionType = 504,
                        ClearCount = 40,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d26f",
                        MissionGroupId = 1300003,
                        MissionId = 130000301,
                        MissionType = 110,
                        ClearCount = 50,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d273",
                        MissionGroupId = 1300003,
                        MissionId = 130000305,
                        MissionType = 502,
                        ClearCount = 25,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d277",
                        MissionGroupId = 1300003,
                        MissionId = 130000309,
                        MissionType = 1,
                        ClearCount = 5,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d274",
                        MissionGroupId = 1300003,
                        MissionId = 130000306,
                        MissionType = 501,
                        ClearCount = 20,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d279",
                        MissionGroupId = 1300004,
                        MissionId = 130000401,
                        MissionType = 303,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d27a",
                        MissionGroupId = 1300004,
                        MissionId = 130000402,
                        MissionType = 301,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d27b",
                        MissionGroupId = 1300004,
                        MissionId = 130000403,
                        MissionType = 201,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d27c",
                        MissionGroupId = 1300004,
                        MissionId = 130000404,
                        MissionType = 204,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d280",
                        MissionGroupId = 1300004,
                        MissionId = 130000408,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d282",
                        MissionGroupId = 1300004,
                        MissionId = 130000410,
                        MissionType = 901,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d27e",
                        MissionGroupId = 1300004,
                        MissionId = 130000406,
                        MissionType = 501,
                        ClearCount = 30,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d281",
                        MissionGroupId = 1300004,
                        MissionId = 130000409,
                        MissionType = 1,
                        ClearCount = 10,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d27f",
                        MissionGroupId = 1300004,
                        MissionId = 130000407,
                        MissionType = 504,
                        ClearCount = 80,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d27d",
                        MissionGroupId = 1300004,
                        MissionId = 130000405,
                        MissionType = 502,
                        ClearCount = 50,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d284",
                        MissionGroupId = 1300005,
                        MissionId = 130000502,
                        MissionType = 102,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d285",
                        MissionGroupId = 1300005,
                        MissionId = 130000503,
                        MissionType = 204,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d286",
                        MissionGroupId = 1300005,
                        MissionId = 130000504,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d289",
                        MissionGroupId = 1300005,
                        MissionId = 130000507,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d288",
                        MissionGroupId = 1300005,
                        MissionId = 130000506,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d287",
                        MissionGroupId = 1300005,
                        MissionId = 130000505,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d28a",
                        MissionGroupId = 1300005,
                        MissionId = 130000508,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d28b",
                        MissionGroupId = 1300005,
                        MissionId = 130000509,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d28c",
                        MissionGroupId = 1300005,
                        MissionId = 130000510,
                        MissionType = 901,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d283",
                        MissionGroupId = 1300005,
                        MissionId = 130000501,
                        MissionType = 110,
                        ClearCount = 50,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d28e",
                        MissionGroupId = 1300006,
                        MissionId = 130000602,
                        MissionType = 102,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d28f",
                        MissionGroupId = 1300006,
                        MissionId = 130000603,
                        MissionType = 204,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d291",
                        MissionGroupId = 1300006,
                        MissionId = 130000605,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d290",
                        MissionGroupId = 1300006,
                        MissionId = 130000604,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d292",
                        MissionGroupId = 1300006,
                        MissionId = 130000606,
                        MissionType = 1302,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d293",
                        MissionGroupId = 1300006,
                        MissionId = 130000607,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d294",
                        MissionGroupId = 1300006,
                        MissionId = 130000608,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d295",
                        MissionGroupId = 1300006,
                        MissionId = 130000609,
                        MissionType = 503,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d296",
                        MissionGroupId = 1300006,
                        MissionId = 130000610,
                        MissionType = 901,
                        ClearCount = 0,
                        ReceiveCount = 0
                    },

                    new MissionModel
                    {
                        MissionCd = "6620ff08b72884122c00d28d",
                        MissionGroupId = 1300006,
                        MissionId = 130000601,
                        MissionType = 110,
                        ClearCount = 50,
                        ReceiveCount = 0
                    },

                },
                FinishedMissionCds = new List<string>(),
                User = new UserBasicInfoModel
                {
                    UserCd = "1vHS7sj9nC1Gz7fuk8CbZE",
                    DisplayId = "CMMMMJGW",
                    UserName = "123",
                    UserNameTextId = "159875887",
                    UserNameStatus = 1,
                    UserText = "",
                    RegisterDate = "20240418200743",
                    IsEnabled = 1,
                    PlayerType = 1,
                    Exp = 2063139,
                    Level = 83,
                    DefaultDeckId = 1,
                    StaminaValue = 189,
                    StaminaBonus = 0,
                    StaminaRecoveryDate = "20251226214257",
                    StaminaRemainSec = 166,
                    BattlePointValue = 10,
                    BattlePointBonus = 0,
                    BattlePointRecoveryDate = "20260105000203",
                    BattlePointRemainSec = 0,
                    BgmVolume = 50,
                    SeVolume = 50,
                    VoiceVolume = 100,
                    IsBgmMute = 0,
                    IsSeMute = 0,
                    IsVoiceMute = 0,
                    IsSkillAuto = 1,
                    BattleSpeed = 3,
                    CharacterMaxCount = 150,
                    EquipmentMaxCount = 150,
                    RoomCharacterMaxCount = 3,
                    ItemMaxCount = 999,
                    Partner = new { partnerId = 0, isDisplayRoom = 0 },
                    TutorialStep = 12,
                    TutorialEndDate = "20240418200752",
                    SystemDate = "20260105000431"
                },
                Gem = new UserGemModel
                {
                    FreeGem = 999888777,
                    PaidGem = 999888777
                },
                Boosts = new List<UserBoostModel>(),
                AddPresents = new List<AddPresentsDynamicModel>
                {
                    new AddPresentsDynamicModel
                    {
                        _id = "695a817f518e2f0d36f62380",
                        Id = "695a817f518e2f0d36f62380",
                        UserCd = "1vHS7sj9nC1Gz7fuk8CbZE",
                        Category = 1,
                        ItemType = 910,
                        MasterId = 100402,
                        Count = 1,
                        Presenter = 0,
                        PresentDate = "20260105000431",
                        ReceiveStartDate = "20260105000431",
                        ReceiveEndDate = "99991231235959",
                        IsReceived = 0,
                        MessageId = 6,
                        Parameters = new List<string> { "ガチャ", "ユニット" },
                        IsPaid = 0,
                        EventId = 0
                    },
                    new AddPresentsDynamicModel
                    {
                        _id = "695a817f518e2f0d36f62381",
                        Id = "695a817f518e2f0d36f62381",
                        UserCd = "1vHS7sj9nC1Gz7fuk8CbZE",
                        Category = 1,
                        ItemType = 910,
                        MasterId = 100802,
                        Count = 1,
                        Presenter = 0,
                        PresentDate = "20260105000431",
                        ReceiveStartDate = "20260105000431",
                        ReceiveEndDate = "99991231235959",
                        IsReceived = 0,
                        MessageId = 6,
                        Parameters = new List<string> { "ガチャ", "ユニット" },
                        IsPaid = 0,
                        EventId = 0
                    },
                    new AddPresentsDynamicModel
                    {
                        _id = "695a817f518e2f0d36f62382",
                        Id = "695a817f518e2f0d36f62382",
                        UserCd = "1vHS7sj9nC1Gz7fuk8CbZE",
                        Category = 1,
                        ItemType = 910,
                        MasterId = 100702,
                        Count = 1,
                        Presenter = 0,
                        PresentDate = "20260105000431",
                        ReceiveStartDate = "20260105000431",
                        ReceiveEndDate = "99991231235959",
                        IsReceived = 0,
                        MessageId = 6,
                        Parameters = new List<string> { "ガチャ", "ユニット" },
                        IsPaid = 0,
                        EventId = 0
                    },
                    new AddPresentsDynamicModel
                    {
                        _id = "695a817f518e2f0d36f62383",
                        Id = "695a817f518e2f0d36f62383",
                        UserCd = "1vHS7sj9nC1Gz7fuk8CbZE",
                        Category = 1,
                        ItemType = 910,
                        MasterId = 101380,
                        Count = 1,
                        Presenter = 0,
                        PresentDate = "20260105000431",
                        ReceiveStartDate = "20260105000431",
                        ReceiveEndDate = "99991231235959",
                        IsReceived = 0,
                        MessageId = 6,
                        Parameters = new List<string> { "ガチャ", "ユニット" },
                        IsPaid = 0,
                        EventId = 0
                    },
                    new AddPresentsDynamicModel
                    {
                        _id = "695a817f518e2f0d36f62384",
                        Id = "695a817f518e2f0d36f62384",
                        UserCd = "1vHS7sj9nC1Gz7fuk8CbZE",
                        Category = 1,
                        ItemType = 910,
                        MasterId = 100802,
                        Count = 1,
                        Presenter = 0,
                        PresentDate = "20260105000431",
                        ReceiveStartDate = "20260105000431",
                        ReceiveEndDate = "99991231235959",
                        IsReceived = 0,
                        MessageId = 6,
                        Parameters = new List<string> { "ガチャ", "ユニット" },
                        IsPaid = 0,
                        EventId = 0
                    }
                },
                AddCharacters = new List<CharacterModel>(),
                CharacterLinks = new List<CharacterLinkUnitModel>(),
                AddEquipments = new List<EquipmentModel>(),
                AddMemorials = new List<MemorialModel>(),
                Items = new List<ItemModel>
                {
                    new ItemModel { ItemId = 801010, ItemType = 801, Count = 19050 },
                    new ItemModel { ItemId = 509002, ItemType = 509, Count = 23 },
                    new ItemModel { ItemId = 701001, ItemType = 701, Count = 905 },
                    new ItemModel { ItemId = 732036, ItemType = 732, Count = 1 },
                    new ItemModel { ItemId = 721001, ItemType = 721, Count = 1164 },
                    new ItemModel { ItemId = 781004, ItemType = 781, Count = 12 },
                    new ItemModel { ItemId = 781006, ItemType = 781, Count = 3 },
                    new ItemModel { ItemId = 601002, ItemType = 601, Count = 39 },
                    new ItemModel { ItemId = 601001, ItemType = 601, Count = 22 },
                    new ItemModel { ItemId = 509001, ItemType = 509, Count = 14 },
                    new ItemModel { ItemId = 201001, ItemType = 201, Count = 5741702 },
                    new ItemModel { ItemId = 701002, ItemType = 701, Count = 11 },
                    new ItemModel { ItemId = 1000003, ItemType = 311, Count = 7 },
                    new ItemModel { ItemId = 602013, ItemType = 602, Count = 19 },
                    new ItemModel { ItemId = 602011, ItemType = 602, Count = 8 },
                    new ItemModel { ItemId = 602012, ItemType = 602, Count = 18 },
                    new ItemModel { ItemId = 602015, ItemType = 602, Count = 10 },
                    new ItemModel { ItemId = 602021, ItemType = 602, Count = 2 },
                    new ItemModel { ItemId = 602026, ItemType = 602, Count = 13 },
                    new ItemModel { ItemId = 602023, ItemType = 602, Count = 8 },
                    new ItemModel { ItemId = 602025, ItemType = 602, Count = 7 },
                    new ItemModel { ItemId = 711001, ItemType = 711, Count = 54 },
                    new ItemModel { ItemId = 801564, ItemType = 801, Count = 20 },
                    new ItemModel { ItemId = 781297, ItemType = 781, Count = 79 },
                    new ItemModel { ItemId = 1000001, ItemType = 311, Count = 108 },
                    new ItemModel { ItemId = 1000002, ItemType = 311, Count = 78 },
                    new ItemModel { ItemId = 801011, ItemType = 801, Count = 161 },
                    new ItemModel { ItemId = 602022, ItemType = 602, Count = 11 },
                    new ItemModel { ItemId = 602016, ItemType = 602, Count = 25 },
                    new ItemModel { ItemId = 602014, ItemType = 602, Count = 23 },
                    new ItemModel { ItemId = 303001, ItemType = 303, Count = 25 },
                    new ItemModel { ItemId = 612001, ItemType = 612, Count = 22880 },
                    new ItemModel { ItemId = 613001, ItemType = 613, Count = 17647 },
                    new ItemModel { ItemId = 509003, ItemType = 509, Count = 28 },
                    new ItemModel { ItemId = 602041, ItemType = 602, Count = 19 },
                    new ItemModel { ItemId = 602042, ItemType = 602, Count = 19 },
                    new ItemModel { ItemId = 602043, ItemType = 602, Count = 19 },
                    new ItemModel { ItemId = 602044, ItemType = 602, Count = 19 },
                    new ItemModel { ItemId = 602045, ItemType = 602, Count = 19 },
                    new ItemModel { ItemId = 602046, ItemType = 602, Count = 19 },
                    new ItemModel { ItemId = 303002, ItemType = 303, Count = 19 },
                    new ItemModel { ItemId = 781099, ItemType = 781, Count = 3 },
                    new ItemModel { ItemId = 781106, ItemType = 781, Count = 30 },
                    new ItemModel { ItemId = 722003, ItemType = 722, Count = 200 },
                    new ItemModel { ItemId = 732053, ItemType = 732, Count = 1 },
                    new ItemModel { ItemId = 602036, ItemType = 602, Count = 12 },
                    new ItemModel { ItemId = 602035, ItemType = 602, Count = 12 },
                    new ItemModel { ItemId = 602034, ItemType = 602, Count = 12 },
                    new ItemModel { ItemId = 602033, ItemType = 602, Count = 12 },
                    new ItemModel { ItemId = 602032, ItemType = 602, Count = 12 },
                    new ItemModel { ItemId = 602031, ItemType = 602, Count = 12 },
                    new ItemModel { ItemId = 781212, ItemType = 781, Count = 20 },
                    new ItemModel { ItemId = 781211, ItemType = 781, Count = 1 },
                    new ItemModel { ItemId = 781391, ItemType = 781, Count = 36 },
                    new ItemModel { ItemId = 781392, ItemType = 781, Count = 2 },
                    new ItemModel { ItemId = 602024, ItemType = 602, Count = 3 },
                    new ItemModel { ItemId = 801134, ItemType = 801, Count = 10 },
                    new ItemModel { ItemId = 781011, ItemType = 781, Count = 3 },
                    new ItemModel { ItemId = 781458, ItemType = 781, Count = 12 },
                    new ItemModel { ItemId = 506001, ItemType = 506, Count = 1 },
                    new ItemModel { ItemId = 502001, ItemType = 502, Count = 1 }
                },
                GetCharacters = new List<UserCharacterModel>(),
                GetEquipments = new List<EquipmentModel>(),
                PreConvert = new List<CharacterSellBonusModel>
                {
                    new CharacterSellBonusModel { ItemType = 910, ItemId = 100402, Count = 1, Rarity = 2 },
                    new CharacterSellBonusModel { ItemType = 910, ItemId = 100802, Count = 1, Rarity = 2 },
                    new CharacterSellBonusModel { ItemType = 910, ItemId = 100702, Count = 1, Rarity = 2 },
                    new CharacterSellBonusModel { ItemType = 910, ItemId = 101380, Count = 1, Rarity = 3 },
                    new CharacterSellBonusModel { ItemType = 910, ItemId = 100802, Count = 1, Rarity = 2 }
                },
                Cards = new List<CharacterSellBonusModel>
                {
                    new CharacterSellBonusModel { ItemType = 910, ItemId = 100402, Count = 1, Rarity = 2 },
                    new CharacterSellBonusModel { ItemType = 910, ItemId = 100802, Count = 1, Rarity = 2 },
                    new CharacterSellBonusModel { ItemType = 910, ItemId = 100702, Count = 1, Rarity = 2 },
                    new CharacterSellBonusModel { ItemType = 910, ItemId = 101380, Count = 1, Rarity = 3 },
                    new CharacterSellBonusModel { ItemType = 910, ItemId = 100802, Count = 1, Rarity = 2 }
                },
                IsCanReplay = false,
                RemainReplayCount = 0,
                Button = new ButtonDynamicModel
                {
                    GachaId = 20730,
                    ButtonId = 1,
                    ButtonType = 2,
                    IsPlayGacha = false,
                    Step = 0,
                    DrawCount = 5,
                    CostType = 101,
                    CostId = 101001,
                    CostCount = 0,
                    DiscountType = 0,
                    AdvanceRate = 500,
                    SkuId = 0,
                    GachaGroupId = 0,
                    CoinPresent = new List<dynamic>()
                }
            };

            return resp;
        }
    }
}
                   
