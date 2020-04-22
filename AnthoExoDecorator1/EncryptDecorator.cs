namespace AnthoExoDecorator1
{
	public class EncryptDecorator : AbstractDecorator
	{
		public EncryptDecorator(IFileManager fileDecorated) : base(fileDecorated)
		{
			FileDecorated = fileDecorated;
		}

		public override void AddContent(string contentToAdd)
		{
			int i = contentToAdd.Length;
			string toAdd = "";
			for (int j = 0; j < i; j++)
			{
				toAdd += "*";
			}
			base.AddContent(toAdd);
		}
	}
}