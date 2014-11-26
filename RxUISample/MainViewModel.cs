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
        private readonly IWebSearchService searchService;

        private string searchText;

        public MainViewModel(IWebSearchService searchService)
        {
            this.searchService = searchService;
            var searchTextObservable = this.ObservableForProperty(model => model.SearchText)
                .Throttle(TimeSpan.FromMilliseconds(300), RxApp.MainThreadScheduler);

            var resultsForTextObservable = searchTextObservable.Select(textChange => Search(textChange.Value));
            var latestResultsObservable = resultsForTextObservable.Switch();

            latestResultsObservable
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(SetSearchResults);
        }

        private void SetSearchResults(IEnumerable<SearchResult> results)
        {
            SearchResults = results.Select(r => new SearchResultViewModel(r));
        }

        private Task<IEnumerable<SearchResult>> Search(string query)
        {
            return Task.Factory.StartNew(() => searchService.Search(query));
        }

        public IEnumerable<SearchResultViewModel> SearchResults
        {
            get { return searchResults; }
            set
            {
                this.RaiseAndSetIfChanged(ref searchResults, value);
            }
        }

        private IEnumerable<SearchResultViewModel> searchResults;

        public string SearchText
        {
            get { return searchText; }
            set
            {
                this.RaiseAndSetIfChanged(ref searchText, value);
            }
        }
    }
}