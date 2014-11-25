namespace SearchSampleApp.Bing
{
    using System;

    public partial class Thumbnail {
        
        private String _MediaUrl;
        
        private String _ContentType;
        
        private Int32? _Width;
        
        private Int32? _Height;
        
        private Int64? _FileSize;
        
        public String MediaUrl {
            get {
                return this._MediaUrl;
            }
            set {
                this._MediaUrl = value;
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
    }
}