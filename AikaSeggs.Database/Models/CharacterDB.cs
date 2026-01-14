using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AikaSeggs.Database.Models
{
    public class CharacterDB
    {
        [JsonIgnore]
        public virtual AccountDB Account { get; set; } = null!;

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserCd { get; set; } = string.Empty;

        public string CharacterCd { get; set; } = string.Empty;

        public int CharacterId { get; set; }

        public string RegisterDate { get; set; } = string.Empty;

        public int Rarity { get; set; }

        public int Count { get; set; }

        public int Exp { get; set; }

        public int Level { get; set; }

        public int SkillLevel { get; set; }

        public int AbilityLevel1 { get; set; }

        public int AbilityLevel2 { get; set; }

        public int AbilityLevel3 { get; set; }

        public int ExceedLimit { get; set; }

        public int ExceedLimitExp { get; set; }

        public int IsProtect { get; set; }

        public int BattleCount { get; set; }
    }
}

