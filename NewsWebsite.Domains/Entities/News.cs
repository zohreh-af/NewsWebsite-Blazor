using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsite.Domains.Entities
{
    public class News
    {

        [Key]
        public int NewsId { get; set; }
        [MaxLength(300)]
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [MaxLength(500)]
        [Required]
        public string ShortDescription { get; set; }
        public bool IsActive { get; set; }
        [MaxLength(300)]
        [Required]
        public string ImageName { get; set; }
        public DateTime Create { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
    }
}
