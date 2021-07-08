using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

using Autodesk.AutoCAD.Windows;

using System.Runtime.InteropServices;

namespace ACADuserInterface
{
	[Assembly: ExtensionApplication(GetType(adskClass))]
	public class adskClass : IExtensionApplication
	{
		ContextMenuExtension myContextMenu;
		public void Initialize()
		{
			throw new System.NotImplementedException();
		}

		public void Terminate()
		{
			throw new System.NotImplementedException();
		}
	}
}
