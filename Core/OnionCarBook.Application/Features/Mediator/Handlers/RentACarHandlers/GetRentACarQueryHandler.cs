﻿//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OnionCarBook.Application.Features.Mediator.Queries.PricingQueries;
//using OnionCarBook.Application.Features.Mediator.Queries.RentACarQueries;
//using OnionCarBook.Application.Features.Mediator.Results.PricingResults;
//using OnionCarBook.Application.Features.Mediator.Results.RentACarResults;
//using OnionCarBook.Application.Interfaces.RentACarInterfaces;

//namespace OnionCarBook.Application.Features.Mediator.Handlers.RentACarHandlers
//{
//    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
//    {
//        private readonly IRentACarRepository _repository;
//        public GetRentACarQueryHandler(IRentACarRepository repository)
//        {
//            _repository = repository;
//        }
//        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
//        {
//            var values = await _repository.GetByFilterAsync(x => x.LocationID == request.LocationID && x.Available == true);
//            var results = values.Select(y => new GetRentACarQueryResult
//            {
//                CarId = y.CarID,
//                Brand = y.Car.Brand.Name,
//                Model = y.Car.Model,
//                CoverImageUrl = y.Car.CoverImageUrl
//            }).ToList();
//            return results;
//        }
//    }
//}