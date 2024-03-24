namespace FamilyTreeBuilder.Core.Contracts;

using Models;

public interface IPersonService
{
    Task<PersonShortInfoViewModel?> GetById(int id);
}