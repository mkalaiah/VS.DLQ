using DLQMobileApp.Interfaces;
using DLQMobileApp.Models;
using DLQMobileApp.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DLQMobileApp.ViewModels
{
    public class RulesViewModel
    {
        private readonly IRulesService _service;

        public RulesViewModel()
        {
            _service = ServiceContainer.Resolve<IRulesService>();
        }

        public async Task<List<RuleDto>> GetRules()
        {
            var t =  await _service.GetAll();
            return t;
        }
    }
}
