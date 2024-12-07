using System.Net.Mail;
using Interface.MailMessageQueue.Message;

namespace Interface.MailMessageQueue
{
	public class MailMessageDto
	{
		/// <summary>Исходное сообщение, которое парсилось</summary>
		public MailMessage Message { get; set; }
		/// <summary>Заголовок сообщения с дополнительными данными о сообщении</summary>
		public MailHeaderDto Header { get; set; }
	}
}