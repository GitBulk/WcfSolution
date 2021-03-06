﻿using Business.Entities;
using System.ServiceModel;

namespace Business.Services.Contracts
{
    [ServiceContract]
    public interface IBlogService
    {
        [OperationContract]
        void Add(Blog blog);

        [OperationContract]
        void Update(Blog blog);

        [OperationContract]
        void Delete(Blog blog);

        [OperationContract]
        Blog GetById(int id);

        Blog[] GetAll();
    }
}
