namespace ErrorManager.DTO
{
    public class UserNotificationDTO
    {
        public int Id { get; set; }
        public int? Frequency { get; set; }

        public NotificationDTO Notification { get; set; }
        public UserDTO User { get; set; }
    }
}