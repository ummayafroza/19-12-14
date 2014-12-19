using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueApp
{
    public partial class CustomerQueueForm : Form
    {
        public CustomerQueueForm()
        {
            InitializeComponent();

        }
        Queue<Customer> customers = new Queue<Customer>();
        int serialNumber = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            serialNumber++;
            Customer aCustomer = new Customer();
            aCustomer.customerName = nameInputTextBox.Text;
            aCustomer.complain = complainTextBox.Text;
            aCustomer.serialNumber = serialNumber.ToString();

            customers.Enqueue(aCustomer);
            customers.Enqueue(aCustomer);
            nameInputTextBox.Clear();
            complainTextBox.Clear();

            ListViewItem item = new ListViewItem();
            item.Text = serialNumber.ToString();
            item.SubItems.Add(aCustomer.customerName);
            item.SubItems.Add(aCustomer.complain);
            string information = aCustomer.customerName + "  Serial No:" + serialNumber;
            waitingQueueListView.Items.Add(item);
            MessageBox.Show(information);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void nameInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            
            Customer aCustomer = new Customer();
            aCustomer = customers.Dequeue();
            serialNoTextBox.Text = aCustomer.serialNumber;
            nameTextBox.Text = aCustomer.customerName;
            complainShowTextBox.Text = aCustomer.complain;
            waitingQueueListView.Items.RemoveAt(0);
            
        }

        private void complainTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
