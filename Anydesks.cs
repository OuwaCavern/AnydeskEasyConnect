using System.ComponentModel;

namespace AnydeskEasyConnect
{
    public class Anydesks
    {
        [DisplayName("Şube Adı")]
        public string? ŞubeninAdı { get; set; }

        [DisplayName("Anydesk Numarası")]
        public string? ŞubeninAnydeskNumarası { get; set; }

        [DisplayName("Anydesk Parolası")]
        public string? ŞubeninAnydeskParolası { get; set; }

        [DisplayName("Bilgisayar Yetkisi")]
        public string? BilgisayarYetkisi { get; set; }
    }
}
