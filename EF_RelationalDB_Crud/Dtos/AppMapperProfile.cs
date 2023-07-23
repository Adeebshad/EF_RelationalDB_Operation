using AutoMapper;
using EF_RelationalDB_Crud.Data.Entities;

namespace EF_RelationalDB_Crud.Dtos
{
    public class AppMapperProfile : Profile
    {
        public AppMapperProfile()
        {
            CreateMap<CustomerDto, Customer>();
            CreateMap<CustomerAddressesDto, CustomerAddresses>();
        }
    }
}
