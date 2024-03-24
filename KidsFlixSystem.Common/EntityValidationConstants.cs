namespace KidsFlixSystem.Common
{
    public static  class EntityValidationConstants
    {
        public static class Movie
        {
            public const int MovieTitleMaxLength = 50;
            public const int MovieTitleMinLength = 3;

            public const string ReleaseDateTime = "yyyy";
            public const int DurationMaxLength = 180;
            public const int DurationMinLength = 40;

            public const int MovieDescriptionMaxLength = 1000;
            public const int MovieDescriptionMinLength = 50;

        }

        public static class Actor
        {
            public const int ActorFullNameMaxLength = 30;
            public const int ActorFullNameMinLength = 3;

            public const int ActorBiographyMaxLength = 1000;
            public const int ActorBiographyMinLength = 20;
        }

        public static class Director
        {
            public const int DirectorFullNameMaxLength = 30;
            public const int DirectorFullNameMinLength = 3;

            public const int DirectorBiographyMaxLength = 1000;
            public const int DirectorBiographyMinLength = 5;
        }

        public static class User
        {
            public const int MaxLengthPhoneNumber = 15;
            public const int MinLengthPhoneNumber = 7;

        }

        public static class Review
        {
            public const int ReviewCommentMaxLength = 2000;
            public const int ReviewCommentMinLength = 3;
        }
    }
}
