using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgSim.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public DelegateCommand Sum { get; private set; }
        public DelegateCommand Eldontes { get; private set; }
        public DelegateCommand Kivalasztas { get; private set; }
        public DelegateCommand Kereses { get; private set; }
        public DelegateCommand Megszamolas { get; private set; }

        public EventHandler MenuClicked;


        public MainViewModel() 
        {
            Sum = new DelegateCommand(parameter => OnMenuClicked("Sum"));
            Eldontes = new DelegateCommand(parameter => OnMenuClicked("Eldontes"));
            Kivalasztas = new DelegateCommand(parameter => OnMenuClicked("Kivalasztas"));
            Kereses = new DelegateCommand(parameter => OnMenuClicked("Kereses"));
            Megszamolas = new DelegateCommand(parameter => OnMenuClicked("Megszamolas"));
        }

        private void OnMenuClicked(string type_clicked)
        {
            MenuClicked?.Invoke(type_clicked, EventArgs.Empty);
            
        }
    }
}
