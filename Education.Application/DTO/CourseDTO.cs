using System;
using System.Collections.Generic;
using System.Text;

namespace Education.Application.DTO
{
    public class CourseDTO
    {
        public Guid CourseId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? PublicationDate { get; set; }

        public Decimal Precio { get; set; }
    }
}
