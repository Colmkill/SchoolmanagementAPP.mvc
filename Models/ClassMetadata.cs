using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolmanagementAPP.mvc.Data;
 public class ClassMetadata{
  [Display(Name="Lectuer ID")]
 public int? LecturerId { get; set; }
  [Display(Name="Course ID")]
    public int? CourseId { get; set; }
 }
 [ModelMetadataType(typeof(ClassMetadata))]
 public partial class Class();