using ApiPrueba.Model;
using ApiPrueba.Services;

namespace ApiPrueba.Business
{
    public  class EntriesBLL
    {

        private readonly EntriesService _entriesService;
        public EntriesBLL(EntriesService entriesService)
        {
            _entriesService = entriesService;
        }

        public async Task<List<Entries>> GetEntriesByHttps()
        {
            var resultEntries = await _entriesService.GetEntries();
               
            return resultEntries.entries.Where(x => x.HTTPS == true || x.HTTPS == false).ToList();
        }

        public async Task<IEnumerable<string>> GetEntriesByCategoria()
        {
            var resultEntries = await _entriesService.GetEntries();

            return resultEntries.entries.Select(e => e.Category).Distinct();
        }

    }
}
