using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AikaSeggs.Database.Models
{
    public class MissionDB
    {
        [JsonIgnore]
        public virtual AccountDB Account { get; set; } = null!;

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        public int MissionId { get; set; }

        public string MissionCd { get; set; } = string.Empty;

        public int MissionType { get; set; }

        public int MissionGroupId { get; set; }

        public int ClearCount { get; set; }

        public int ReceiveCount { get; set; }
    }
}

