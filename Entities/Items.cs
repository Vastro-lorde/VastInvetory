using System;
namespace VastInventory.Entities
{
    public record item
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public string Image { get; init; }
        public DateTimeOffset Created { get; set; }
    }
}