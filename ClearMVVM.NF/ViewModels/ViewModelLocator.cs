using Microsoft.Extensions.DependencyInjection;

namespace ClearMVVM.NF.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => App.Services.GetRequiredService<MainWindowViewModel>();
    }
}
