using System;
using Slew.PresentationBus;
using Windows.UI.ApplicationSettings;

namespace Slab.WinStore.Requests
{
    public class DisplaySettingsRequest : PresentationRequest
    {
        public DisplaySettingsRequest(Type viewType, SettingsPaneCommandsRequest commandsRequest)
        {
            ViewType = viewType;
            CommandsRequest = commandsRequest;
            MustBeHandled = true;
        }

        public Type ViewType { get; set; }
        public SettingsPaneCommandsRequest CommandsRequest { get; set; }
    }
}