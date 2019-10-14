using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MemoryTest.ViewModels
{
    public class CardViewModel : BaseNotifyClass
    {
        public int Index { get; }

        private bool _isFlipped;
        public bool IsFlipped
        {
            get => _isFlipped;
            set
            {
                if(_isFlipped != value)
                {
                    _isFlipped = value;
                    OnPropertyChanged(nameof(IsFlipped));
                }
            }
        }

        public bool IsFoundMatch { get; set; }

        private ImageSource _currentImage;
        public ImageSource CurrentImage
        {
            get => _currentImage;
            set
            {
                if(_currentImage != value)
                {
                    _currentImage = value;
                    OnPropertyChanged(nameof(CurrentImage));
                }
            }
        }

        public DelegateCommand ClickCommand { get; set; }

        public CardViewModel(int index)
        {
            Index = index;
            CurrentImage = CardHelper.BackImage;
            ClickCommand = new DelegateCommand(Click);
        }

        private async void Click(object sender)
        {
            if(!IsFlipped && !IsFoundMatch)
            {
                var allCards = (ObservableCollection<CardViewModel>)sender;
                CurrentImage = CardHelper.GetImageByIndex(Index);
   
                var flippedCard = allCards.FirstOrDefault(c => c.IsFlipped == true);
                IsFlipped = true;

                if(flippedCard != null)
                {
                    if (flippedCard.Index == this.Index && !flippedCard.Equals(this))
                    {
                        this.FoundMatch();
                        flippedCard.FoundMatch();
                    }
                    else
                    {
                        foreach (var card in allCards)
                        {
                            card.IsFlipped = true;
                        }
                        await Task.Delay(1000).ContinueWith(task =>
                        {
                            foreach (var card in allCards)
                            {
                                card.IsFlipped = false;
                            }
                        });
                        flippedCard.FlipBack();
                        this.FlipBack();
                    }
                }
                else
                {
                    IsFlipped = true;
                }
            }
        }

        private void FlipBack()
        {
            this.IsFlipped = false;
            this.CurrentImage = CardHelper.BackImage;
        }

        private void FoundMatch()
        {
            this.IsFlipped = false;
            this.IsFoundMatch = true;
        }
    }
}
