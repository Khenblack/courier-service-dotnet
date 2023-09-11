namespace CourierServiceDotnet.Services.User.ServiceLibrary.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public UserDTO(int Id, string FirstName, string LastName, string Email, bool Active)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Active = Active;
        }
    }
}