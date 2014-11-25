namespace SearchSampleApp.Bing
{
    using System;

    public partial class RelatedSearchResult {
        
        private Guid _ID;
        
        private String _Title;
        
        private String _BingUrl;
        
        public Guid ID {
            get {
                return this._ID;
            }
            set {
                this._ID = value;
            }
        }
        
        public String Title {
            get {
                return this._Title;
            }
            set {
                this._Title = value;
            }
        }
        
        public String BingUrl {
            get {
                return this._BingUrl;
            }
            set {
                this._BingUrl = value;
            }
        }
    }
}