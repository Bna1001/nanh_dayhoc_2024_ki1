using System.ComponentModel.DataAnnotations;
namespace nanh_dayhoc_2024.Models
{
    public class LopHoc
    {
        [KeyAttribute]
        [Display(Name = "Mã lớp")]
        public string MaLop { get; set; }
        [Display(Name = "Tên lớp")]
        public string TenLop { get; set; }
    }
}