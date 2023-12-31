﻿namespace ApiToExcel
{
    partial class FrmPessoFornecedores
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
            TxtJson = new RichTextBox();
            BtnExecutar = new Button();
            saveFileDialog1 = new SaveFileDialog();
            TxUrlAPI = new TextBox();
            label1 = new Label();
            Lb_Ex_1 = new Label();
            TxRouter = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TxUser = new TextBox();
            TxPass = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // TxtJson
            // 
            TxtJson.Location = new Point(0, 311);
            TxtJson.Margin = new Padding(3, 100, 3, 3);
            TxtJson.Name = "TxtJson";
            TxtJson.Size = new Size(435, 204);
            TxtJson.TabIndex = 1;
            TxtJson.Text = "";
            TxtJson.TextChanged += TxtJson_TextChanged;
            // 
            // BtnExecutar
            // 
            BtnExecutar.Location = new Point(0, 256);
            BtnExecutar.Name = "BtnExecutar";
            BtnExecutar.Size = new Size(435, 50);
            BtnExecutar.TabIndex = 4;
            BtnExecutar.Text = "Executar";
            BtnExecutar.UseVisualStyleBackColor = true;
            BtnExecutar.Click += BtnExecutar_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Excel | *.xlsx";
            // 
            // TxUrlAPI
            // 
            TxUrlAPI.Location = new Point(12, 26);
            TxUrlAPI.Name = "TxUrlAPI";
            TxUrlAPI.Size = new Size(411, 23);
            TxUrlAPI.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 6;
            label1.Text = "Url da API";
            // 
            // Lb_Ex_1
            // 
            Lb_Ex_1.AutoSize = true;
            Lb_Ex_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lb_Ex_1.Location = new Point(12, 51);
            Lb_Ex_1.Name = "Lb_Ex_1";
            Lb_Ex_1.Size = new Size(107, 15);
            Lb_Ex_1.TabIndex = 7;
            Lb_Ex_1.Text = "emp.servidor.com";
            // 
            // TxRouter
            // 
            TxRouter.Location = new Point(12, 98);
            TxRouter.Name = "TxRouter";
            TxRouter.Size = new Size(411, 23);
            TxRouter.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 9;
            label2.Text = "Rota a Converter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 10;
            label3.Text = "/api/v1/pessoa/client";
            // 
            // TxUser
            // 
            TxUser.Location = new Point(277, 170);
            TxUser.Name = "TxUser";
            TxUser.Size = new Size(146, 23);
            TxUser.TabIndex = 11;
            // 
            // TxPass
            // 
            TxPass.Location = new Point(277, 227);
            TxPass.Name = "TxPass";
            TxPass.PasswordChar = '*';
            TxPass.Size = new Size(146, 23);
            TxPass.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 152);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 13;
            label4.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 209);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 14;
            label5.Text = "Senha";
            // 
            // FrmPessoFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 518);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxPass);
            Controls.Add(TxUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxRouter);
            Controls.Add(Lb_Ex_1);
            Controls.Add(label1);
            Controls.Add(TxUrlAPI);
            Controls.Add(BtnExecutar);
            Controls.Add(TxtJson);
            Name = "FrmPessoFornecedores";
            Text = "Converte Json By Xlsx";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox TxtJson;
        private Button BtnExecutar;
        private SaveFileDialog saveFileDialog1;
        private TextBox TxUrlAPI;
        private Label label1;
        private Label Lb_Ex_1;
        private TextBox TxRouter;
        private Label label2;
        private Label label3;
        private TextBox TxUser;
        private TextBox TxPass;
        private Label label4;
        private Label label5;
    }
}