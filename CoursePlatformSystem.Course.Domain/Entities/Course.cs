using CoursePlatformSystem.Course.Domain.Exceptions;

namespace CoursePlatformSystem.Course.Domain.Entities
{
    public class Course : BaseEntity
    {
        private Course()
        {

        }

        private Course(string name, string description, string createdBy)
        {
            Name = name;
            Description = description;
            CreatedBy = createdBy;
        }

        public string Name { get; }
        public string Description { get; }

        public static Course New(string name, string description, string createdBy)
        {
            if (string.IsNullOrEmpty(name))
                throw new RequiredNameException();

            return new Course(name, description, createdBy);
        }
    }
}
