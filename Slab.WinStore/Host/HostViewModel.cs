using Slab.Data;
using Slab.Pages;
using Slab.PresentationBus;
using Slab.WinStore.Commands;
using Slab.WinStore.Data.Navigation;
using Slab.WinStore.Pages;
using Slab.WinStore.Pages.Navigation;

namespace Slab.WinStore.Host
{
    public class HostViewModel : BindableBase
    {
        public IPresentationBus PresentationBus { get; set; }
        public IRtNavigator Navigator { get; set; }
        public IViewLocator ViewLocator { get; set; }
        public INavigationStackStorage NavigationStackStorage { get; set; }
        public IControllerInvoker ControllerInvoker { get; set; }
        public GoBackCommand Back { get; set; }
    }
}