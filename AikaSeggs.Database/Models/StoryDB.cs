using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AikaSeggs.Database.Models
{
    public class StoryDB
    {
        [JsonIgnore]
        public virtual AccountDB Account { get; set; } = null!;

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserCd { get; set; } = string.Empty;

        public int StoryId { get; set; }

        public int IsRead { get; set; }
    }
}

