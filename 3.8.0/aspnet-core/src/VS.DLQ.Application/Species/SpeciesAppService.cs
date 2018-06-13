using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace VS.DLQ.Species
{
    public class SpeciesAppService :  DLQAppServiceBase, ISpeciesAppservice
    {
        private readonly IRepository<Fish.Species> _speciesRepository;

        public SpeciesAppService(IRepository<Fish.Species> speciesRepository)
        {
            _speciesRepository = speciesRepository;
        }

        public async Task<ListResultDto<SpeciesDto>> GetAll()
        {
            var species = await _speciesRepository
                .GetAll()
                .OrderByDescending(t => t.TimeStamp)
                .ToListAsync();

            return new ListResultDto<SpeciesDto>(
                 ObjectMapper.Map<List<SpeciesDto>>(species)
            );
        }
    }
}
