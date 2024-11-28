using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEducationCamp301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        EducationCampEfDbEntities db = new EducationCampEfDbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuideName = textName.Text;
            guide.GuideSurname = textSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = textName.Text;
            updateValue.GuideSurname = textSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var values = db.Guide.Where(x =>x.GuideId==id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
