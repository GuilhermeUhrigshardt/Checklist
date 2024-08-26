using System;

namespace ChecklistGestran.Domain.Entities;

public class Item : BaseEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}
