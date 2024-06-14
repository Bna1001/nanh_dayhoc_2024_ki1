using System.ComponentModel.DataAnnotations;
namespace nanh_dayhoc_2024.Models
{
    public class SinhVien
    {
        [KeyAttribute]
        [Display(Name = "Mã Sinh Viên")]
        public string MaSinHVien { get; set; }
        [Display(Name = "Họ Tên")]
        public string HoTen { get; set; }
        [Display(Name = "Mã Lớp")]
        public string MaLop { get; set; }
    }
}