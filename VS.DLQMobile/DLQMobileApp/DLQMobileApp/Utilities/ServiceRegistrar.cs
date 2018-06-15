using DLQMobileApp.DataServices;
using DLQMobileApp.Interfaces;
using DLQMobileApp.ViewModels;

namespace DLQMobileApp.Utilities
{
    public static class ServiceRegistrar
    {
        public static void Startup()
        {
            //Services
            ServiceContainer.Register<IRulesService>(() => new RulesService());
            ServiceContainer.Register<ISpeciesService>(() => new SpeciesService());
            ServiceContainer.Register<IAskQuestionService>(() => new AskQuestionService());
            ServiceContainer.Register<IReportIllegalActivityService>(() => new ReportIllegalActivityService());
            ServiceContainer.Register<IReportIssueService>(() => new ReportIssueService());


            //ViewModels
            ServiceContainer.Register<RulesViewModel>();
            ServiceContainer.Register<SpeciesViewModel>();
            ServiceContainer.Register<AskQuestionViewModel>();
            ServiceContainer.Register<ReportIllegalActivtyViewModel>();
            ServiceContainer.Register<ReportIssueViewModel>();
        }
    }
}
