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
//    public class GetCarCountByTranmissionIsAutoQueryHandler : IRequestHandler<GetCarCountByTranmissionIsAutoQuery, GetCarCountByTranmissionIsAutoQueryResult>
//    {
//        private readonly IStatisticsRepository _repository;

//        public GetCarCountByTranmissionIsAutoQueryHandler(IStatisticsRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task<GetCarCountByTranmissionIsAutoQueryResult> Handle(GetCarCountByTranmissionIsAutoQuery request, CancellationToken cancellationToken)
//        {
//            var value = _repository.GetCarCountByTranmissionIsAuto();
//            return new GetCarCountByTranmissionIsAutoQueryResult
//            {
//                CarCountByTranmissionIsAuto = value
//            };
//        }
//    }
//}
