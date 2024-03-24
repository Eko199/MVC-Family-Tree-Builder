namespace FamilyTreeBuilder.Core.Services;

using Contracts;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Models;

public class FamilyTreeService : IFamilyTreeService
{
    private readonly FamilyTreeBuilderDbContext context;
    private readonly IPersonService personService;

    public FamilyTreeService(FamilyTreeBuilderDbContext context, IPersonService personService)
    {
        this.context = context;
        this.personService = personService;
    }

    public async Task<IEnumerable<FamilyTreeShortInfoViewModel>> GetAllByOwnerId(string ownerId) 
        => await context.FamilyTrees
            .Where(ft => ft.OwnerId == ownerId)
            .Select(ft => new FamilyTreeShortInfoViewModel
            {
                Id = ft.Id,
                OwnerId = ft.OwnerId,
                Title = ft.Title,
                Description = ft.Description
            })
            .ToListAsync();

    public async Task<FamilyTreeViewModel?> GetById(int id)
    {
        var entity = await context.FamilyTrees.FindAsync(id);

        return entity is null ? null : new FamilyTreeViewModel
        {
            Id = entity.Id,
            OwnerId = entity.OwnerId,
            Title = entity.Title,
            MainPerson = await personService.GetById(entity.MainPersonId) 
                         ?? throw new ApplicationException("Main person missing!")
        };
    }
}