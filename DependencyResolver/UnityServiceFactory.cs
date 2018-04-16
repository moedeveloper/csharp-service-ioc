using System;
using System.Linq.Expressions;
using Microsoft.Practices.Unity;

namespace DependencyResolver
{
    public  class UnityServiceFactory
    {
        protected IUnityContainer _container;

        public UnityServiceFactory()
        {
            try
            {
                const string path = "./";
                _container = new UnityContainer();
                ComponentLoader.LoadContainer(_container, path, "BLL.dll");
            }
            catch (Exception ex)
            {

            }

        }
    }
}
