using System;
using System.Collections.Generic;
using System.Text;

namespace DLQMobileApp.ViewModels
{
    public class RulesDetailsViewModel
    {
        public class WebObject
        {
            public string Title = "";
            public string RuleURL = "";
        }

        public static WebObject webObject = new WebObject();
    }
}
