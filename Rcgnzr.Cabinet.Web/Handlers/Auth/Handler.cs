using System.Threading;
using System.Threading.Tasks;
using LinqToDB;
using MediatR;
using Rcgnzr.Cabinet.Model;

namespace Rcgnzr.Cabinet.Web.Handlers.Auth
{
    public class Handler: IRequestHandler<Request, Response>
    {
        private readonly Context _context;

        public Handler(Context context)
        {
            _context = context;
        }
        
        public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Login == request.Data.Login);
            if (user == null || !user.PasswordCorrect(request.Data.Password))
                return Response.Fail();

            return Response.Success("some_token");
        }
    }
}