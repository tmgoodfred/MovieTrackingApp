using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTrackingApp.Models
{
    public class UserMovie
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int MovieId { get; set; }
        public bool Watched { get; set; }
        public int? Rating { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
