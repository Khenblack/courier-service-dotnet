using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourierServiceDotnet.Services.Authentication.Infrastructure.DBEntities
{
    [Table("Auth")]
    public class AuthDB
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }
        [Required]
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }

        public AuthDB(int UserId, byte[] PasswordHash, byte[] PasswordSalt)
        {
            this.UserId = UserId;
            this.PasswordHash = PasswordHash;
            this.PasswordSalt = PasswordSalt;
        }
    }
}