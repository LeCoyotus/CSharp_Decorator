using System;

namespace AnthoExoDecorator1
{
	public class PermissionDecorator : AbstractDecorator
	{
		public bool IsAllowed { get; set; }
		public PermissionDecorator(IFileManager fileDecorated, bool isAllowed) : base(fileDecorated)
		{
			FileDecorated = fileDecorated;
			IsAllowed = isAllowed;
		}

		public override void AddContent(string contentToAdd)
		{
			if (IsAllowed)
			{
				base.AddContent(contentToAdd);
			}
			else
			{
				Console.WriteLine("Pas la permission d'écrire dans le fichier, dsl.");
			}
		}
	}
}