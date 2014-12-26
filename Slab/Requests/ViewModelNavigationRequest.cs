using Slew.PresentationBus;

namespace Slab.Requests
{
    public class ViewModelNavigationRequest : PresentationRequest
    {
        public ViewModelNavigationRequest(string route, ViewModelNavigationRequestEventArgs args)
        {
            Route = route;
            Args = args;
        }

        public string Route { get; set; }
        public ViewModelNavigationRequestEventArgs Args { get; set; }
    }
}