namespace HWYDotNetCore.LoginAppV2.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string SessionId { get; set; }
        public DateTime SessionExpire { get; set; }


    }
}
