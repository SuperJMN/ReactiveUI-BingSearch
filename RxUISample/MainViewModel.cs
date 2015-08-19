
namespace SearchSampleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reactive.Linq;
    using System.Threading.Tasks;
    using ReactiveUI;

    public class MainViewModel : ReactiveObject
    {
        private readonly IWebSearchService _searchService;
        private bool _isExecuting;
        private string _searchText;

        public MainViewModel(IWebSearchService searchService)
        {
            _searchService = searchService;
            var searchTextObservable = this.ObservableForProperty(model => model.SearchText)
                .Throttle(TimeSpan.FromMilliseconds(500), RxApp.MainThreadScheduler);

            searchTextObservable.Select(async textChange => await Search(textChange.Value))
                .Switch()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(SetSearchResults);
        }

        private async Task<IEnumerable<SearchResult>> Search(string query)
        {
            IsExecuting = true;
            var results = await Task.Factory.StartNew(() => _searchService.Search(query));
            IsExecuting = false;
            return results;
        }

        public bool IsExecuting
        {
            get { return _isExecuting; }
            set
            {
                this.RaiseAndSetIfChanged(ref _isExecuting, value);
            }
        }

        private void SetSearchResults(IEnumerable<SearchResult> results)
        {
            SearchResults = results.Select(r => new SearchResultViewModel(r));
        }

        public IEnumerable<SearchResultViewModel> SearchResults
        {
            get { return _searchResults; }
            set
            {
                this.RaiseAndSetIfChanged(ref _searchResults, value);
            }
        }

        private IEnumerable<SearchResultViewModel> _searchResults;

        public string SearchText
        {
            get { return _searchText; }
            set
            {
                this.RaiseAndSetIfChanged(ref _searchText, value);
            }
        }
    }
}