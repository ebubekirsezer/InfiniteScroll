using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Extended;
using static InfiniteScroll.DataService;

namespace InfiniteScroll
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private bool _isBusy;
        private const int PageSize = 10;
        readonly DataService dataService = new DataService();

        public event PropertyChangedEventHandler PropertyChanged;

        public InfiniteScrollCollection<Player> Players { get; set; }
            
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            Players = new InfiniteScrollCollection<Player>
            {
                OnLoadMore = async () =>
                 {
                     IsBusy = true;
                     var page = Players.Count / PageSize;
                     var player = await dataService.GetItemAsync(page, PageSize);
                     IsBusy = false;
                     return player;
                 },
                OnCanLoadMore = () =>
                {
                    return Players.Count < 50;
                }
            };
            DownloadDataAsync();
        }
        private async Task DownloadDataAsync()
        {
            var items = await dataService.GetItemAsync(pageIndex: 0, pagesize: PageSize);
            Players.AddRange(items);
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyname=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
