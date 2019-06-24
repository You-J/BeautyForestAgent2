using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void VisibleChange(bool visible)
        {
            this.Visible = visible;
            this.ntiTray.Visible = !visible;
        }

        private void 폼보이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true);
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ntiTray.Visible = false;
            Application.ExitThread();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChange(false);
        }

        private void BtnTray_Click(object sender, EventArgs e)
        {
            VisibleChange(false);
        }

        private void NtiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true);
        }


        private void 끝내기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.StatusMessage.Text = "종료합니다.";
            Application.ExitThread(); 

        }

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProfile();

        }

        private void EditProfile()
        {
            this.StatusMessage.Text = "프로필 수정";
            FormModify m = new FormModify();
            m.Title = "프로필 수정 창";
            m.ShowDialog();
        }

        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProfile();
        }

        private void AddProfile()
        {
            this.StatusMessage.Text = "프로필 추가";
            FormAdd m = new FormAdd();
            m.Title = "프로필 추가 창";
            m.ShowDialog();
        }

        private void 이프로그램은ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StatusMessage.Text = "이 프로그램은...";
            FormAbout m = new FormAbout();
            m.Title = "프로그램 설명";
            m.Show();

        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            EditProfile();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddProfile();
        }
    }

}
