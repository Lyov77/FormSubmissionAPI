using System.Text.Json;


namespace FormSubmission.Core.Models

{
    public class FormSubmissionModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FormName { get; set; } 
        public Dictionary<string, object> Fields { get; set; } = new Dictionary<string, object>();
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    }
}
