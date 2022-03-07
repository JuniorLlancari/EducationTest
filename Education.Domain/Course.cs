using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Education.Domain
{
    public class Course
    {
        [Key]
        public Guid CourseId { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required, StringLength(100)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DateInFuture]
        public DateTime? PublicationDate { get; set; }


        [DataType(DataType.Date)]
        [DateInFuture]
        public DateTime? CreationDate { get; set; }

        public Decimal Precio { get; set; }

    }
}
