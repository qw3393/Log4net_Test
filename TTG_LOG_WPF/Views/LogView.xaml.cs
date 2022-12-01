﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TTG_LOG_WPF.ViewModels;

namespace TTG_LOG_WPF.Views
{
    /// <summary>
    /// LogView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LogView : UserControl
    {
        public LogView()
        {
            InitializeComponent();
            LogViewModel logViewModel = new LogViewModel();
            logViewModel.LOGINFO();
        }
    }
}
