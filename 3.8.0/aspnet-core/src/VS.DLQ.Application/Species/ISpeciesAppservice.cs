using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace VS.DLQ.Species
{
    interface ISpeciesAppservice
    {
        Task<ListResultDto<SpeciesDto>> GetAll();
    }
}
