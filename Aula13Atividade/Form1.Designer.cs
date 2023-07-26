namespace Aula13Atividade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsalvar = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblrua = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(55, 307);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(153, 33);
            this.btnsalvar.TabIndex = 0;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(53, 88);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(96, 15);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Digite seu nome:";
            // 
            // lblrua
            // 
            this.lblrua.AutoSize = true;
            this.lblrua.Location = new System.Drawing.Point(55, 134);
            this.lblrua.Name = "lblrua";
            this.lblrua.Size = new System.Drawing.Size(94, 15);
            this.lblrua.TabIndex = 2;
            this.lblrua.Text = "Digite sua idade:";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(53, 178);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(114, 15);
            this.lblcidade.TabIndex = 3;
            this.lblcidade.Text = "Digite seu endereço:";
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Location = new System.Drawing.Point(55, 222);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(100, 15);
            this.lblidade.TabIndex = 4;
            this.lblidade.Text = "Digite sua cidade:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(247, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(165, 232);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(55, 108);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(153, 23);
            this.txtnome.TabIndex = 6;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(55, 240);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(153, 23);
            this.txtcidade.TabIndex = 7;
            // 
            // txtrua
            // 
            this.txtrua.Location = new System.Drawing.Point(55, 196);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(153, 23);
            this.txtrua.TabIndex = 8;
            this.txtrua.TextChanged += new System.EventHandler(this.txtendereco_TextChanged);
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(55, 152);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(153, 23);
            this.txtidade.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "CADASTRO DE USUÁRIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(265, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuários cadastrados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtrua);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblrua);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btnsalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnsalvar;
        private Label lblnome;
        private Label lblrua;
        private Label lblcidade;
        private Label lblidade;
        private ListView listView1;
        private TextBox txtnome;
        private TextBox txtcidade;
        private TextBox txtrua;
        private TextBox txtidade;
        private Label label1;
        private Label label2;
    }
}