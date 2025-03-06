using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Navigation.ViewModels
{
    public class HomePageViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string WelcomeMessage
        {
            get { return $"Benvenuto {Name} {LastName}"; }
        }
    }
}
