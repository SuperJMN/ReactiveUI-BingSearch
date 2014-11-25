namespace SearchSampleApp.Bing
{
    using System;

    public partial class ExpandableSearchResult {
        
        private Guid _ID;
        
        private Int64? _WebTotal;
        
        private Int64? _WebOffset;
        
        private Int64? _ImageTotal;
        
        private Int64? _ImageOffset;
        
        private Int64? _VideoTotal;
        
        private Int64? _VideoOffset;
        
        private Int64? _NewsTotal;
        
        private Int64? _NewsOffset;
        
        private Int64? _SpellingSuggestionsTotal;
        
        private String _AlteredQuery;
        
        private String _AlterationOverrideQuery;
        
        private System.Collections.ObjectModel.Collection<WebResult> _Web;
        
        private System.Collections.ObjectModel.Collection<ImageResult> _Image;
        
        private System.Collections.ObjectModel.Collection<VideoResult> _Video;
        
        private System.Collections.ObjectModel.Collection<NewsResult> _News;
        
        private System.Collections.ObjectModel.Collection<RelatedSearchResult> _RelatedSearch;
        
        private System.Collections.ObjectModel.Collection<SpellResult> _SpellingSuggestions;
        
        public Guid ID {
            get {
                return this._ID;
            }
            set {
                this._ID = value;
            }
        }
        
        public Int64? WebTotal {
            get {
                return this._WebTotal;
            }
            set {
                this._WebTotal = value;
            }
        }
        
        public Int64? WebOffset {
            get {
                return this._WebOffset;
            }
            set {
                this._WebOffset = value;
            }
        }
        
        public Int64? ImageTotal {
            get {
                return this._ImageTotal;
            }
            set {
                this._ImageTotal = value;
            }
        }
        
        public Int64? ImageOffset {
            get {
                return this._ImageOffset;
            }
            set {
                this._ImageOffset = value;
            }
        }
        
        public Int64? VideoTotal {
            get {
                return this._VideoTotal;
            }
            set {
                this._VideoTotal = value;
            }
        }
        
        public Int64? VideoOffset {
            get {
                return this._VideoOffset;
            }
            set {
                this._VideoOffset = value;
            }
        }
        
        public Int64? NewsTotal {
            get {
                return this._NewsTotal;
            }
            set {
                this._NewsTotal = value;
            }
        }
        
        public Int64? NewsOffset {
            get {
                return this._NewsOffset;
            }
            set {
                this._NewsOffset = value;
            }
        }
        
        public Int64? SpellingSuggestionsTotal {
            get {
                return this._SpellingSuggestionsTotal;
            }
            set {
                this._SpellingSuggestionsTotal = value;
            }
        }
        
        public String AlteredQuery {
            get {
                return this._AlteredQuery;
            }
            set {
                this._AlteredQuery = value;
            }
        }
        
        public String AlterationOverrideQuery {
            get {
                return this._AlterationOverrideQuery;
            }
            set {
                this._AlterationOverrideQuery = value;
            }
        }
        
        public System.Collections.ObjectModel.Collection<WebResult> Web {
            get {
                return this._Web;
            }
            set {
                this._Web = value;
            }
        }
        
        public System.Collections.ObjectModel.Collection<ImageResult> Image {
            get {
                return this._Image;
            }
            set {
                this._Image = value;
            }
        }
        
        public System.Collections.ObjectModel.Collection<VideoResult> Video {
            get {
                return this._Video;
            }
            set {
                this._Video = value;
            }
        }
        
        public System.Collections.ObjectModel.Collection<NewsResult> News {
            get {
                return this._News;
            }
            set {
                this._News = value;
            }
        }
        
        public System.Collections.ObjectModel.Collection<RelatedSearchResult> RelatedSearch {
            get {
                return this._RelatedSearch;
            }
            set {
                this._RelatedSearch = value;
            }
        }
        
        public System.Collections.ObjectModel.Collection<SpellResult> SpellingSuggestions {
            get {
                return this._SpellingSuggestions;
            }
            set {
                this._SpellingSuggestions = value;
            }
        }
    }
}