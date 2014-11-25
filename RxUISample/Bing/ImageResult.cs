namespace SearchSampleApp.Bing
{
    using System;

    public partial class ImageResult {
        
        private Guid _ID;
        
        private String _Title;
        
        private String _MediaUrl;
        
        private String _SourceUrl;
        
        private String _DisplayUrl;
        
        private Int32? _Width;
        
        private Int32? _Height;
        
        private Int64? _FileSize;
        
        private String _ContentType;
        
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
        
        public String SourceUrl {
            get {
                return this._SourceUrl;
            }
            set {
                this._SourceUrl = value;
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
        
        public Int32? Width {
            get {
                return this._Width;
            }
            set {
                this._Width = value;
            }
        }
        
        public Int32? Height {
            get {
                return this._Height;
            }
            set {
                this._Height = value;
            }
        }
        
        public Int64? FileSize {
            get {
                return this._FileSize;
            }
            set {
                this._FileSize = value;
            }
        }
        
        public String ContentType {
            get {
                return this._ContentType;
            }
            set {
                this._ContentType = value;
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