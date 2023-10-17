using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_LazyTreeNode.ViewModels;
using WPF_LazyTreeNode.Views;

namespace WPF_LazyTreeNode
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainView view = new MainView
            {
                DataContext = new MainViewModel()
            };
            view.Show();
        }
    }
}
