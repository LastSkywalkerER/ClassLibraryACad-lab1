using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.ApplicationServices;

namespace ClassLibraryACad
{
    public class Class1
    {
        [CommandMethod("HelloWorld")]
        public void helloWorld()
        {
            Editor editor = Application.DocumentManager.MdiActiveDocument.Editor;
            editor.WriteMessage("Hello World");
        }
    }
}
