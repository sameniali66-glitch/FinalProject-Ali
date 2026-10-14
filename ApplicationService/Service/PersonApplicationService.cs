using ApplicationService.Dtos;
using Model.DomainModels;
using Model.ServiceModels;
using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace ApplicationService.Service
{
    public class PersonApplicationService
    {
        private readonly PersonServiceModel _personServiceModel;
        public PersonApplicationService()
        {
            _personServiceModel = new PersonServiceModel();
        }

        public int Id { get; private set; }

        #region [- GetAll() -]
        public List<GetPersonDto> GetAll()
        {
            var persons = _personServiceModel.SelectAll();
            var getPersonDtos = new List<GetPersonDto>();
            foreach (var item in persons)
            {
                var getPersonDto = new GetPersonDto()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                };

            }
            return getPersonDtos;
        } 
        #endregion
    }
}
