using Orchestra.Shell.Services;
using RibbonApp1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RibbonApp1.Services
{
    public class RibbonService : IRibbonService
    {
        public FrameworkElement GetMainView()
        {
            return new MainView();
        }

        public FrameworkElement GetRibbon()
        {
            return new RibbonView();
        }

        public FrameworkElement GetStatusBar()
        {
            return new StatusBarView();
        }
    }
}
