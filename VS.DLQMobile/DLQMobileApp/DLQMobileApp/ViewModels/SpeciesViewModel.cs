using DLQMobileApp.Interfaces;
using DLQMobileApp.Models;
using DLQMobileApp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLQMobileApp.ViewModels
{
    public class SpeciesViewModel
    {
        private readonly ISpeciesService _service;

        public SpeciesViewModel ()
        {
            _service = ServiceContainer.Resolve<ISpeciesService>();
        }

        public List<SpeciesDto> GetRules()
        {
            var t = _service.GetAll().Result;
            return t;
        }
    }
}
