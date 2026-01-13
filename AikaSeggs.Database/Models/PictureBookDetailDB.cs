using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AikaSeggs.Database.Models
{
    public class PictureBookDetailDB
    {
        [JsonIgnore]
        public virtual AccountDB Account { get; set; } = null!;

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserCd { get; set; } = string.Empty;

        public int CharacterId { get; set; }

        public int Friendship { get; set; }

        public int ExceedLimit { get; set; }
    }
}

