namespace SearchSampleApp
{
    using ReactiveUI;

    public class AppKeyViewModel : ReactiveObject
    {
        public AppKeyViewModel(string currentKey)
        {
            this.AppKey = currentKey;
        }

        public string AppKey { get; set; }
    }
}