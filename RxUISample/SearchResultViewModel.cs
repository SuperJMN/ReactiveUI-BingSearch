namespace SearchSampleApp
{
    using System;

    using ReactiveUI;

    public class SearchResultViewModel : ReactiveObject
    {
        private readonly SearchResult searchResult;

        public SearchResultViewModel(SearchResult searchResult)
        {
            this.searchResult = searchResult;

            this.OpenUrlCommand = ReactiveCommand.Create();
            this.OpenUrlCommand.Subscribe(_ => this.OpenUrl(searchResult.Url) );
        }

        private void OpenUrl(Uri url)
        {
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url.ToString();
            System.Diagnostics.Process.Start(psi);
        }

        public string Title
        {
            get { return this.searchResult.Title; }
        }

        public string Description
        {
            get { return this.searchResult.Description; }
        }

        public Uri Url
        {
            get { return this.searchResult.Url; }
        }

        public string DisplayUrl
        {
            get { return this.searchResult.DisplayUrl; }
        }

        public ReactiveCommand<object> OpenUrlCommand { get; private set; }
    }
}