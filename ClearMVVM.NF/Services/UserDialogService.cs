using System.Windows;
using ClearMVVM.NF.Services.Interfaces;

namespace ClearMVVM.NF.Services
{
    internal class UserDialogService : IUserDialog
    {
        public void Information(string title, string message) =>
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);

        public void Warning(string title, string message) =>
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Warning);

        public void Error(string title, string message) =>
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Error);
    }
}
