using System.ComponentModel.DataAnnotations;

namespace BTH1.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Name")]
        [MinLength(4, ErrorMessage = "Name không đạt số kí tự yêu cầu")]
        [MaxLength(100, ErrorMessage = "Name vượt quá kí tự cho phép")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@(?!gmail\.com$)([A-Za-z0-9.-]+\.[A-Za-z]{2,4})$", ErrorMessage = "Email không hợp lệ hoặc không được phép sử dụng đuôi gmail.com")]
        public string? Email { get; set; }

        [StringLength(100, MinimumLength = 8)]
        [Required(ErrorMessage = "Bạn chưa nhập Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!]).{8,}$")]
        public string? Password { get; set;}

        [Required(ErrorMessage = "Bạn chưa nhập Brand")]
        public Branch? Branch { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Gender")]
        public Gender? Gender { get; set; }
        public bool IsRegular { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Adress")]
        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }

        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Bạn chưa nhập Date")]
        public DateTime DateOfBorth { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Score")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0.")]
        public float Score { get; set; }
    }
}
