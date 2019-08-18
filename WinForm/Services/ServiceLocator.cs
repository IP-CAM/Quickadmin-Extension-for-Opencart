using Service;
using Service.Mailing;
using System;
using System.Collections.Generic;

namespace UI.Services
{
    internal class ServiceLocator
    {
        public static ServiceLocator Default
        {
            get
            {
                if (instance == null)
                    instance = new ServiceLocator();
                return instance;
            }
        }

        private static ServiceLocator instance;

        private readonly IDictionary<Type, object> services;

        private ServiceLocator()
        {
            services = new Dictionary<Type, object>
            {
                { typeof(PrintingService), new PrintingService() },
                { typeof(MailingService), new MailingService(Properties.Settings.Default.eHost, Properties.Settings.Default.ePort) }
            };
        }

        public T GetService<T>()
        {
            try {
                return (T)services[typeof(T)];
            }
            catch (KeyNotFoundException) {
                throw new ApplicationException("The requested service is not registered");
            }
        }
    }
}
