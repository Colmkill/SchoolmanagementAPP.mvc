using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
namespace SchoolmanagementAPP.mvc.Data;

public class StudentMetadata
{
[Display (Name="First Name")]
 public string FirstName { get; set; } = null!;
[Display(Name="Last Name")]
    public string LastName { get; set; } = null!;
[Display(Name="Date Of Birth")]
    public DateOnly? DataOfBirth { get; set; }
}
[ModelMetadataType(typeof(StudentMetadata))]
public partial class Student();


