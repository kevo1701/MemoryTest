using System.Windows.Input;

namespace MemoryTest.ViewModels
{
    public class MainWindowViewModel
    {
        public DelegateCommand PlayCommand { get; set; }
        public DelegateCommand ExitCommand { get; set; }

        public MainWindowViewModel()
        {
            PlayCommand = new DelegateCommand(Play);
            ExitCommand = new DelegateCommand(Exit);
        }

        private void Play(object sender)
        {
            NavigationHelper.NavigateTo(typeof(GameWindow), (MainWindow)sender);
        }

        private void Exit(object sender)
        {
            MainWindow mainWindow = (MainWindow)sender;
            mainWindow.Close();
        }
    }
}
