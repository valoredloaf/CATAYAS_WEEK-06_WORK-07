using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK06_WORK07
{
    public partial class DataGridView : Form
    {
        private DataTable table = new DataTable("Equipment");
        private BindingSource bs = new BindingSource();

        public DataGridView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
            {
                table.Columns.Add("Asset Tag");
                table.Columns.Add("Equipment");
                table.Columns.Add("Category");
                table.Columns.Add("Location");
                table.Columns.Add("Status");

                table.Rows.Add("EQ-101", "Laptop", "Computer", "Room 204", "Available");
                table.Rows.Add("EQ-102", "Projector", "Audio-Visual", "Library", "Checked Out");
                table.Rows.Add("EQ-103", "Camera", "Media", "Room 108", "Under Maintenance");

                bs.DataSource = table;
                dgv_equipment.DataSource = bs;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = txt_search.Text.Trim();

            if (text.Length == 0)
            {
                bs.RemoveFilter();
                return;
            }

            string safe = EscapeForFilter(text);
            bs.Filter = string.Format("[Asset Tag] LIKE '%{0}%' OR [Equipment] LIKE '%{0}%'", safe);

            if (dgv_equipment.Rows.Count == 0)
            {
                MessageBox.Show("No equipment matches \"" + text + "\".",
                    "No results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static string EscapeForFilter(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (c == '[' || c == ']' || c == '%' || c == '*')
                    sb.Append('[').Append(c).Append(']');
                else if (c == '\'')
                    sb.Append("''");
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            bs.RemoveFilter();
        }

        private void btn_updateStatus_Click(object sender, EventArgs e)
        {
            DataRowView rowView = null;
            if (dgv_equipment.CurrentRow != null)
                rowView = dgv_equipment.CurrentRow.DataBoundItem as DataRowView;

            if (rowView == null)
            {
                MessageBox.Show("Please select a row in the grid first.",
                    "No row selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmb_selectedItemStatus.SelectedItem == null)
            {
                MessageBox.Show("Please choose a status from the dropdown.",
                    "No status selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = cmb_selectedItemStatus.SelectedItem.ToString();
            rowView["Status"] = newStatus;
            rowView.EndEdit();

            MessageBox.Show(rowView["Asset Tag"] + " is now \"" + newStatus + "\".",
                "Status updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmb_selectedItemStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_addEquipment_Click(object sender, EventArgs e)
        {
            string tag = txt_assetTag.Text.Trim();
            string equip = txt_equipment.Text.Trim();

            if (tag.Length == 0 || equip.Length == 0)
            {
                MessageBox.Show("Please enter both an Asset Tag and an Equipment name.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tag.Length == 0) txt_assetTag.Focus(); else txt_equipment.Focus();
                return;
            }

            foreach (DataRow r in table.Rows)
            {
                if (string.Equals(Convert.ToString(r["Asset Tag"]), tag, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Asset tag \"" + tag + "\" already exists.",
                        "Duplicate asset tag", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_assetTag.Focus();
                    return;
                }
            }

            table.Rows.Add(tag, equip, txt_category.Text.Trim(), txt_location.Text.Trim(), "Available");
            txt_assetTag.Clear();
            txt_equipment.Clear();
            txt_category.Clear();
            txt_location.Clear();
            txt_search.Clear();
            bs.RemoveFilter();

            foreach (DataGridViewRow row in dgv_equipment.Rows)
            {
                if (string.Equals(Convert.ToString(row.Cells[0].Value), tag, StringComparison.OrdinalIgnoreCase))
                {
                    dgv_equipment.ClearSelection();
                    dgv_equipment.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    break;
                }
            }
        }
    }
}
