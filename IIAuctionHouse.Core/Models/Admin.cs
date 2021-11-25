using System.Collections.Generic;

namespace Core.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AccDetails AccDetails { get; set; }
        public Proprietary Proprietaries { get; set; }
    }
}