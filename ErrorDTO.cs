using System.Collections.Generic;

namespace ErrorManager.DTO
{
    public class ErrorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public bool Enabled { get; set; }

        public SeverityDTO Severity { get; set; }
        public IEnumerable<UserNotificationDTO> UserNotifications { get; set; }
    }
}