using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfCore.Web.Models
{
    public class Presenter
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public string Biography { get; set; }
        public string TwitterHandle { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Talk> Talks { get; set; }

    }
}
