using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.Application.Editions;
using Abp.Application.Features;
using VS.DLQ.Editions;
using VS.DLQ.Fish;
using System;

namespace VS.DLQ.EntityFrameworkCore.Seed.Host
{
    public class DefaultSpicesCreator
    {
        private readonly DLQDbContext _context;
        private const string Name = "Australian bass";

        public DefaultSpicesCreator(DLQDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var defaultSpecies = _context.Species.IgnoreQueryFilters().FirstOrDefault(e => e.Name.Trim() == Name.Trim());
            if (defaultSpecies == null)
            {
                CreateSpecies();
            }
        }

        private void CreateSpecies()
        {
            _context.Species.AddRange(
                new Species { Name = "Australian bass", URL = "https://www.daf.qld.gov.au/business-priorities/fisheries/species-identification/inshore-estuarine-species/australian-bass", Description = "Australian bass", TimeStamp = DateTime.Now },
                new Species { Name = "Barcoo grunter", URL = "https://www.daf.qld.gov.au/business-priorities/fisheries/species-identification/freshwater-fish/barcoo-grunter", Description = "Barcoo grunter", TimeStamp = DateTime.Now },
                new Species { Name = "Barramundi", URL = "https://www.daf.qld.gov.au/business-priorities/fisheries/species-identification/inshore-estuarine-species/barramundi", Description = "Barramundi", TimeStamp = DateTime.Now },
                new Species { Name = "Bloomfield river cod", URL = "https://www.daf.qld.gov.au/business-priorities/fisheries/species-identification/freshwater-fish/bloomfield-river-cod", Description = "Bloomfield river cod", TimeStamp = DateTime.Now },
                new Species
                {
                    Name = "Freshwater catfish(eel tailed catfish)",
                    URL = "https://www.daf.qld.gov.au/business-priorities/fisheries/species-identification/freshwater-fish/freshwater-catfish-eel-tailed-catfish",
                    Description = "Freshwater catfish(eel tailed catfish)",
                    TimeStamp = DateTime.Now
                },
                new Species { Name = "Freshwater sawfish", URL = "https://www.daf.qld.gov.au/business-priorities/fisheries/species-identification/shark-identification-guide/photo-guide-to-sharks/sharks,-part-3/freshwater-sawfish", Description = "Freshwater sawfish", TimeStamp = DateTime.Now },
                new Species { Name = "Golden perch(yellowbelly)", URL = "https://www.daf.qld.gov.au/business-priorities/fisheries/species-identification/freshwater-fish/golden-perch-yellowbelly", Description = "Golden perch(yellowbelly)", TimeStamp = DateTime.Now },
                new Species { Name = "Jungle perch", URL = "https://www.daf.qld.gov.au/business-priorities/fisheries/species-identification/freshwater-fish/jungle-perch", Description = "Jungle perch", TimeStamp = DateTime.Now },
                new Species { Name = "Khaki grunter", URL = "https://www.daf.qld.gov.au/business-priorities/fisheries/species-identification/freshwater-fish/khaki-grunter", Description = "Khaki grunter", TimeStamp = DateTime.Now },
                new Species { Name = "Longfin eel", URL = "https://www.daf.qld.gov.au/business-priorities/fisheries/species-identification/freshwater-fish/longfin-eel", Description = "Longfin eel", TimeStamp = DateTime.Now }
                );
            _context.SaveChanges();
        }
    }
}
