using System;
using System.Collections.Generic;

namespace SchoolmanagementAPP.mvc.Data;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly? DataOfBirth { get; set; }
}
