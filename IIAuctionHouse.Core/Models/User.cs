
using System.Collections.Generic;

namespace Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AccDetails AccDetails { get; set; }
        public List<Proprietary> Proprietaries { get; set; }
    }
}