using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace WriteAssemblyBinding
{
	class Program
	{
		static void Main(string[] args)
		{
			var assemblies = Directory.EnumerateFiles(Environment.CurrentDirectory, "*.dll").Select(s => Assembly.LoadFile(s)).ToList();

			var template = new WriteBindingTemplate();
			template.Model = assemblies;
			File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "assemblyBinding.xml"), template.TransformText());
		}
	}
}
