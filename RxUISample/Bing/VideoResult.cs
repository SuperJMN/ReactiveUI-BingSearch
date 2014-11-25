namespace SearchSampleApp.Bing
{
    using System;

    public partial class VideoResult {
        
        private Guid _ID;
        
        private String _Title;
        
        private String _MediaUrl;
        
        private String _DisplayUrl;
        
        private Int32? _RunTime;
        
        private Thumbnail _Thumbnail;
        
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
        
        public String MediaUrl {
            get {
                return this._MediaUrl;
            }
            set {
                this._MediaUrl = value;
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
        
        public Int32? RunTime {
            get {
                return this._RunTime;
            }
            set {
                this._RunTime = value;
            }
        }
        
        public Thumbnail Thumbnail {
            get {
                return this._Thumbnail;
            }
            set {
                this._Thumbnail = value;
            }
        }
    }
}