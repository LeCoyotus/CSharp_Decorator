namespace AnthoExoDecorator1
{
	public interface IFileManager
	{
		public void AddContent(string contentToAdd);

		public string DisplayContent();
		public IFileManager PreviousDecoration();
	}
}