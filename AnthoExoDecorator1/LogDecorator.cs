using System;

namespace AnthoExoDecorator1
{
	public class LogDecorator : AbstractDecorator
	{
		public File LogFile { get; set; }
		public LogDecorator(IFileManager fileDecorated) : base(fileDecorated)
		{
			FileDecorated = fileDecorated;
			LogFile = new File();
		}

		public override void AddContent(string contentToAdd)
		{
			base.AddContent(contentToAdd);
			LogFile.AddContent("du contenu a été ajouté !");
			Console.WriteLine(LogFile.DisplayContent());
		}

		public override string DisplayContent()
		{
			LogFile.AddContent("une lecture a été faite");
			Console.WriteLine(LogFile.DisplayContent());
			return base.DisplayContent();
		}
	}
}