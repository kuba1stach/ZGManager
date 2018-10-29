using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ZGManager
{
    public partial class Form1 : Form
    {
        private Rectangle dragBoxFromMouseDown;
        private object valueFromMouseDown;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sTATUSYTableAdapter.Fill(this.zGDataSet.STATUSY);
            this.tYPYTableAdapter.Fill(this.zGDataSet.TYPY);
            this.zgTableAdapter1.Fill(this.zGDataSet.ZG);
            this.comboBox2.SelectedItem = "Realizacja";

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
            short selectedValue = 0;
            if (comboBox2.SelectedItem == "Realizacja")
            {
                selectedValue = 0;
            }
            if (comboBox2.SelectedItem == "Wgrywanie")
            {
                selectedValue = 1;
            }
            if (comboBox2.SelectedItem == "Zrobione")
            {
                selectedValue = 2;
            }
            
            

            zgTableAdapter1.Insert(
                0,
                Convert.ToInt32(richTextBox1.Text),
                richTextBox2.Text,
                Convert.ToInt16(comboBox1.SelectedValue),
                selectedValue,
                null,
                null,
                null,
                null
                );
            UpdateControls();
            UpdateDB();
        }





        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            DGVMouseDown(dataGridView1, e);
        }

        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {
            DGVMouseDown(dataGridView2, e);
        }

        private void dataGridView3_MouseDown(object sender, MouseEventArgs e)
        {
            DGVMouseDown(dataGridView3, e);
        }


        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            DGVMouseMove(dataGridView1, e);
        }

        private void dataGridView2_MouseMove(object sender, MouseEventArgs e)
        {
            DGVMouseMove(dataGridView2, e);
        }

        private void dataGridView3_MouseMove(object sender, MouseEventArgs e)
        {
            DGVMouseMove(dataGridView3, e);
        }


        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }      

        private void dataGridView2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridView2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridView3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridView3_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel5_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel5_DragDrop(object sender, DragEventArgs e)
        {
            PanelDragDrop(panel5, e, 3);
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            DGVDragDrop(dataGridView1, e, 0);
        }

        private void dataGridView2_DragDrop(object sender, DragEventArgs e)
        {
            DGVDragDrop(dataGridView2, e, 1);
        }

        private void dataGridView3_DragDrop(object sender, DragEventArgs e)
        {
            DGVDragDrop(dataGridView3, e, 2);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVCellDoubleClick(dataGridView1, e);
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVCellDoubleClick(dataGridView2, e);
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVCellDoubleClick(dataGridView3, e);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = richTextBox2.Text != "" && richTextBox2.Text != "OPIS" && richTextBox1.Text != "" && richTextBox1.Text != "ZG" ? true : false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = richTextBox2.Text != "" && richTextBox2.Text != "OPIS" && richTextBox1.Text != "" && richTextBox1.Text != "ZG" ? true : false;
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text == "" ? "ZG" : richTextBox1.Text;
        }

        private void richTextBox2_Leave(object sender, EventArgs e)
        {
            richTextBox2.Text = richTextBox2.Text == "" ? "OPIS" : richTextBox2.Text;
        }


//###############################################################################################################################

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
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
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

        private void DGVMouseDown(DataGridView dgv, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            var hittestInfo = dgv.HitTest(e.X, e.Y);

            if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1)
            {
                valueFromMouseDown = dgv.Rows[hittestInfo.RowIndex].Cells[1].Value;
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

        private void DGVMouseMove(DataGridView dgv, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dgv.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
                }
            }
        }

        private void PanelMouseMove(Panel panel, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = panel.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
                }
            }
        }

        private void DGVDragDrop(DataGridView dgv, DragEventArgs e, short status)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dgv.PointToClient(new Point(e.X, e.Y));
            // If the drag operation was a copy then add the row to the other control.
            if (e.Effect == DragDropEffects.Copy)
            {
                //int cellvalue = Convert.ToInt32(e.Data.GetData(typeof(int)));
                string cellvalue = Convert.ToString(e.Data.GetData(typeof(string)));
                ZGDataSet.ZGRow zgRow = GetRefByCellValue(cellvalue);
                zgRow.STATUS = status;

                UpdateDB();
                UpdateControls();
            }
        }

        private void PanelDragDrop(Panel panel, DragEventArgs e, short status)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = panel.PointToClient(new Point(e.X, e.Y));
            // If the drag operation was a copy then add the row to the other control.
            if (e.Effect == DragDropEffects.Copy)
            {
                string cellvalue = Convert.ToString(e.Data.GetData(typeof(string)));
                ZGDataSet.ZGRow zgRow = GetRefByCellValue(cellvalue);
                zgRow.STATUS = status;
                /*zgTableAdapter1.Delete(
                   zgRow.REF,
                   zgRow.ZG_NR,
                   zgRow.OPIS,
                   zgRow.TYP,
                   zgRow.STATUS,
                   null,
                   null,
                   zgRow.REG_DATE,
                   null
                   );*/

                UpdateDB();
                UpdateControls();
            }
        }

        private void DGVCellDoubleClick(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            string cellvalue = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            ZGDataSet.ZGRow zgRow = GetRefByCellValue(cellvalue);
            zgRow.TYP = (zgRow.TYP < 2) ? zgRow.TYP += 1 : zgRow.TYP = 0;

            UpdateDB();
            UpdateControls();
        }


        private ZGDataSet.ZGRow GetRefByCellValue(string cellvalue)
        {
            this.zgTableAdapter1.Fill(this.zGDataSet.ZG);
            int _ref = Convert.ToInt16(zGDataSet.Tables["ZG"].Select("OPIS = '" + cellvalue + "'")[0].ItemArray[0]);
            return zGDataSet.ZG.FindByREF(_ref);
        }

        private void UpdateDB()
        {
            try
            {
                this.Validate();
                this.zgTableAdapter1.Update(this.zGDataSet.ZG);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            PanelMouseMove(panel5, e);
        }





















    }
}
