﻿using System;
using System.Collections.Generic;
using System.Linq;
using Serilog;

namespace Slab.Pages
{
    public class ControllerLocator : IControllerLocator
    {
        private readonly IControllerFactory _controllerFactory;
        private readonly IEnumerable<Type> _registeredControllerTypes;

        public ControllerLocator(
            IControllerFactory controllerFactory,
            IEnumerable<IController> registeredControllers)
        {
            _controllerFactory = controllerFactory;
            _registeredControllerTypes = registeredControllers.Select(c => c.GetType());
        }

        public object Create(string controllerPrefix)
        {
            var controllerTypes = _registeredControllerTypes
                .Where(ct => ct.Name.Replace("Controller", string.Empty) == controllerPrefix)
                .ToArray();

            if (controllerTypes.Count() > 1)
            {
                throw new InvalidOperationException(string.Format("Ambiguous controller name {0}", controllerPrefix));
            }

            var controllerType = controllerTypes.Single();
            Log.Information("Creating controller {controllerType}", controllerType);

            var instance = _controllerFactory.Create(controllerType);
            return instance;
        }
    }
}