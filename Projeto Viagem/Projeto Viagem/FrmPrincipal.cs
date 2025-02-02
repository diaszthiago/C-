﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Viagem
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ckGastoPedagio_CheckedChanged(object sender, EventArgs e)
        {
            lbPedagio.Visible = txtPedagio.Visible = ckGastoPedagio.Checked;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try 
            {
                float distancia, consumo, combustivel, pedagio;

                distancia = float.Parse(txtDistancia.Text);
                consumo = float.Parse(txtConsumo.Text);
                combustivel = float.Parse(txtCombustivel.Text);

                //if ternário...
                pedagio = ckGastoPedagio.Checked ? float.Parse(txtPedagio.Text) : 0;

                FrmRelatorio frmRelatorio = new FrmRelatorio(distancia, consumo, combustivel, pedagio);
                frmRelatorio.Show();       
            }
            catch (Exception)
            {
                MessageBox.Show("Ops... algo deu errado!");
            }
        }
    }
}
