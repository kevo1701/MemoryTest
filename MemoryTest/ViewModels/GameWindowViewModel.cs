using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace MemoryTest.ViewModels
{
    public class GameWindowViewModel : BaseNotifyClass
    {
        private Random _random;
        private DispatcherTimer _timer;
        
        public DelegateCommand BackCommand { get; set; }
        public DelegateCommand RestartCommand { get; set; }

        public ObservableCollection<CardViewModel> Cards { get; set; }

        private int _elapsedTime;

        public int ElapsedTime
        {
            get => _elapsedTime;
            set
            {
                if (_elapsedTime != value)
                {
                    _elapsedTime = value;
                    OnPropertyChanged(nameof(TimerText));
                }
            }
        }

        public string TimerText => ElapsedTime + "s";

        public GameWindowViewModel()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(1000);
            _timer.Tick += Timer_Tick;
            _timer.Start();

            BackCommand = new DelegateCommand(Back);
            RestartCommand = new DelegateCommand(Restart);

            Cards = new ObservableCollection<CardViewModel>();
            for (int i = 0; i < 16; i++)
            {
                Cards.Add(new CardViewModel((i%8) + 1));
            }

            _random = new Random();
            Shuffle(Cards);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ElapsedTime++;        
            Win();
        }

        private void Back(object sender)
        {
            NavigationHelper.NavigateTo(typeof(MainWindow), (GameWindow)sender);
        }

        private void Restart(object sender)
        {
            NavigationHelper.NavigateTo(typeof(GameWindow), (GameWindow)sender);
        }

        private void Shuffle<T>(ObservableCollection<T> array)
        {
            int n = array.Count;
            for (int i = 0; i < n; i++)
            {
                int r = i + _random.Next(n - i);
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }
        private void Win ()
        {
            int count = Cards.Count(c => !c.IsFoundMatch);

            if(count == 0)
            {
                _timer.Stop();
                MessageBox.Show($"You win for {ElapsedTime} seconds ");
            }
        }
    }
}
