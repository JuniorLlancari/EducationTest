using Education.Domain;
using Education.Persistence;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Education.Application.Courses
{
    public class CreateCourseCommand
    {
        public class CreateCourseCommandRequest : IRequest
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime? PublicationDate { get; set; }
            public Decimal Precio { get; set; }
        }

        public class CreateCourseCommandRequestValidation: AbstractValidator<CreateCourseCommandRequest>
        {
            public CreateCourseCommandRequestValidation()
            {
                RuleFor(x=> x.Title).NotEmpty();

            }
        }

        public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommandRequest>
        {
             private readonly EducationDbContext _context;
            public CreateCourseCommandHandler(EducationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(CreateCourseCommandRequest request, CancellationToken cancellationToken)
            {
                var course = new Course
                {
                    CourseId = Guid.NewGuid(),
                    Title = request.Title,
                    Description = request.Description,
                    CreationDate = DateTime.Now,
                    Precio = request.Precio,
                    PublicationDate = request.PublicationDate
                };
                _context.Add(course);

                var  valor = await _context.SaveChangesAsync();
                if (valor > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("No se pudo insertar");
            }
        }



    }
}
