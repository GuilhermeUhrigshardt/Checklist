using System;

namespace ChecklistGestran.Domain.Entities;

public abstract class BaseEntity
{
    protected DateTime? InsertedDate { get; set; } = DateTime.Now;
    protected DateTime? UpdatedDate { get; set; }
    protected bool Active { get; set; } = true;
    protected int Version { get; set; } = 1;
}
