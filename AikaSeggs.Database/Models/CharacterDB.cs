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
        public string UserId { get; set; } = string.Empty;

        public string CharacterCd { get; set; } = string.Empty;

        public int CharacterId { get; set; }

        public int Exp { get; set; }

        public int Level { get; set; }

        public int AddHp { get; set; }

        public int AddAtk { get; set; }

        public int AddDef { get; set; }

        public int SkillLevel { get; set; }

        public int AbilityLevel1 { get; set; }

        public int AbilityLevel2 { get; set; }

        public int AbilityLevel3 { get; set; }

        public int ExceedLimit { get; set; }

        public int ExceedLimitExp { get; set; }

        public int IsProtect { get; set; }

        public string RegisterDate { get; set; } = string.Empty;

        public string EquipmentWeaponCds { get; set; } = string.Empty; // JSON array stored as string

        public string EquipmentProtectorCds { get; set; } = string.Empty; // JSON array stored as string

        public string AwakeIds { get; set; } = string.Empty; // JSON array stored as string

        public int BattleCount { get; set; }

        public int AddRarity { get; set; }
    }
}

