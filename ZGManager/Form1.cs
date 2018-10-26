using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZGManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sTATUSYTableAdapter.Fill(this.zGDataSet.STATUSY);
            this.tYPYTableAdapter.Fill(this.zGDataSet.TYPY);

            UpdateControls();
        }


        private void richTextBox2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zgTableAdapter1.Insert(
                0,
                Convert.ToInt32(richTextBox1.Text),
                richTextBox2.Text,
                Convert.ToInt16(comboBox1.SelectedValue),
                Convert.ToInt16(comboBox2.SelectedValue),
                null,
                null,
                null,
                null
                );
            UpdateControls();
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void sizeDGV(DataGridView dgv)
        {
            dgv.AutoResizeColumns();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states);
            var totalWidth = dgv.Columns.GetColumnsWidth(states);
            dgv.ClientSize = new Size(totalWidth, totalHeight);
        }

        private void UpdateControls()
        {
            this.zG_W_REALIZACJITableAdapter1.Fill(this.zGDataSet.ZG_W_REALIZACJI);
            this.zG_DO_WGRANIATableAdapter.Fill(this.zGDataSet.ZG_DO_WGRANIA);
            this.zG_ZROBIONETableAdapter.Fill(this.zGDataSet.ZG_ZROBIONE);

            var c = GetAll(this, typeof(DataGridView));
            foreach (DataGridView dgv in c)
            {
                sizeDGV(dgv);
            }

            richTextBox1.Text = "ZG";
            richTextBox2.Text = "OPIS";
            comboBox1.SelectedValue = 0;
            comboBox2.SelectedValue = 0;
            this.Refresh();
        }

        private void dataGridView2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        /* Drag & Drop */
        private Rectangle dragBoxFromMouseDown;
        private object valueFromMouseDown;
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dataGridView1.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
                }
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            var hittestInfo = dataGridView1.HitTest(e.X, e.Y);

            if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1)
            {
                valueFromMouseDown = dataGridView1.Rows[hittestInfo.RowIndex].Cells[hittestInfo.ColumnIndex].Value;
                if (valueFromMouseDown != null)
                {
                    // Remember the point where the mouse down occurred. 
                    // The DragSize indicates the size that the mouse can move 
                    // before a drag event should be started.                
                    Size dragSize = SystemInformation.DragSize;

                    // Create a rectangle using the DragSize, with the mouse position being
                    // at the center of the rectangle.
                    dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                }
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dataGridView2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridView2_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dataGridView2.PointToClient(new Point(e.X, e.Y));

            // If the drag operation was a copy then add the row to the other control.
            if (e.Effect == DragDropEffects.Copy)
            {
                string cellvalue = e.Data.GetData(typeof(string)) as string;
                var hittest = dataGridView2.HitTest(clientPoint.X, clientPoint.Y);
                if (hittest.ColumnIndex != -1
                    && hittest.RowIndex != -1)
                    dataGridView2[hittest.ColumnIndex, hittest.RowIndex].Value = cellvalue;

            }
        }
    }
}
