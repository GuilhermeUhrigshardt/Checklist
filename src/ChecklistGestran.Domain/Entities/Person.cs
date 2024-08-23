using System;

namespace ChecklistGestran.Entities.Domain;

public abstract class Person
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public DateTime DateOfBirth { get; set; }

    public abstract bool AreDatesValid();
    public abstract bool IsActive();
}
