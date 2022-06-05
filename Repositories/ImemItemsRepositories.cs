using System;
using System.Collections.Generic;
using System.Linq;
using VastInvemtory.Entities;

namespace VastInventory.Repositories
{
    public record item
    {
        private readonly List<Item> items = new()
        {
            new Item {
                Id = Guid.NewGuid(),
                Name = "Item 1",
                Description = "Item 1 Description",
                Image = "https://via.placeholder.com/150",
                Created = DateTimeOffset.Now();
            },
            new Item {
                Id = Guid.NewGuid(),
                Name = "Item 2",
                Description = "Item 2 Description",
                Image = "https://via.placeholder.com/150",
                Created = DateTimeOffset.Now();
            },
            new Item {
                Id = Guid.NewGuid(),
                Name = "Item 3",
                Description = "Item 3 Description",
                Image = "https://via.placeholder.com/150",
                Created = DateTimeOffset.Now();
            },
            new Item {
                Id = Guid.NewGuid(),
                Name = "Item 4",
                Description = "Item 4 Description",
                Image = "https://via.placeholder.com/150",
                Created = DateTimeOffset.Now();
            },
            new Item {
                Id = Guid.NewGuid(),
                Name = "Item 5",
                Description = "Item 5 Description",
                Image = "https://via.placeholder.com/150",
                Created = DateTimeOffset.Now();
            },
            new Item {
                Id = Guid.NewGuid(),
                Name = "Item 6",
                Description = "Item 6 Description",
                Image = "https://via.placeholder.com/150",
                Created = DateTimeOffset.Now();
            },
            new Item {
                Id = Guid.NewGuid(),
                Name = "Item 7",
                Description = "Item 7 Description",
                Image = "https://via.placeholder.com/150",
                Created = DateTimeOffset.Now();
            },
            new Item {
                Id = Guid.NewGuid(),
                Name = "Item 8",
                Description = "Item 8 Description",
                Image = "https://via.placeholder.com/150",
                Created = DateTimeOffset.Now();
            },
            new Item {
                Id = Guid.NewGuid(),
                Name = "Item 9",
                Description = "Item 9 Description",
                Image = "https://via.placeholder.com/150",
                Created = DateTimeOffset.Now();
            },
            new Item {
                Id = Guid.NewGuid(),
                Name = "Item 10",
                Description = "Item 10 Description",
                Image = "https://via.placeholder.com/150",
                Created = DateTimeOffset.Now();
            }
        };
        public IEnumerable<Item> GetAll() => items;

        public Item GetById(Guid id) => items.Where(item => item.Id == id).SingleOrDefault();

        public void Add(Item item) => items.Add(item);

        public void Delete(Item item) => items.Remove(item);

        public void Update(Item item) => {
            var itemToUpdate = items.Where(i => i.Id == item.Id).SingleOrDefault();
            items.Remove(itemToUpdate);
            items.Add(item);
        };
    };
}