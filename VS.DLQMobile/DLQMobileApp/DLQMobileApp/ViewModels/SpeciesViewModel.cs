using DLQMobileApp.Interfaces;
using DLQMobileApp.Models;
using DLQMobileApp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DLQMobileApp.ViewModels
{
    public class SpeciesViewModel
    {
        private readonly ISpeciesService _service;

        public SpeciesViewModel ()
        {
            _service = ServiceContainer.Resolve<ISpeciesService>();
        }

        public async Task<List<SpeciesDto>> GetSpecies()
        {
            var t = await _service.GetAll();
            return t;
        }
    }
}
