namespace SearchSampleApp.Bing
{
    using System;

    public partial class NewsResult {
        
        private Guid _ID;
        
        private String _Title;
        
        private String _Url;
        
        private String _Source;
        
        private String _Description;
        
        private DateTime? _Date;
        
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
        
        public String Url {
            get {
                return this._Url;
            }
            set {
                this._Url = value;
            }
        }
        
        public String Source {
            get {
                return this._Source;
            }
            set {
                this._Source = value;
            }
        }
        
        public String Description {
            get {
                return this._Description;
            }
            set {
                this._Description = value;
            }
        }
        
        public DateTime? Date {
            get {
                return this._Date;
            }
            set {
                this._Date = value;
            }
        }
    }
}