﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using EuroFin.BusinessLayer;
using EuroFin.DataLayer;
using EuroFinService.Resolver;
using IComponent = EuroFinService.Resolver.IComponent;

namespace EuroFinService
{
    /// <summary>
    /// Dependency Resolver Class.
    /// </summary>
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        /// <summary>
        /// Dependency Resolver Class Setup Method.
        /// </summary>
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<IBusinessLayer, BusinessLayer>();
            registerComponent.RegisterType<IDataLayer, DataLayer>();            

        }
    }
}