using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace WinFormsApp1
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            a();
            b();
            combo.Items.Add("");
            combo.Items.Add("A");
            combo.Items.Add("B");
            combo.Items.Add("C");
            combo.SelectedIndex = 0;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            labelMove.Text = "�Ȃ�����ĂȂ���";

        }

        private void MailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            a();
        }
        private void a()
        {
            if (MailCheckBox.Checked)
            {
                MailBox.Enabled = true;
                Mail.Enabled = true;
            }
            else
            {
                MailBox.Enabled = false;
                Mail.Enabled = false;
            }
        }


        private void NotFree_CheckedChanged(object sender, EventArgs e)
        {
            b();
        }

        private void b()
        {
            label.Visible = NotFree.Checked;
        }
        private void Save_Click_1(object sender, EventArgs e)
        {
            if (IDtextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("���������J�X","�x��",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                IDtextBox.Focus();
                return;
            }

            if (MailBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("���������J�X","�x��", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MailBox.Focus();
                return;
            }

            if (IDtextBox.Text.Contains(","))
            {
                MessageBox.Show("ID�ɃJ���}�͓�����Ȃ���`", "�x��", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IDtextBox.Focus();
                return;
            }

            if (MailBox.Text.Contains(","))
            {
                MessageBox.Show("�A�h���X�ɃJ���}�͓�����Ȃ���`", "�x��", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MailBox.Focus();
                return;
            }

            DialogResult dialogResult = MessageBox.Show("�ۑ����邼�`", "�m�F�t�H�[��", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                using (StreamWriter sw = new StreamWriter("aaa.csv",true, Encoding.UTF8))
                {
                    sw.Write(IDtextBox.Text);
                    sw.Write(",");
                    sw.Write(MailBox.Text);
                    sw.Write(",");
                    if (free.Checked)
                    {
                        sw.Write("�t���[����");
                    }
                    else
                    {
                        sw.Write("�t���[����Ȃ���");
                    }
                    sw.Write(",");
                    sw.Write(combo.Text);
                    sw.WriteLine("");
                }

                MessageBox.Show("�ۑ�������`");
                labelMove.Text = "�ۑ�������";
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("�ۑ����ĂȂ���`");
                labelMove.Text = "�ۑ����ĂȂ���`";

            }
            else if (dialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
