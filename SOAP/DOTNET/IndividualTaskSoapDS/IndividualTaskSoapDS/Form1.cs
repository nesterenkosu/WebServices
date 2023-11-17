using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IndividualTaskSoapDS
{
    public partial class Form1 : Form
    {
        ServiceReference1.MyServicePortTypeClient cl;
        public Form1()
        {            
            InitializeComponent();
            cl = new ServiceReference1.MyServicePortTypeClient();
            UpdateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void UpdateGrid()
        {
            sOAPLanguageBindingSource.DataSource = cl.ListLanguages();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cl.CreateLanguage(((ServiceReference1.SOAP_Language)sOAPLanguageBindingSource1.Current).Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sOAPLanguageBindingSource1.DataSource = sOAPLanguageBindingSource.Current;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sOAPLanguageBindingSource1.DataSource = sOAPLanguageBindingSource.Current;
            if (dataGridView1.CurrentRow.Index + 1 == dataGridView1.Rows.Count)
            {
                MessageBox.Show("Режим добавления");
            }
        }
    }
}
