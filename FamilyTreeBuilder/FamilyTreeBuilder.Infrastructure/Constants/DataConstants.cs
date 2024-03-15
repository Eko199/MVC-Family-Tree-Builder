namespace FamilyTreeBuilder.Infrastructure.Constants;

/// <summary>
/// Constants used for data validation
/// </summary>
public static class DataConstants
{
    public static class FamilyTree
    {
        public const int TitleMinLength = 5;
        public const int TitleMaxLength = 50;

        public const int DescriptionMaxLength = 1000;
    }

    public static class Person
    {
        public const int FirstNameMinLength = 2;
        public const int FirstNameMaxLength = 50;

        public const int LastNameMinLength = 2;
        public const int LastNameMaxLength = 100;

        public const int BiographyMaxLength = 1000;
    }

    public static class Gender
    {
        public const int NameMinLength = 3;
        public const int NameMaxLength = 20;
    }

    public static class Fact
    {
        public const int TitleMinLength = 5;
        public const int TitleMaxLength = 75;

        public const int DescriptionMaxLength = 1000;
    }

    public static class RelationshipType
    {
        public const int NameMinLength = 5;
        public const int NameMaxLength = 30;
    }

    //Error messages:

    public const string StringLengthErrorMessage = "The field {0} must be between {2} and {1} characters long!";
}