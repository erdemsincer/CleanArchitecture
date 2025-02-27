using CleanArchitecture.Domain.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar
{
    public sealed class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, MessageResponse>
    {
        public async Task<MessageResponse> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            return new("Araç başarıyla üretildi");
        }
    }
}
