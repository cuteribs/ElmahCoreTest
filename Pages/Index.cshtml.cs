using ElmahCore;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ElmahCoreTest.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
			_logger.LogTrace("Test LogTrace");
			_logger.LogDebug("Test LogDebug");
			_logger.LogError("Test LogError");
			_logger.LogInformation("Test LogInformation");
			_logger.LogWarning("Test LogWarning");
			_logger.LogCritical(new InvalidOperationException("Test InvalidOperationException"), "Test LogCritical");

			this.HttpContext.RaiseError(new Exception("Test ElmahExtensions.RaiseError"));

			var r = 0;
			var d = 100 / r;
		}
	}
}