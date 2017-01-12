﻿using SportsStore.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace SportsStore.Infrastructure.Identity
{
    public class CustomResolver : IDependencyResolver, IDependencyScope
    {
        public IDependencyScope BeginScope()
        {
            return this;
        }

        public void Dispose()
        {
            // do nothing
        }

        public object GetService(Type serviceType)
        {
            return serviceType == typeof(IRepository) ? new ProductRepository() : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Enumerable.Empty<object>();
        }
    }
}