using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Trueffles_Quellenvalidierung.Models
{
    public class Quellen
    {
        public string? ID { get; set; }
        public string URL { get; set; }
        public string Check { get; set; }
        public DateTime? Createdatum { get; set; }
    }
}
