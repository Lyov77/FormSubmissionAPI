using Microsoft.AspNetCore.Mvc;
using FormSubmission.BLL.Services;
using FormSubmission.Core.Models;


namespace FormSubmissionAPI.Controllers
{
    [ApiController]
    [Route("api/forms")]
    public class FormSubmissionController : ControllerBase
    {
        private readonly IFormSubmissionService _service;

        public FormSubmissionController(IFormSubmissionService service)
        {
            _service = service;
        }

        [HttpPost("submit")]
        public IActionResult Submit([FromBody] FormSubmissionModel submission)
        {
            _service.SubmitForm(submission);
            return Ok(new { message = "Form submitted successfully!" });
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            var submissions = _service.GetAllSubmissions();

            // Log to see what the service is returning
            Console.WriteLine($"Returned {submissions.Count()} submissions.");

            foreach (var submission in submissions)
            {
                Console.WriteLine($"Form ID: {submission.Id}, Fields: {string.Join(", ", submission.Fields.Select(kv => $"{kv.Key}: {kv.Value}"))}");
            }

            return Ok(submissions);
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery] string keyword)
        {
            return Ok(_service.SearchSubmissions(keyword));
        }
    }
}
