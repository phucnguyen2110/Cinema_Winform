using System.Windows.Forms;

namespace Microsoft
{
    internal class Reporting
    {
        internal class WinForms
        {
            internal class ReportDataSource
            {
                public string Name { get; internal set; }
                public object Value { get; internal set; }
            }

            internal class ReportViewer
            {
                public ReportViewer()
                {
                }

                public DockStyle Dock { get; internal set; }
                public object LocalReport { get; internal set; }
            }
        }
    }
}