namespace BanVeXemPhimApi.Models
{
    public class Cinema : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int Status { get; set; } // 0: Không hoạt động, 1: Hoạt động, 2: Lưu trữ
    }
}
