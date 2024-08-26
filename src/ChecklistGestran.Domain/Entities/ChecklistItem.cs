using System;

namespace ChecklistGestran.Domain.Entities;

public class ChecklistItem : BaseEntity
{
    public bool Checked { get; set; }
}
