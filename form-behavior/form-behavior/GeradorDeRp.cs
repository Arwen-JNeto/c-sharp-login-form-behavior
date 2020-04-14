using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class GeradorDeRp : Form
    {
        public GeradorDeRp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você perdeu todo seu trabalho feito!");
            txtRiot.Text = "";
            txtNickname.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string robot = cmbRobot.Text;

            if (robot == "10")
            {
                String riot = txtRiot.Text;
                String nickname = txtNickname.Text;
                String password = txtPassword.Text;
                String email = txtEmail.Text;
                String phone = txtPhone.Text;
                String amount = cmbAmount.Text;
                MessageBox.Show("Conta Riot: " + riot +
                                ". Nickname: " + nickname +
                                ". Senha: " + password +
                                ". Email: " + email +
                                ". Telefone: " + phone +
                                ". Quantidade: " + amount);
            }
            else
                {
                MessageBox.Show("YOU ARE A ROBOT!");
                }

            }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNick_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNickname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
