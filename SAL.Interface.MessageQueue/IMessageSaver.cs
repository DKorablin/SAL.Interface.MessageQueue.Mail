using System;
using SAL.Interface.MessageQueue.Message;

namespace SAL.Interface.MessageQueue
{
	/// <summary>Класс для сохранения результатов работы парсера</summary>
	public interface IMessageSaver
	{
		/// <summary>Обработать сообщение</summary>
		/// <param name="content">контент для сохранения</param>
		Boolean HandleMessage(MailMessageDto content);
	}
}