using DLQMobileApp.Interfaces;
using DLQMobileApp.Models;
using DLQMobileApp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

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

        public void SubmitQuestion (CreateQueryDto question)
        {
            var result = _service.Create(question).Result;

            if (result.Equals("success"))
            {
                SaveSuccess = true;
            } else
            {
                SaveSuccess = false;
            }
        }
    }
}
