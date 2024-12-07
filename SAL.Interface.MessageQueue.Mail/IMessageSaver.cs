using System;
using SAL.Interface.MessageQueue.Mail.Message;

namespace SAL.Interface.MessageQueue.Mail
{
	/// <summary>Класс для сохранения результатов работы парсера</summary>
	public interface IMessageSaver
	{
		/// <summary>Обработать сообщение</summary>
		/// <param name="content">контент для сохранения</param>
		Boolean HandleMessage(MailMessageDto content);
	}
}