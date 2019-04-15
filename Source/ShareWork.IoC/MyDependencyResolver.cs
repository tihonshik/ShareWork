using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ShareWork.BLL.Interfaces;
using ShareWork.BLL.Service;
using ShareWork.DAL.Interfaces;
using ShareWork.DAL.Repositories;
using Unity;

namespace ShareWork.IoC
{
    public class MyDependencyResolver : IDependencyResolver
    {
        readonly IUnityContainer _container;

        public MyDependencyResolver()
        {
            _container = new UnityContainer();

            _container.RegisterType<IUnitOfWork, UnitOfWork>();
            _container.RegisterType<IClientService, ClientService>();
            _container.RegisterType<IVerifyOrderService, VerifyOrderService>();
            _container.RegisterType<IOrderService, OrderService>();
            _container.RegisterType<ICategoryService, CategoryService>();
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch
            {
                return null;
            }
        }
    }
}