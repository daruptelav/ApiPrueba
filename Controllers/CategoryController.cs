using ApiPrueba.Business;
using ApiPrueba.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiPrueba.Controllers
{
    [ApiController]
    [Route("CategoryController")]
    public class CategoryController: ControllerBase
    {
        private EntriesService _entriesService;
        private readonly EntriesBLL _entriesBLL;
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(EntriesService entriesService, ILogger<CategoryController> logger)
        {
            _entriesService = entriesService;
            _entriesBLL = new EntriesBLL(_entriesService);
            _logger = logger;
        }

        [HttpGet]
        [Route("GetAllCategorioies")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _entriesBLL.GetEntriesByCategoria();

                return Ok(result);
            }
            catch(Exception ex)
            {
                _logger.LogError($"GetAllCategorioies Error: {ex.Message}");
                return StatusCode(500); 
            }

        }
    }
}
