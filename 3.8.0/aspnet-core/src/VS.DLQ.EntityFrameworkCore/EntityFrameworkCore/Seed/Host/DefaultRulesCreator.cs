using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VS.DLQ.Rules;

namespace VS.DLQ.EntityFrameworkCore.Seed.Host
{
    public class DefaultRulesCreator
    {
        private readonly DLQDbContext _context;
        private const string Name = "Fishing Equipment";

        public DefaultRulesCreator(DLQDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var defaultRules = _context.Species.IgnoreQueryFilters().FirstOrDefault(e => e.Name.Trim() == Name.Trim());
            if (defaultRules == null)
            {
                CreateRules();
            }
        }

        private void CreateRules()
        {
            _context.Rules.AddRange(
                new Rule { Name = "Fishing Equipment", URL = "https://www.qld.gov.au/recreation/activities/boating-fishing/rec-fishing/rules/equipment", Description = "Fishing Equipment", TimeStamp = DateTime.Now },
                new Rule { Name = "Catch Limits & Closures", URL = "https://www.qld.gov.au/recreation/activities/boating-fishing/rec-fishing/rules/closures", Description = "Catch Limits & Closures", TimeStamp = DateTime.Now },
                new Rule
                {
                    Name = "Size & Possession Limits(Tidal Waters)",
                    URL = "https://www.qld.gov.au/recreation/activities/boating-fishing/rec-fishing/rules/limits-tidal",
                    Description = "Size & Possession Limits(Tidal Waters)",
                    TimeStamp = DateTime.Now
                },

                new Rule
                {
                    Name = "Size & Possession Limits (Fresh Waters)",
                    URL = "https://www.daf.qld.gov.au/business-priorities/fisheries/species-identification/freshwater-fish/bloomfield-river-cod",
                    Description = "Size & Possession Limits (Fresh Waters)",
                    TimeStamp = DateTime.Now
                }
                );
            _context.SaveChanges();
        }
    }
}
