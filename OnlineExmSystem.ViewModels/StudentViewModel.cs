using Microsoft.AspNetCore.Http;
using OnlineExamSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.ViewModels
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            

        }
        public int Id { get; set; }
        [Required]
        [Display(Name = "Student Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }
        [Display(Name = "CV")]
        public string CVFileName { get; set; }
        public string PrctureFileName { get; set; }
        public int GroupsId { get; set; }
        public IFormFile PictureFile { get; set; }
        public IFormFile CVFile { get; set; }
        public int TotalCount { get; set; }
        public List<StudentViewModel> StudentList { get; set; }

        public StudentViewModel(Students model) 
        {
            Id = model.Id;
            Name = model.Name ?? "";
            UserName = model.UserName;
            Password = model.Password; 
            ContactNo = model.ContactNo ?? "";
            CVFileName = model.CVFileName ?? "";
            PrctureFileName = model.PrctureFileName ?? "";
            GroupsId = model.GroupsId;
        }

        public Students ConvertViewModel(StudentViewModel vm)
        {
            return new Students
            {
                Id = vm.Id,
                Name = vm.Name ?? "",
                UserName = vm.UserName,
                Password = vm.Password,
                ContactNo = vm.ContactNo ?? "",
                CVFileName = vm.CVFileName ?? "",
                PrctureFileName = vm.PrctureFileName ?? "",
                GroupsId = vm.GroupsId
             };
        }
    }
}
