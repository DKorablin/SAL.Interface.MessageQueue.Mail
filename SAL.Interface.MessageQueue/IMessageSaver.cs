using System;
using Interface.MailMessageQueue.Message;

namespace Interface.MailMessageQueue
{
	/// <summary>Класс для сохранения результатов работы парсера</summary>
	public interface IMessageSaver
	{
		/// <summary>Обработать сообщение</summary>
		/// <param name="content">контент для сохранения</param>
		Boolean HandleMessage(MailMessageDto content);
	}
}