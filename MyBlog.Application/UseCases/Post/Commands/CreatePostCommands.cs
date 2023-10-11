using MediatR;
using MyBlog.Application.Abstractions;

namespace MyBlog.Application.UseCases.Post.Commands
{
    public class CreatePostCommand : IRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

    public class CreatePostCommandHandler : AsyncRequestHandler<CreatePostCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreatePostCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Entities.Post 
            { 
                Title = request.Title, 
                Content = request.Content 
            };

            _context.Posts.Add(entity);
            await _context.SaveChangeAsync(cancellationToken);
        }
    }
}
