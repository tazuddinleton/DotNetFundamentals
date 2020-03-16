using SimpleCqrs.Commanding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoCQRS.Contracts
{
    public class CreateMovieCommand : ICommand
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunningTimeMinutes { get; set; }

        public CreateMovieCommand(string title, DateTime releaseDate, int runnintTime)
        {
            Title = title;
            ReleaseDate = releaseDate;
            RunningTimeMinutes = runnintTime;
        }
    }
}
