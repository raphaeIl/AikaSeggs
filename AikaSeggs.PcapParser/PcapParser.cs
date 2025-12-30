using AikaSeggs.Common;
using AikaSeggs.Common.Core;
using AikaSeggs.Common.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AikaSeggs.PcapParser
{
    public class PcapParser : Singleton<PcapParser>
    {
        public List<DeepOnePacket> packets = new List<DeepOnePacket>();

        public void LoadAllPackets()
        {
            // Get all JSON files in the PcapDir
            var pcapFiles = Directory.GetFiles(Config.PcapDir, "*.json");
            
            Console.WriteLine($"Found {pcapFiles.Length} pcap file(s) in {Config.PcapDir}");
            
            foreach (var pcapFile in pcapFiles)
            {
                string fileName = Path.GetFileName(pcapFile);
                Console.WriteLine($"Loading pcap file: {fileName}");
                PcapParser.Instance.Parse(fileName);
            }
        }

        public DeepOnePacket[] GetAllPcapPacketOfType(Protocol protocol)
        {
            return packets.Where(p => p.Protocol == protocol).ToArray();
        }

        public DeepOnePacket GetPcapPacket(Protocol protocol)
        {
            return packets.Where(p => p.Protocol == protocol).FirstOrDefault();
        }

        public DeepOnePacket GetRawPacket(Protocol protocol)
        {
            return packets.Where(p => p.Protocol == protocol).FirstOrDefault();
        }

        public DeepOnePacket[] GetRawPackets(Protocol protocol)
        {
            return packets.Where(p => p.Protocol == protocol).ToArray();
        }

        public void Parse(string pcapFileName)
        {
            string pcapJsonFile = File.ReadAllText(Path.Combine(Config.PcapDir, pcapFileName));
            var pcapPackets = JsonConvert.DeserializeObject<List<PcapPacket>>(pcapJsonFile);

            foreach (PcapPacket pcapPacket in pcapPackets)
            {
                // Remove leading slash and query parameters
                string path = pcapPacket.Path.Substring(1);
                int queryIndex = path.IndexOf('?');
                if (queryIndex > 0)
                {
                    path = path.Substring(0, queryIndex);
                }
                
                Protocol protocol = Util.GetProtocolFromRoute(path);
                
                Console.WriteLine($"Processing path: {pcapPacket.Path}");
                Console.WriteLine($"Converted to protocol: {protocol}");

                if (protocol == Protocol.Unknown)
                {
                    Console.WriteLine($"Unknown protocol for path: {pcapPacket.Path}");
                    continue;
                }

                // Create DeepOnePacket
                packets.Add(new DeepOnePacket()
                {
                    Packet = pcapPacket.Packet,
                    Protocol = protocol,
                    IsMsgpack = pcapPacket.IsMsgpack
                });
            }
            
            Console.WriteLine($"Loaded {packets.Count} packet(s)");
        }

        //public void SavePackets(string saveFileName)
        //{
        //    Console.WriteLine($"Got {packets.Count} packet(s) out a total of x");
        //    File.WriteAllText($"{Config.PcapDir}/{saveFileName}", JsonConvert.SerializeObject(packets, Formatting.Indented));
        //}
    }

    public class PcapPacket
    {
        [JsonProperty("packet")]
        public JObject Packet { get; set; }
        
        [JsonProperty("path")]
        public string Path { get; set; }
        
        [JsonProperty("isMsgpack")]
        public bool IsMsgpack { get; set; }
    }

    public class DeepOnePacket
    {
        public JObject Packet { get; set; }
        public Protocol Protocol { get; set; }
        public bool IsMsgpack { get; set; }
    }
}