namespace CourierServiceDotnet.Services.User.Domain.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public UserEntity(int Id, string FirstName, string LastName, string Email, bool Active)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Active = Active;
        }
    }
}