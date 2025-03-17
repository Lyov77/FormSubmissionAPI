using FormSubmission.Core.Models;

namespace FormSubmission.DAL.Repositories
{
    public class FormSubmissionRepository
    {
        private readonly List<FormSubmissionModel> _submissions = new();

        // Add method to add submissions to the list
        public void Add(FormSubmissionModel submission)
        {
            if (submission != null)
            {
                // Log the Fields dictionary to check if it has data
                Console.WriteLine($"Form fields for {submission.FormName}: {string.Join(", ", submission.Fields.Select(kv => $"{kv.Key}: {kv.Value}"))}");

                _submissions.Add(submission);
                Console.WriteLine($"Form added: {submission.FormName}, ID: {submission.Id}");
            }
            else
            {
                Console.WriteLine("Error: Submitted form is null");
            }
        }


        public IEnumerable<FormSubmissionModel> GetAll()
        {
            Console.WriteLine($"Repository has {_submissions.Count} submissions.");
            return _submissions;
        }

        public IEnumerable<FormSubmissionModel> Search(string keyword)
        {
            return _submissions.Where(s =>
                s.FormName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                s.Fields.Values.Any(v => v.ToString()?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true));
        }
    }
}
