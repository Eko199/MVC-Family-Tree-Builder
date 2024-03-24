namespace FamilyTreeBuilder.Core.Services;

using Contracts;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Models;

public class PersonService : IPersonService
{
    private readonly FamilyTreeBuilderDbContext context;

    public PersonService(FamilyTreeBuilderDbContext context)
    {
        this.context = context;
    }

    public async Task<PersonShortInfoViewModel?> GetById(int id) 
        => await GetById(new PersonShortInfoViewModel
        {
            Id = id
        });

    private static PersonShortInfoViewModel? SearchForId(PersonShortInfoViewModel mainPerson, int id)
    {
        var people = new Dictionary<int, PersonShortInfoViewModel>();

        var queue = new Queue<PersonShortInfoViewModel>();
        queue.Enqueue(mainPerson);

        while (queue.Count > 0)
        {
            var person = queue.Dequeue();

            if (person.Id == id)
            {
                return person;
            }

            people.Add(person.Id, person);

            foreach (var relative in person.Children
                         .Union(new[] { person.Father, person.Mother })
                         .Union(person.Relationships
                             .Select(r => r.Person1.Id == person.Id ? r.Person2 : r.Person1))
                         .Where(p => p != null && !people.ContainsKey(p.Id)))
            {
                queue.Enqueue(relative!);
            }
        }

        return null;
    }

    private async Task<PersonShortInfoViewModel?> GetById(PersonShortInfoViewModel model)
    {
        var entity = await context.People
            .Include(p => p.Relationships)
            .SingleOrDefaultAsync(p => p.Id == model.Id);

        if (entity is null)
        {
            return null;
        }
        
        model.FirstName = entity.FirstName;
        model.LastName = entity.LastName;
        model.Gender = entity.Gender.Name;
        model.Birthday = entity.Birthday;
        model.DeathDate = entity.DeathDate;
        model.IsDeceased = entity.IsDeceased;

        model.Father = entity.FatherId.HasValue
            ? SearchForId(model, entity.FatherId.Value) 
              ?? await GetById(new PersonShortInfoViewModel
                {
                    Id = entity.FatherId.Value,
                    Children = new List<PersonShortInfoViewModel> { model }
                })
            : null;

        model.Mother = entity.MotherId.HasValue
            ? SearchForId(model, entity.MotherId.Value)
              ?? await GetById(new PersonShortInfoViewModel
              {
                  Id = entity.MotherId.Value,
                  Children = new List<PersonShortInfoViewModel> { model }
              })
            : null;

        model.Relationships = entity.Relationships
            .Select(async r => new RelationshipViewModel
            {
                Type = r.Type.Name,
                Person1 = r.Person1Id == model.Id
                    ? model
                    : SearchForId(model, r.Person1Id) ?? (await GetById(r.Person1Id))!,
                Person2 = r.Person2Id == model.Id
                    ? model
                    : SearchForId(model, r.Person2Id) ?? (await GetById(r.Person2Id))!
            })
            .Select(t => t.Result)
            .ToHashSet();

        await context.People
            .Where(p => p.FatherId == model.Id || p.MotherId == model.Id)
            .Select(p => new PersonShortInfoViewModel
            {
                Id = p.Id,
                Father = p.FatherId == model.Id ? model : null,
                Mother = p.MotherId == model.Id ? model : null
            })
            .ForEachAsync(async c 
                => model.Children.Add(SearchForId(model, c.Id) ?? (await GetById(c))!));

        return model;
    }
}