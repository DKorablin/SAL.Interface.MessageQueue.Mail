using System;
using System.Net.Mime;
using System.Text;

namespace SAL.Interface.MailMessageQueue.Message
{
	public class MailPart
	{
		public ContentType ContentType { get; set; }
		public String ContentDescription { get; set; }
		public String ContentId { get; set; }
		public ContentDisposition ContentDisposition { get; set; }
		public Encoding BodyEncoding { get; set; }
		public Byte[] Body { get; set; }
		public String FileName { get; set; }
		public MailPart[] MessageParts { get; set; }
	}
}