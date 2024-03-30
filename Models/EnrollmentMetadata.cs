using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolmanagementAPP.mvc.Data;
public class EnrollmentMetadata{

[Display(Name="Student ID")]
public int? StudentId { get; set; }
[Display(Name="Class ID")]
public int? ClassId { get; set; }
   

}
[ModelMetadataType(typeof(EnrollmentMetadata))]
 public partial class Enrollment();