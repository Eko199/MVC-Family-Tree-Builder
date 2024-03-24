namespace FamilyTreeBuilder.Core.Contracts;

using Models;

public interface IFamilyTreeService
{
    Task<IEnumerable<FamilyTreeShortInfoViewModel>> GetAllByOwnerId(string ownerId);

    Task<FamilyTreeViewModel?> GetById(int id);
}