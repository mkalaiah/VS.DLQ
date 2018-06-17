using DLQMobileApp.Interfaces;
using DLQMobileApp.Models;
using DLQMobileApp.Utilities;
using System.Threading.Tasks;

namespace DLQMobileApp.ViewModels
{
    public class AskQuestionViewModel
    {
        private readonly IAskQuestionService _service;

        public bool SaveSuccess = false;

        public AskQuestionViewModel ()
        {
            _service = ServiceContainer.Resolve<IAskQuestionService>();
        }

        public async Task<bool> SubmitQuestion (CreateQueryDto question)
        {
            var result = await _service.Create(question);

            if (result.Equals("success"))
            {
               return true;
            } else
            {
                return false;
            }
        }
    }
}
