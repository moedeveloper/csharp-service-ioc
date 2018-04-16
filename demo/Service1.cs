using System;
using System.ServiceProcess;
using Microsoft.Practices.Unity;
using DependencyResolver;
using BLL;

namespace demo
{
    public partial class Service1 : ServiceBase
    {
        private IUnityContainer container;
        public Service1(IUnityContainer container)
        {
            InitializeComponent();
            this.container = container;
        }

        public void OnDebug()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            Console.WriteLine("i am starting the service");
            container.BuildUp(new UnityServiceFactory());

            // Ugly solution but will try to find better!
            var service = this.container.Resolve<Node>();
            var rest = service.ResturnString();
            Console.WriteLine(rest + "result from return string");
        }



        protected override void OnStop()
        {
        }

    }
}
