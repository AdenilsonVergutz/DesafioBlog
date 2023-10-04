namespace DesafioBlog.Formulario
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Nome="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usuarioButton = new Button();
            perfilButton = new Button();
            postButton = new Button();
            categoriaButton = new Button();
            tagButton = new Button();
            cadastroGroupBox = new GroupBox();
            relatoriosGroupBox = new GroupBox();
            postGroupBox = new GroupBox();
            relatorioButton = new Button();
            cadastroGroupBox.SuspendLayout();
            relatoriosGroupBox.SuspendLayout();
            postGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // usuarioButton
            // 
            usuarioButton.BackColor = SystemColors.ButtonShadow;
            usuarioButton.Location = new Point(32, 37);
            usuarioButton.Name = "usuarioButton";
            usuarioButton.Size = new Size(191, 47);
            usuarioButton.TabIndex = 0;
            usuarioButton.Text = "Usuário";
            usuarioButton.UseVisualStyleBackColor = false;
            usuarioButton.UseWaitCursor = true;
            usuarioButton.Click += usuarioButton_Click;
            // 
            // perfilButton
            // 
            perfilButton.BackColor = SystemColors.AppWorkspace;
            perfilButton.Location = new Point(32, 99);
            perfilButton.Name = "perfilButton";
            perfilButton.Size = new Size(190, 47);
            perfilButton.TabIndex = 1;
            perfilButton.Text = "Perfil";
            perfilButton.UseVisualStyleBackColor = false;
            perfilButton.UseWaitCursor = true;
            // 
            // postButton
            // 
            postButton.BackColor = SystemColors.ControlDark;
            postButton.Location = new Point(60, 44);
            postButton.Name = "postButton";
            postButton.Size = new Size(181, 52);
            postButton.TabIndex = 2;
            postButton.Text = "Post";
            postButton.UseVisualStyleBackColor = false;
            // 
            // categoriaButton
            // 
            categoriaButton.BackColor = SystemColors.ControlDark;
            categoriaButton.Location = new Point(31, 161);
            categoriaButton.Name = "categoriaButton";
            categoriaButton.Size = new Size(191, 50);
            categoriaButton.TabIndex = 3;
            categoriaButton.Text = "Categoria";
            categoriaButton.UseVisualStyleBackColor = false;
            // 
            // tagButton
            // 
            tagButton.BackColor = SystemColors.ControlDark;
            tagButton.Location = new Point(32, 232);
            tagButton.Name = "tagButton";
            tagButton.Size = new Size(191, 49);
            tagButton.TabIndex = 4;
            tagButton.Text = "Tag";
            tagButton.UseVisualStyleBackColor = false;
            // 
            // cadastroGroupBox
            // 
            cadastroGroupBox.Controls.Add(usuarioButton);
            cadastroGroupBox.Controls.Add(tagButton);
            cadastroGroupBox.Controls.Add(perfilButton);
            cadastroGroupBox.Controls.Add(categoriaButton);
            cadastroGroupBox.Location = new Point(25, 119);
            cadastroGroupBox.Name = "cadastroGroupBox";
            cadastroGroupBox.Size = new Size(269, 303);
            cadastroGroupBox.TabIndex = 5;
            cadastroGroupBox.TabStop = false;
            cadastroGroupBox.Text = "Cadastro";
            // 
            // relatoriosGroupBox
            // 
            relatoriosGroupBox.Controls.Add(relatorioButton);
            relatoriosGroupBox.Location = new Point(449, 277);
            relatoriosGroupBox.Name = "relatoriosGroupBox";
            relatoriosGroupBox.Size = new Size(308, 145);
            relatoriosGroupBox.TabIndex = 6;
            relatoriosGroupBox.TabStop = false;
            relatoriosGroupBox.Text = "Relatórios";
            // 
            // postGroupBox
            // 
            postGroupBox.Controls.Add(postButton);
            postGroupBox.Location = new Point(449, 119);
            postGroupBox.Name = "postGroupBox";
            postGroupBox.Size = new Size(308, 136);
            postGroupBox.TabIndex = 7;
            postGroupBox.TabStop = false;
            postGroupBox.Text = "Criar publicação";
            // 
            // relatorioButton
            // 
            relatorioButton.BackColor = SystemColors.ControlDark;
            relatorioButton.Location = new Point(60, 58);
            relatorioButton.Name = "relatorioButton";
            relatorioButton.Size = new Size(181, 48);
            relatorioButton.TabIndex = 0;
            relatorioButton.Text = "Relatórios";
            relatorioButton.UseVisualStyleBackColor = false;
            // 
            // frmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(postGroupBox);
            Controls.Add(relatoriosGroupBox);
            Controls.Add(cadastroGroupBox);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmTelaPrincipal";
            Text = "Tela Principal";
            cadastroGroupBox.ResumeLayout(false);
            relatoriosGroupBox.ResumeLayout(false);
            postGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button usuarioButton;
        private Button perfilButton;
        private Button postButton;
        private Button categoriaButton;
        private Button tagButton;
        private GroupBox cadastroGroupBox;
        private GroupBox relatoriosGroupBox;
        private Button relatorioButton;
        private GroupBox postGroupBox;
    }
}