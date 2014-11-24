using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

using ReactiveUI;


namespace RxUISample
{
    using System.Diagnostics;

    public class MainViewModel : ReactiveObject, IMainViewModel
    {
        private readonly IWebSearchService searchService;

        public MainViewModel(IWebSearchService searchService)
        {
            this.searchService = searchService;
            var p = this.ObservableForProperty(model => model.SearchText)
                .Throttle(TimeSpan.FromMilliseconds(300));

            var results = p.Select(change => Search(change.Value));
            var switched = results.Switch();

            switched.ObserveOn(Application.Current)
                .Subscribe(rs => SearchResults = rs.Select(r => new SearchResultViewModel(r)));
        }

        private Task<List<SearchResult>> Search(string query)
        {
            return Task.Factory.StartNew(() => searchService.Search(query).ToList());
        }

        public IEnumerable<SearchResultViewModel> SearchResults
        {
            get { return searchResults; }
            set
            {
                this.RaiseAndSetIfChanged(ref searchResults, value);
            }
        }

        private string searchText;
        private IEnumerable<SearchResultViewModel> searchResults;
        private bool isSearching;

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