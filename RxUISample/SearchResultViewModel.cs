
namespace SearchSampleApp
{
    using System;
    using System.Diagnostics;
    using ReactiveUI;

    public class SearchResultViewModel : ReactiveObject
    {
        private readonly SearchResult _searchResult;

        public SearchResultViewModel(SearchResult searchResult)
        {
            _searchResult = searchResult;

            OpenUrlCommand = ReactiveCommand.Create();
            OpenUrlCommand.Subscribe(_ => OpenUrl(searchResult.Url) );
        }

        private void OpenUrl(Uri url)
        {
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url.ToString();
            Process.Start(psi);
        }

        public string Title
        {
            get { return _searchResult.Title; }
        }

        public string Description
        {
            get { return _searchResult.Description; }
        }

        public Uri Url
        {
            get { return _searchResult.Url; }
        }

        public string DisplayUrl
        {
            get { return _searchResult.DisplayUrl; }
        }

        public ReactiveCommand<object> OpenUrlCommand { get; private set; }
    }
}