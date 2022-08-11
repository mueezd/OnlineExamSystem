using OnlineExamSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.ViewModels
{
    public class ExamViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Exam Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Exam Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "Exam Time")]
        public int Time { get; set; }
        public int GroupsId { get; set; }

        public List<ExamViewModel> ExamList { get; set; }
        public int TotalCount { get; set; }

        public ExamViewModel(Exams model)
        {
            Id = model.Id;
            Title = model.Title ?? "";
            Description = model.Title ?? "";
            StartDate = model.StartDate;
            Time = model.Time;
            GroupsId = model.GroupsId;
        }
        public Exams ConvertViewModel(ExamViewModel vm)
        {
            return new Exams
            {
                Id = vm.Id,
                Title = vm.Title ?? "",
                Description = vm.Description ?? "",
                StartDate = vm.StartDate,
                Time = vm.Time,
                GroupsId = vm.GroupsId
            };
        }
    }
}
