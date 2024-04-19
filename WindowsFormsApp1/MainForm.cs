using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Project2MovieMate;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        Thread th;
        Thread gh;

        public MainForm()
        {
            MyDbContext dbContext = new MyDbContext();
            dbContext.ApplicationContext();
            InitializeComponent();
            
        }

       

        private async void MainForm_Load(object sender, EventArgs e)
        {
            

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        public void open(object obj)
        {
            Application.Run(new MainMenuForm());
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
            gh = new Thread(open1);
            gh.SetApartmentState(ApartmentState.STA);
            gh.Start();
        }
        public void open1(object obj)
        {
            Application.Run(new NewUserForm());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dataGridView1.Rows.Add(new object[]
            {
                
            });
        }
    }
}
