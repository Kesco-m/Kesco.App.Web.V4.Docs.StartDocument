using Kesco.Lib.Entities.Documents;
using Kesco.Lib.Web.Controls.V4;
using Kesco.Lib.Web.Controls.V4.Common.DocumentPage;

namespace Kesco.App.Web.Docs.MyDocument
{
    public partial class MyDocPage : DocPage
    {
        protected override void DocumentInitialization(Document copy = null)
        {
            if (copy == null)
                Doc = new Lib.Entities.Documents.EF.MyDocuments.MyDocument();
            else
            {
                Doc = (Lib.Entities.Documents.EF.MyDocuments.MyDocument) copy;
            }
        }

        protected override void DocumentToControls()
        {
            var d = Doc as Lib.Entities.Documents.EF.MyDocuments.MyDocument;
            MyFormField.Value = d.MyField.Value.ToString();
        }

        protected override void SetControlProperties()
        {
            var d = Doc as Lib.Entities.Documents.EF.MyDocuments.MyDocument;
            MyFormField.IsRequired = d.MyField.IsMandatory;
            MyFormField.BindDocField = d.MyField;
        }

        protected void MyFormField_Changed(object sender, ProperyChangedEventArgs e)
        {
        }
    }
}