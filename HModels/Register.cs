using System.ComponentModel.DataAnnotations;

namespace HModels
{
    public class Register
    {
        [Key]
        public int UserId { get; set; } 
        public string RegId { get; }
        public string Firstname { get; set; }
        public string? Middlename { get; set; }
        public string Lastname { get; set; }
        public string Username {  get; set; }
        public string Email { get; set; }
        public string phone { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string UserRole { get; set; }  // "admin", "doctor", "patient"
        public string SecId { get; set; }
        public string SecurityAnswer { get; set; }
        public string Address { get; set; }
        public DateTime? Createddate {  get; set; }
        public DateTime? Updateddate { get; set; }
    }
}
