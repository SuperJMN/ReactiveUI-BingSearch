namespace SearchSampleApp.Bing
{
    using System;

    public partial class WebResult {
        
        private Guid _ID;
        
        private String _Title;
        
        private String _Description;
        
        private String _DisplayUrl;
        
        private String _Url;
        
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
        
        public String Description {
            get {
                return this._Description;
            }
            set {
                this._Description = value;
            }
        }
        
        public String DisplayUrl {
            get {
                return this._DisplayUrl;
            }
            set {
                this._DisplayUrl = value;
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
    }
}