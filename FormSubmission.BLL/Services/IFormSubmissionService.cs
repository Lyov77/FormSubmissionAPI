using FormSubmission.Core.Models;

namespace FormSubmission.BLL.Services
{
    public interface IFormSubmissionService
    {
        void SubmitForm(FormSubmissionModel submission);
        IEnumerable<FormSubmissionModel> GetAllSubmissions();
        IEnumerable<FormSubmissionModel> SearchSubmissions(string keyword);
    }
}
