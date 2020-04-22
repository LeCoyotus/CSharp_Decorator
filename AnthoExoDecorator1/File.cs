namespace AnthoExoDecorator1
{
	public class File : IFileManager
	{
		public string Content { get; set; }

		public File()
		{
			
		}
		public File(string content)
		{
			Content = content;
		}

		public void AddContent(string contentToAdd)
		{
			Content += contentToAdd;
		}

		public string DisplayContent()
		{
			return Content;
		}

		public IFileManager PreviousDecoration()
		{
			return null;
		}
	}
}