namespace Entities.Abstracts
{
    public class BaseEntity : IEntity
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime? Created { get; set; }
        public virtual DateTime? Changed { get; set; }
    }
}
