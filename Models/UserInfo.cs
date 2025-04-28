using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad Soyad alanı boş bırakılamaz")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Telefon alanı boş bırakılamaz")]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="Email alanı boş bırakılamaz")]
        [EmailAddress(ErrorMessage ="Hatalı Email Formatı")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Lütfen katılım durumu seçiniz")]
        public bool? WillAttend {  get; set; }
        
    }
}
