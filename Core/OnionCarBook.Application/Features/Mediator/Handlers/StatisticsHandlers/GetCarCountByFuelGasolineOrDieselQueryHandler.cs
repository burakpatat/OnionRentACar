﻿//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OnionCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
//using OnionCarBook.Application.Features.Mediator.Results.StatisticsResults;
//using OnionCarBook.Application.Interfaces.StatisticsInterfaces;

//namespace OnionCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
//{
//    public class GetCarCountByFuelGasolineOrDieselQueryHandler : IRequestHandler<GetCarCountByFuelGasolineOrDieselQuery, GetCarCountByFuelGasolineOrDieselQueryResult>
//    {
//        private readonly IStatisticsRepository _repository;

//        public GetCarCountByFuelGasolineOrDieselQueryHandler(IStatisticsRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task<GetCarCountByFuelGasolineOrDieselQueryResult> Handle(GetCarCountByFuelGasolineOrDieselQuery request, CancellationToken cancellationToken)
//        {
//            var value = _repository.GetCarCountByFuelGasolineOrDiesel();
//            return new GetCarCountByFuelGasolineOrDieselQueryResult
//            {
//                CarCountByFuelGasolineOrDiesel = value
//            };
//        }
//    }
//}
