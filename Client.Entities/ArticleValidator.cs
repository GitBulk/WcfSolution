using FluentValidation;

namespace Client.Entities
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(a => a.Author).NotEmpty();
            RuleFor(a => a.BlogId).GreaterThan(0);
            RuleFor(a => a.Contents).NotEmpty();
        }
    }
}