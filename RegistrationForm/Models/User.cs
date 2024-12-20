using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage="Zəhmət olmasa adı daxil edin")]
        [StringLength(15, ErrorMessage = "Ad maksimum 15 simvol ola bilər")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Zəhmət olmasa soy adı daxil edin")]
        [StringLength(15, ErrorMessage = "Soy ad maksimum 15 simvol ola bilər")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "E-poçt ünvanı daxil edilməlidir.")]
        [EmailAddress(ErrorMessage = "Düzgün e-poçt ünvanı daxil edin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa iştirak etməyi təsdiq edin")]
        public bool Participate { get; set; }
    }
}
