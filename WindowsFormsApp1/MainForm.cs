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

namespace WindowsFormsApp1
{
    public partial class MainForm : System.Windows.Forms.Form
    {

        private MyDbContext dbContext;
        Thread th;
        Thread gh;

        public MainForm()
        {
            InitializeComponent();
            try
            {
                dbContext = new MyDbContext();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing DbContext: " + ex.Message);
            }
        }

       

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                dbContext = new MyDbContext();
                var data = await dbContext.Persons.ToListAsync();

                usersComboBox.DataSource = data;
                usersComboBox.DisplayMember = "nickname";
                usersComboBox.ValueMember = "nickname";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing DbContext: " + ex.Message);
            }

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
    }
}
