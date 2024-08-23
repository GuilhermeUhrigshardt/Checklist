using System;

namespace ChecklistGestran.Domain;

public class Supervisor : Person
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }

    public override bool AreDatesValid() => Start < End;
    public override bool IsActive() => DateTime.Today > Start && DateTime.Today < End;
}
