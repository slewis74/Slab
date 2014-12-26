using Slew.PresentationBus;

namespace Slab.Requests
{
    public class PageNavigationRequest : PresentationRequest
    {
        public PageNavigationRequest(string route, PageNavigationRequestEventArgs args)
        {
            Route = route;
            Args = args;
        }

        public string Route { get; set; }
        public PageNavigationRequestEventArgs Args { get; set; }
    }
}