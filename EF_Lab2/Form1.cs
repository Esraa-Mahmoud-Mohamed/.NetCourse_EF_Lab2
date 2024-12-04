using EF_Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewsContext db = new NewsContext();
            //dataGridView1.DataSource = db.Employees.Select(n => new {n.id,n.fullname,n.username,n.salary}).ToList();
            //dataGridView1.DataSource = db.Employees.Include(n=>n.department).ToList();
            dataGridView1.DataSource = db.News.ToList();
        }
    }
}
