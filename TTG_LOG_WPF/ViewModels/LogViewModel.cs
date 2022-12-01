using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using log4net;
using TTG_LOG_WPF.Logging;
using System.Windows.Input;
using TTG_LOG_WPF.Models;

namespace TTG_LOG_WPF.ViewModels
{
    public class LogViewModel : ViewModelBase
    {
        private ICommand _updateLogCommand;
        public LogViewModel()
        {
            WriteToLog();
        }

        public void LOGINFO()
        {
            if (_updateLogCommand == null)
                _updateLogCommand = new RelayCommand(() => WriteToLog());
        }
        private void WriteToLog()
        {
            Log.Write(LogLevel.Info, "HI");
        }
    }
}
