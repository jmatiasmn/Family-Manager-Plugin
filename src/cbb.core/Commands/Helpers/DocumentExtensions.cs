using Autodesk.Revit.Creation;
using Autodesk.Revit.DB;
using Document = Autodesk.Revit.DB.Document;

namespace cbb.core
{
    public class DocumentExtensions
    {
        public static void LoadFamily(Document doc, string path)
        {
            using (Transaction t = new Transaction(doc, "Family Load"))
            {
                t.Start();

                doc.LoadFamily(path);

                t.Commit();
            }
        }
    }
}
