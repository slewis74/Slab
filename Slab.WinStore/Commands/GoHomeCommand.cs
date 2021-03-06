﻿using Slab.Messages;
using Slew.PresentationBus;
using Slab.ViewModels;

namespace Slab.WinStore.Commands
{
    public class GoHomeCommand : Command
    {
        private readonly IPresentationBus _presentationBus;

        public GoHomeCommand(IPresentationBus presentationBus)
        {
            _presentationBus = presentationBus;
        }

        public override void Execute(object parameter)
        {
            _presentationBus.PublishAsync(new GoHomeRequest());
        }
    }
}