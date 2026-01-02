using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AikaSeggs.Database.Models
{
    public class EquipmentDB
    {
        [JsonIgnore]
        public virtual AccountDB Account { get; set; } = null!;

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        public string EquipmentCd { get; set; } = string.Empty;

        public int EquipmentId { get; set; }

        public int Level { get; set; }

        public int Exp { get; set; }

        public int ExceedLimit { get; set; }

        public int ExceedLimitExp { get; set; }

        public int IsProtect { get; set; }

        public string RegisterDate { get; set; } = string.Empty;
    }
}

