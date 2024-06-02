using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ.Models
{
    public class Dekorator
    {
        private TableLayoutPanel tblStudent;

        public Dekorator(TableLayoutPanel tblStudent)
        {
            this.tblStudent = tblStudent ?? throw new ArgumentNullException(nameof(tblStudent));
        }

        public void AddRowToTable(string label, string value)
        {
            tblStudent.RowCount++;
            var lblProperty = new Label
            {
                Text = label,
                Anchor = AnchorStyles.Left,
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Blue,
                Padding = new Padding(5)
            };

            var lblValue = new Label
            {
                Text = value,
                Anchor = AnchorStyles.Left,
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Regular),
                ForeColor = Color.Black,
                Padding = new Padding(5)
            };
            tblStudent.Controls.Add(lblProperty, 0, tblStudent.RowCount - 1);
            tblStudent.Controls.Add(lblValue, 1, tblStudent.RowCount - 1);
        }
    }

}
