namespace SearchSampleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;

    using Bing;

    class BingSearchService : IWebSearchService
    {
        private const string ServiceUrl = @"https://api.datamarket.azure.com/Bing/SearchWeb/v1/Web";

        private readonly BingSearchContainer _bingContainer;


        public BingSearchService(string apiKey)
        {
            _bingContainer = new BingSearchContainer(new Uri(ServiceUrl))
                                {
                                    Credentials = new NetworkCredential(apiKey, apiKey)
                                };
        }

        public IEnumerable<SearchResult> Search(string query)
        {
            List<WebResult> dataServiceQuery = _bingContainer.Web(query, null, null, "es-ES", null, null, null, null).ToList();

            return from result in dataServiceQuery
                   select new SearchResult
                              {
                                  DisplayUrl = result.DisplayUrl,
                                  Description = result.Description,
                                  Title = result.Title,
                                  Url = new Uri(result.Url)
                              };
        }
    }
}