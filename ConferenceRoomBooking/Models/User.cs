﻿namespace ConferenceRoomBooking.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }

}
