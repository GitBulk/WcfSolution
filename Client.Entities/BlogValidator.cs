using FluentValidation;

namespace Client.Entities
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(b => b.Name).NotEmpty();
            RuleFor(b => b.Owner).NotEmpty();
            RuleFor(b => b.Id).GreaterThan(0);
        }
    }
}