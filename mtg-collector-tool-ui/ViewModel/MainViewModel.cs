using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace mtg_collector_tool_ui.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            name = "This is a test";
        }

        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
    }
}
