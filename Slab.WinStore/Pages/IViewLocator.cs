using System.Reflection;
using Windows.UI.Xaml;

namespace Slab.WinStore.Pages
{
    public interface IViewLocator
    {
        void Configure(Assembly assembly, string baseViewModelNamespace, string baseViewNamespace);

        FrameworkElement Resolve(object viewModel, PageLayout pageLayout);
    }
}