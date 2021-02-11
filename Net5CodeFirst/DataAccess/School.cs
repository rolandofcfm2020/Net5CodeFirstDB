using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Net5CodeFirst.DataAccess
{
    public class Schools
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SchoolID { get; set; }
        public string SchoolName { get; set; }
        public string UniversityName { get; set; }
        public string Address { get; set; }

        public ICollection<Students> Students { get; set; }

    }
}
