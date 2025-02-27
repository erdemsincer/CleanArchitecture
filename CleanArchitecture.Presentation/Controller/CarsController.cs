using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Presentation.Controller
{
    public class CarsController : ApiController
    {
        public CarsController(IMediator mediator) : base(mediator) { }

        [HttpPost("[action]")]

        public async Task<IActionResult> Create(CreateCarCommand createCarCommand,CancellationToken cancellationToken)
        {
           MessageResponse messageResponse= await _mediator.Send(createCarCommand,cancellationToken);

            return Ok(messageResponse);

        }
        
    }
}
