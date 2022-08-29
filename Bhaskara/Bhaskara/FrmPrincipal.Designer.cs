
namespace Bhaskara
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lbx2 = new System.Windows.Forms.Label();
            this.lbx = new System.Windows.Forms.Label();
            this.lbzero = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbDelta = new System.Windows.Forms.Label();
            this.lbXP = new System.Windows.Forms.Label();
            this.lbXN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx2
            // 
            this.lbx2.AutoSize = true;
            this.lbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx2.Location = new System.Drawing.Point(77, 45);
            this.lbx2.Name = "lbx2";
            this.lbx2.Size = new System.Drawing.Size(42, 20);
            this.lbx2.TabIndex = 0;
            this.lbx2.Text = "X² + ";
            // 
            // lbx
            // 
            this.lbx.AutoSize = true;
            this.lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx.Location = new System.Drawing.Point(190, 45);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(33, 20);
            this.lbx.TabIndex = 1;
            this.lbx.Text = "X +";
            // 
            // lbzero
            // 
            this.lbzero.AutoSize = true;
            this.lbzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbzero.Location = new System.Drawing.Point(294, 45);
            this.lbzero.Name = "lbzero";
            this.lbzero.Size = new System.Drawing.Size(31, 20);
            this.lbzero.TabIndex = 2;
            this.lbzero.Text = "= 0";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(16, 42);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(59, 26);
            this.txtA.TabIndex = 3;
            this.txtA.Text = "       ";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(125, 42);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(59, 26);
            this.txtB.TabIndex = 4;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(229, 42);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(59, 26);
            this.txtC.TabIndex = 5;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(12, 9);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(434, 20);
            this.lbInfo.TabIndex = 6;
            this.lbInfo.Text = "Informe uma equação quadrática no formato ax² + bx + c = 0";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCalcular.Location = new System.Drawing.Point(16, 74);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(298, 35);
            this.btCalcular.TabIndex = 7;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbDelta
            // 
            this.lbDelta.AutoSize = true;
            this.lbDelta.Location = new System.Drawing.Point(13, 165);
            this.lbDelta.Name = "lbDelta";
            this.lbDelta.Size = new System.Drawing.Size(35, 13);
            this.lbDelta.TabIndex = 8;
            this.lbDelta.Text = "label1";
            this.lbDelta.Visible = false;
            // 
            // lbXP
            // 
            this.lbXP.AutoSize = true;
            this.lbXP.Location = new System.Drawing.Point(13, 195);
            this.lbXP.Name = "lbXP";
            this.lbXP.Size = new System.Drawing.Size(35, 13);
            this.lbXP.TabIndex = 9;
            this.lbXP.Text = "label2";
            this.lbXP.Visible = false;
            // 
            // lbXN
            // 
            this.lbXN.AutoSize = true;
            this.lbXN.Location = new System.Drawing.Point(13, 225);
            this.lbXN.Name = "lbXN";
            this.lbXN.Size = new System.Drawing.Size(35, 13);
            this.lbXN.TabIndex = 10;
            this.lbXN.Text = "label3";
            this.lbXN.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 333);
            this.Controls.Add(this.lbXN);
            this.Controls.Add(this.lbXP);
            this.Controls.Add(this.lbDelta);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbzero);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.lbx2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Bhaskara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbx2;
        private System.Windows.Forms.Label lbx;
        private System.Windows.Forms.Label lbzero;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbDelta;
        private System.Windows.Forms.Label lbXP;
        private System.Windows.Forms.Label lbXN;
    }
}

