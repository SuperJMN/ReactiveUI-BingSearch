namespace SearchSampleApp.Bing
{
    using System;

    public partial class SpellResult {
        
        private Guid _ID;
        
        private String _Value;
        
        public Guid ID {
            get {
                return this._ID;
            }
            set {
                this._ID = value;
            }
        }
        
        public String Value {
            get {
                return this._Value;
            }
            set {
                this._Value = value;
            }
        }
    }
}