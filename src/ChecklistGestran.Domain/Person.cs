using System;

namespace ChecklistGestran.Domain;

public abstract class Person
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }

    public abstract bool AreDatesValid();
    public abstract bool IsActive();
}
