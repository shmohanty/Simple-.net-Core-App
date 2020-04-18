using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCMSample.Models
{
    public class BookData
    {
        public long Id { get; set; }

        public string _key;

        [Required]
        [StringLength(100, ErrorMessage = "Book Name is Mandatory")]
        public string BookName { get; set; }

        public string UserName { get; set; }
        public DateTime BookDate { get; set; }

    }
}
