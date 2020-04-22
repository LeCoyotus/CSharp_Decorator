namespace AnthoExoDecorator1
{
	public class AbstractDecorator : IFileManager
	{
		public IFileManager FileDecorated { get; set; }

		public AbstractDecorator(IFileManager fileDecorated)
		{
			FileDecorated = fileDecorated;
		}
		public virtual void AddContent(string contentToAdd)
		{
			FileDecorated.AddContent(contentToAdd);
		}

		public virtual string DisplayContent()
		{
			return FileDecorated.DisplayContent();
		}

		public virtual IFileManager PreviousDecoration()
		{
			return FileDecorated;
		}
	}
}