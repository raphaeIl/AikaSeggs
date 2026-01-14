using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AikaSeggs.Database.Models
{
    public class AccountDB
    {
        [JsonIgnore]
        public virtual ICollection<CharacterDB> Characters { get; set; } = [];

        [JsonIgnore]
        public virtual ICollection<StoryDB> Stories { get; set; } = [];

        [JsonIgnore]
        public virtual ICollection<PictureBookDB> PictureBooks { get; set; } = [];

        [Key]
        public int Id { get; set; }

        public string UserId { get; set; } = string.Empty;

        public string UserCd { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string UserNameTextId { get; set; } = string.Empty;

        public int UserNameStatus { get; set; }

        public int Level { get; set; }

        public int Exp { get; set; }

        public int FreeGem { get; set; }

        public int PaidGem { get; set; }

        public int SeVolume { get; set; }

        public int BgmVolume { get; set; }

        public int VoiceVolume { get; set; }

        public int MaxStamina { get; set; }

        public int StaminaValue { get; set; }

        public int MaxBattlePoint { get; set; }

        public int BattlePointValue { get; set; }

        public int ItemMaxCount { get; set; }

        public int CharacterMaxCount { get; set; }

        public int EquipmentMaxCount { get; set; }

        public string SystemDate { get; set; } = string.Empty;

        public string UserText { get; set; } = string.Empty;

        public int PlayerType { get; set; }

        public int BattleSpeed { get; set; }

        public int IsBgmMute { get; set; }

        public int IsSeMute { get; set; }

        public int IsVoiceMute { get; set; }

        public int IsSkillAuto { get; set; }

        public int TutorialStep { get; set; }

        public string TutorialEndDate { get; set; } = string.Empty;

        public string RegisterDate { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;
    }
}

