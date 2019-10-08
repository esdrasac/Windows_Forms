using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Forms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Bt1_Click(object sender, EventArgs e) {
            Eq2grau Eq = new Eq2grau();
            
            if(txtA.Text != "" && txtB.Text != "" && txtC.Text != "") {
                Eq.a = int.Parse(txtA.Text);
                Eq.b = int.Parse(txtB.Text);
                Eq.c = int.Parse(txtC.Text);
                Eq.CalcDelta();
                txtDelta.Text = Eq.MeuDelta.ToString("F2");
                lblmensagem.Visible = true;
                if(Eq.MeuDelta >= 0) {
                    lblmensagem.Text = "Existem raízes reais";
                    Eq.CalcRaizes();
                    txtraiz1.Text = Eq.Raiz1.ToString("F2");
                    txtraiz2.Text = Eq.Raiz2.ToString("F2");
                }
                else {
                    lblmensagem.Text = "Não existem raízes reais";
                    txtraiz1.BackColor = Color.Red;
                    txtraiz2.BackColor = Color.Red;
                }
            }
            


        }

        private void TxtA_TextChanged(object sender, EventArgs e) {
           
            txtDelta.Text = "";
            txtraiz1.Text = "";
            txtraiz2.Text = "";
            txtraiz1.BackColor = Color.White;
            txtraiz2.BackColor = Color.White;
            lblmensagem.Text = "";
        }
        private void TxtB_TextChanged(object sender, EventArgs e) {
            txtDelta.Text = "";
            txtraiz1.Text = "";
            txtraiz2.Text = "";
            txtraiz1.BackColor = Color.White;
            txtraiz2.BackColor = Color.White;
            lblmensagem.Text = "";
        }
        private void TxtC_TextChanged(object sender, EventArgs e) {
            txtDelta.Text = "";
            txtraiz1.Text = "";
            txtraiz2.Text = "";
            txtraiz1.BackColor = Color.White;
            txtraiz2.BackColor = Color.White;
            lblmensagem.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e) {
            System.Environment.Exit(0);
        }

        private void TxtA_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == (char)Keys.Enter)
                txtB.Focus();
        }

        private void TxtB_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == (char)Keys.Enter)
                txtC.Focus();
        }

        private void TxtC_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == (char)Keys.Enter)
                btCalcular.Focus();
            btCalcular.PerformClick();
        }

        private void TxtA_Click(object sender, EventArgs e) {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
        }

        
    }
}
