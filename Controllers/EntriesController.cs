using ApiPrueba.Business;
using ApiPrueba.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiPrueba.Controllers
{
    [ApiController]
    [Route("EntriesController")]
    public class EntriesController : ControllerBase
    {
        private EntriesService _entriesService;
        private readonly EntriesBLL _entriesBLL;
        private readonly ILogger<EntriesController> _logger;

        public EntriesController(EntriesService entriesService, ILogger<EntriesController> logger)
        {
            _entriesService = entriesService;
            _entriesBLL = new EntriesBLL(_entriesService);
            _logger = logger;
        }

        [HttpGet]
        [Route("GetEntriesByHTTPS")]
        public async Task<IActionResult> GetEntriesByHTTPS()
        {
            try
            {
                var result = await _entriesBLL.GetEntriesByHttps();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"GetAllCategorioies Error: {ex.Message}");
                return StatusCode(500);
            }

        }
    }
}
