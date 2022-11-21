using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp;

namespace Acme.BookStore.Books
{
    public class CreateUpdateBookDto: IValidatableObject
    {

        public Guid AuthorId { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public BookType Type { get; set; } = BookType.Undefined;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Required]
        public float Price { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Price <= 0) yield return new ValidationResult("Price should be positive");
        }
    }
}
