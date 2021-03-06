﻿using System.Threading;
using Slab.Data;

namespace Slab.ViewModels
{
    public abstract class HasPageTitleBase : BindableBase
    {
        protected HasPageTitleBase()
        {}

        protected HasPageTitleBase(SynchronizationContext synchronizationContext) : base(synchronizationContext)
        {}

        public abstract string PageTitle { get; }
    }
}