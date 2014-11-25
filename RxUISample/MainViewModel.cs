namespace SearchSampleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reactive.Linq;
    using System.Threading.Tasks;
    using System.Windows;

    using ReactiveUI;

    public class MainViewModel : ReactiveObject, IMainViewModel
    {
        private readonly IWebSearchService searchService;

        private string searchText;

        public MainViewModel(IWebSearchService searchService)
        {
            this.searchService = searchService;
            var p = this.ObservableForProperty(model => model.SearchText)
                .Throttle(TimeSpan.FromMilliseconds(300));

            var results = p.Select(change => this.Search(change.Value));
            var switched = results.Switch();

            switched.ObserveOn(Application.Current)
                .Subscribe(rs => this.SearchResults = rs.Select(r => new SearchResultViewModel(r)));
        }

        private Task<List<SearchResult>> Search(string query)
        {
            return Task.Factory.StartNew(() => this.searchService.Search(query).ToList());
        }

        public IEnumerable<SearchResultViewModel> SearchResults
        {
            get { return this.searchResults; }
            set
            {
                this.RaiseAndSetIfChanged(ref this.searchResults, value);
            }
        }

        private IEnumerable<SearchResultViewModel> searchResults;

        public string SearchText
        {
            get { return this.searchText; }
            set
            {
                this.RaiseAndSetIfChanged(ref this.searchText, value);
            }
        }
    }
}