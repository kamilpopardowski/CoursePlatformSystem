namespace CoursePlatformSystem.Course.Domain.Exceptions
{
    public class RequiredNameException : Exception
    {
        public RequiredNameException() : base("Course name is required.")
        {
        }
    }
}
