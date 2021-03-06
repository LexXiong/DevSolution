﻿using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Autofac;
using Autofac.Core;
using Boying.Environment;
using Boying.Environment.Configuration;
using Boying.Environment.ShellBuilders;

namespace Boying.Wcf
{
    public class BoyingServiceHostFactory : ServiceHostFactory, IShim
    {
        public BoyingServiceHostFactory()
        {
            BoyingHostContainerRegistry.RegisterShim(this);
        }

        public IBoyingHostContainer HostContainer { get; set; }

        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
        {
            IComponentRegistration registration;
            if (constructorString == null)
            {
                throw new ArgumentNullException("constructorString");
            }

            if (constructorString == string.Empty)
            {
                throw new ArgumentOutOfRangeException("constructorString");
            }

            if (HostContainer == null)
            {
                throw new InvalidOperationException();
            }

            // Create work context
            IRunningShellTable runningShellTable = HostContainer.Resolve<IRunningShellTable>();
            ShellSettings shellSettings = runningShellTable.Match(baseAddresses.First().Host, baseAddresses.First().LocalPath);

            IBoyingHost BoyingHost = HostContainer.Resolve<IBoyingHost>();
            ShellContext shellContext = BoyingHost.GetShellContext(shellSettings);
            IWorkContextAccessor workContextAccessor = shellContext.LifetimeScope.Resolve<IWorkContextAccessor>();
            WorkContext workContext = workContextAccessor.GetContext();
            if (workContext == null)
            {
                using (IWorkContextScope workContextScope = workContextAccessor.CreateWorkContextScope())
                {
                    ILifetimeScope lifetimeScope = workContextScope.Resolve<ILifetimeScope>();
                    registration = GetRegistration(lifetimeScope, constructorString);
                }
            }
            else
            {
                ILifetimeScope lifetimeScope = workContext.Resolve<ILifetimeScope>();
                registration = GetRegistration(lifetimeScope, constructorString);
            }

            if (registration == null)
            {
                throw new InvalidOperationException();
            }

            if (!registration.Activator.LimitType.IsClass)
            {
                throw new InvalidOperationException();
            }

            return CreateServiceHost(workContextAccessor, registration, registration.Activator.LimitType, baseAddresses);
        }

        private ServiceHost CreateServiceHost(IWorkContextAccessor workContextAccessor, IComponentRegistration registration, Type implementationType, Uri[] baseAddresses)
        {
            ServiceHost host = CreateServiceHost(implementationType, baseAddresses);

            host.Opening += delegate
            {
                host.Description.Behaviors.Add(new BoyingDependencyInjectionServiceBehavior(workContextAccessor, implementationType, registration));
            };

            return host;
        }

        private IComponentRegistration GetRegistration(ILifetimeScope lifetimeScope, string constructorString)
        {
            IComponentRegistration registration;
            if (!lifetimeScope.ComponentRegistry.TryGetRegistration(new KeyedService(constructorString, typeof(object)), out registration))
            {
                Type serviceType = Type.GetType(constructorString, false);
                if (serviceType != null)
                {
                    lifetimeScope.ComponentRegistry.TryGetRegistration(new TypedService(serviceType), out registration);
                }
            }

            return registration;
        }
    }
}