﻿namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string Login { get; set; }
        
        public string Password { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string? Patrynomic {  get; set; }
        
        public DateTime Birthday { get; set; }
        
        public string Role { get; set; }

        public virtual IEnumerable<Reservation> Reservations { get; set; }
    }
}
