using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futronic.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }

        public FingerPrint LeftHand { get; set; }
        public FingerPrint RightHand { get; set; }
        public ICollection<AttendanceLog> AttendanceLogs { get; set; }
    }
}
