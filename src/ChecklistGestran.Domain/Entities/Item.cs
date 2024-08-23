using System;

namespace ChecklistGestran.Entities.Domain;

public class Item
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}
