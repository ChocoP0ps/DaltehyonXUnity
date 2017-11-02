namespace DaltehyonXUnity
{
    partial class Serveur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.partiesGridView = new System.Windows.Forms.DataGridView();
            this.hebergeButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.joinButton = new System.Windows.Forms.Button();
            this.watchButton = new System.Windows.Forms.Button();
            this.withoutPassword = new System.Windows.Forms.CheckBox();
            this.free = new System.Windows.Forms.CheckBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partiesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(161, 18);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(237, 20);
            this.userNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName :";
            // 
            // partiesGridView
            // 
            this.partiesGridView.AllowUserToAddRows = false;
            this.partiesGridView.AllowUserToDeleteRows = false;
            this.partiesGridView.AllowUserToResizeColumns = false;
            this.partiesGridView.AllowUserToResizeRows = false;
            this.partiesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.partiesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partiesGridView.Location = new System.Drawing.Point(435, 60);
            this.partiesGridView.MultiSelect = false;
            this.partiesGridView.Name = "partiesGridView";
            this.partiesGridView.ReadOnly = true;
            this.partiesGridView.RowHeadersVisible = false;
            this.partiesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partiesGridView.Size = new System.Drawing.Size(522, 314);
            this.partiesGridView.TabIndex = 2;
            // 
            // hebergeButton
            // 
            this.hebergeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hebergeButton.Location = new System.Drawing.Point(18, 125);
            this.hebergeButton.Name = "hebergeButton";
            this.hebergeButton.Size = new System.Drawing.Size(380, 62);
            this.hebergeButton.TabIndex = 3;
            this.hebergeButton.Text = "Héberger une partie";
            this.hebergeButton.UseVisualStyleBackColor = true;
            this.hebergeButton.Click += new System.EventHandler(this.hebergeButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(161, 80);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(237, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de Passe :";
            // 
            // joinButton
            // 
            this.joinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.joinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinButton.Location = new System.Drawing.Point(435, 423);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(258, 48);
            this.joinButton.TabIndex = 6;
            this.joinButton.Text = "Rejoindre";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // watchButton
            // 
            this.watchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.watchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchButton.Location = new System.Drawing.Point(699, 423);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(258, 48);
            this.watchButton.TabIndex = 7;
            this.watchButton.Text = "Observer";
            this.watchButton.UseVisualStyleBackColor = true;
            // 
            // withoutPassword
            // 
            this.withoutPassword.AutoSize = true;
            this.withoutPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withoutPassword.Location = new System.Drawing.Point(18, 234);
            this.withoutPassword.Name = "withoutPassword";
            this.withoutPassword.Size = new System.Drawing.Size(165, 24);
            this.withoutPassword.TabIndex = 8;
            this.withoutPassword.Text = "Sans mot de passe";
            this.withoutPassword.UseVisualStyleBackColor = true;
            this.withoutPassword.CheckedChanged += new System.EventHandler(this.withoutPassword_CheckedChanged);
            // 
            // free
            // 
            this.free.AutoSize = true;
            this.free.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.free.Location = new System.Drawing.Point(18, 278);
            this.free.Name = "free";
            this.free.Size = new System.Drawing.Size(63, 24);
            this.free.TabIndex = 9;
            this.free.Text = "Libre";
            this.free.UseVisualStyleBackColor = true;
            this.free.CheckedChanged += new System.EventHandler(this.free_CheckedChanged);
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.Location = new System.Drawing.Point(537, 19);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(391, 20);
            this.searchText.TabIndex = 10;
            this.searchText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyUp);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rechercher :";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Image = global::DaltehyonXUnity.Properties.Resources.magnifying_glass_icon;
            this.searchButton.Location = new System.Drawing.Point(934, 15);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(27, 26);
            this.searchButton.TabIndex = 12;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(435, 380);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(522, 37);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Actualiser";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Serveur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 483);
            this.Controls.Add(this.partiesGridView);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.free);
            this.Controls.Add(this.withoutPassword);
            this.Controls.Add(this.watchButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.hebergeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "Serveur";
            this.Text = "Serveur";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Serveur_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.partiesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView partiesGridView;
        private System.Windows.Forms.Button hebergeButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.CheckBox withoutPassword;
        private System.Windows.Forms.CheckBox free;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button refreshButton;
    }
}