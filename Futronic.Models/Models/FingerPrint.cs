using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Futronic.Models
{
    public class FingerPrint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id{ get; set; }
        public byte[] Thumb { get; set; }
        public byte[] IndexFinger { get; set; }
        public byte[] MiddleFinger { get; set; }
        public byte[] RingFinger { get; set; }
        public byte[] LittleFinger { get; set; }
    }
}
