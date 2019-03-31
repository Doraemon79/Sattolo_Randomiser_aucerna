using Ninject;
using Randomiser_Aucerna.Model;
using Randomiser_Aucerna.Model.Interfaces;
using Randomiser_Aucerna.ViewModel;
using Randomiser_Aucerna.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Randomiser_Aucerna
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IKernel container;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var container = new StandardKernel();
            // Register types
            container.Bind<IMyValues>().To<MyValues>();
            container.Bind<IRandomiser>().To<Randomiser>();

            //Datacontext
            MainWindow mw = new MainWindow();
            mw.DataContext = container.Get<ViewModelMain>();
            mw.Show();
        }
        private void ComposeObjects()
        {
            Current.MainWindow = this.container.Get<MainWindow>();
        }

        private void ConfigureContainer()
        {
            this.container = new StandardKernel();

        }
    }
}
