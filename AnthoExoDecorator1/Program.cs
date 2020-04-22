using System;

namespace AnthoExoDecorator1
{
	class Program
	{
		static void Main(string[] args)
		{
			IFileManager test = new File("Le contenu de mon fichier");

			test = new EncryptDecorator(test);

			test.AddContent(" mon message crypté");

			Console.WriteLine(test.DisplayContent());

			test = test.PreviousDecoration();

			Console.WriteLine(test.DisplayContent());

			test.AddContent(" mon message non crypté");

			Console.WriteLine(test.DisplayContent());

			test = new PermissionDecorator(test, false);

			test.AddContent("j'ai pas les droits");

			Console.WriteLine(test.DisplayContent());

			test = test.PreviousDecoration();

			test = new LogDecorator(test);

			test.AddContent("ajout de contenu pour vérifier si le log fonctionne");

			Console.WriteLine(test.DisplayContent());

		}
	}
}
