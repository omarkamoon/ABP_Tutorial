using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Authors
{
    public class CreateAuthorDto
    {
        [Required]
        [StringLength(4)]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string ShortBio { get; set; }
    }
}
