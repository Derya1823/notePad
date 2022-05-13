namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        DialogResult dr;
        public Form1()
        {
            InitializeComponent();
        }
        bool kayitliMi = false;
        string kayitliDosyaAdi;
        string baslik = "NotePad-";
        void Yeni() 
        {
            richTextBox1.Text = "";
            richTextBox1.Visible = true;
            kaydetToolStripButton.Enabled = true;
            this.Text = baslik + "Yeni Dosya";
        }
        void Kaydet()
        {
            if (kayitliMi==false) {
                saveFileDialog1.Filter = "Zengin metin dosyasý(*.rtf)|*.rtf";
                saveFileDialog1.FileName = "";
                dr = saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    richTextBox1.Modified = false;
                    kayitliMi = true;
                    kayitliDosyaAdi = saveFileDialog1.FileName;
                    this.Text = baslik + kayitliDosyaAdi;
                } 
            }
            else
            {
                richTextBox1.SaveFile(kayitliDosyaAdi);
                richTextBox1.Modified = false;
            }
        }
        void DosyaAc() 
        {
            openFileDialog1.Filter = "Zengin Metin dosyasý(*.rtf)|*.rtf";
            openFileDialog1.FileName = "";
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Yeni();
                richTextBox1.LoadFile(openFileDialog1.FileName);
                kayitliDosyaAdi = openFileDialog1.FileName;
                kayitliMi = true;
                richTextBox1.Modified = false;
                this.Text = baslik + kayitliDosyaAdi;
                
            }
        }
        void kontrolEt() 
        {
            if (richTextBox1.Modified)
            {
                dr = MessageBox.Show("Kaydetmek istiyor musunuz?","Uyarý!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }
            if (dr == DialogResult.Yes)
            {
                Kaydet();
            }
        }
        void Kes() 
        {
            richTextBox1.Cut();
        }
        void Kopyala() 
        {
            richTextBox1.Copy();
        }
        void Yapistir() 
        {
            richTextBox1.Paste();
        }
        void bicimle() 
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
            richTextBox1.SelectionColor = fontDialog1.Color;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            kaydetToolStripButton.Enabled = false;
            this.Text = baslik;
        }
        private void yeniToolStripButton_Click(object sender, EventArgs e)
        {
            Yeni();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Yeni();
        }
        private void çýkýþToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
        private void kaydetToolStripButton_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DosyaAc();
        }
        private void açToolStripButton_Click(object sender, EventArgs e)
        {
            DosyaAc();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Modified)
            {
                dr = MessageBox.Show("Kaydetmek istiyor musunuz?", "Uyarý!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            if (dr == DialogResult.Yes)
            {
                Kaydet();
            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kes();
        }
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kopyala();
        }
        private void yapýþtýrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yapistir();
        }
        private void biçimleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bicimle();
        }
        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(richTextBox1, new Point(e.X, e.Y));
            }
        }
        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kes();
        }
        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kopyala();
        }
        private void yapýþtýrToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Yapistir();
        }
        private void biçimleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bicimle();
        }
    }
}