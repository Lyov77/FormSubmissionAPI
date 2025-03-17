using FormSubmission.Core.Models;
using FormSubmission.DAL.Repositories;


namespace FormSubmission.BLL.Services
{
    public class FormSubmissionService : IFormSubmissionService
    {
        private readonly FormSubmissionRepository _repository;

        public FormSubmissionService(FormSubmissionRepository repository)
        {
            _repository = repository;
        }

        public void SubmitForm(FormSubmissionModel submission)
        {
            _repository.Add(submission);
            Console.WriteLine("Form submitted: " + submission.FormName);
        }

        public IEnumerable<FormSubmissionModel> GetAllSubmissions()
        {
            return _repository.GetAll();
        }

        public IEnumerable<FormSubmissionModel> SearchSubmissions(string keyword)
        {
            return _repository.Search(keyword);
        }
    }
}
