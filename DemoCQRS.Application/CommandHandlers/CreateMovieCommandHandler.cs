using DemoCQRS.Contracts;
using SimpleCqrs.Commanding;
using SimpleCqrs.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCQRS.Application.CommandHandlers
{
    public enum CreateMovieStatus
    { 
        Successful
    }
    public class CreateMovieCommandHandler : CommandHandler<CreateMovieCommand>
    {

        protected IDomainRepository _repository;

        public CreateMovieCommandHandler(IDomainRepository repository)
        {
            _repository = repository;
        }

        protected CreateMovieStatus ValidateCommand(CreateMovieCommand command)
        {
            return CreateMovieStatus.Successful;
        }

        public override void Handle(CreateMovieCommand command)
        {
            Return(ValidateCommand(command));
            var location = new Domain.Movie(Guid.NewGuid(), command.Title, command.ReleaseDate, command.RunningTimeMinutes);
            _repository.Save(location);
        }
    }
}
