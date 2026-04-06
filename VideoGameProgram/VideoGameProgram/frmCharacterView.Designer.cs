namespace VideoGameProgram
{
    partial class frmCharacterView
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
            btnCreate = new Button();
            lblCharacterInfo = new Label();
            numAttack = new NumericUpDown();
            numSpeed = new NumericUpDown();
            numDefense = new NumericUpDown();
            numHealth = new NumericUpDown();
            lblName = new Label();
            lblHealth = new Label();
            lblInventory = new Label();
            lblAttack = new Label();
            lblSpeed = new Label();
            lblDefense = new Label();
            lbCharacters = new ListBox();
            lbInventory = new ListBox();
            lblCharacters = new Label();
            lblCharacterInventory = new Label();
            textInventory = new TextBox();
            textName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numAttack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDefense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHealth).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(115, 356);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(103, 32);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblCharacterInfo
            // 
            lblCharacterInfo.AutoSize = true;
            lblCharacterInfo.Location = new Point(352, 396);
            lblCharacterInfo.Name = "lblCharacterInfo";
            lblCharacterInfo.Size = new Size(0, 15);
            lblCharacterInfo.TabIndex = 1;
            // 
            // numAttack
            // 
            numAttack.Location = new Point(115, 122);
            numAttack.Name = "numAttack";
            numAttack.Size = new Size(64, 23);
            numAttack.TabIndex = 4;
            // 
            // numSpeed
            // 
            numSpeed.Location = new Point(115, 151);
            numSpeed.Name = "numSpeed";
            numSpeed.Size = new Size(64, 23);
            numSpeed.TabIndex = 5;
            // 
            // numDefense
            // 
            numDefense.Location = new Point(115, 180);
            numDefense.Name = "numDefense";
            numDefense.Size = new Size(64, 23);
            numDefense.TabIndex = 6;
            // 
            // numHealth
            // 
            numHealth.Location = new Point(115, 64);
            numHealth.Name = "numHealth";
            numHealth.Size = new Size(64, 23);
            numHealth.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(51, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 8;
            lblName.Text = "Name";
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Location = new Point(51, 64);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(42, 15);
            lblHealth.TabIndex = 9;
            lblHealth.Text = "Health";
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(51, 93);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(57, 15);
            lblInventory.TabIndex = 10;
            lblInventory.Text = "Inventory";
            // 
            // lblAttack
            // 
            lblAttack.AutoSize = true;
            lblAttack.Location = new Point(51, 122);
            lblAttack.Name = "lblAttack";
            lblAttack.Size = new Size(41, 15);
            lblAttack.TabIndex = 11;
            lblAttack.Text = "Attack";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(51, 151);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(39, 15);
            lblSpeed.TabIndex = 12;
            lblSpeed.Text = "Speed";
            // 
            // lblDefense
            // 
            lblDefense.AutoSize = true;
            lblDefense.Location = new Point(51, 180);
            lblDefense.Name = "lblDefense";
            lblDefense.Size = new Size(49, 15);
            lblDefense.TabIndex = 13;
            lblDefense.Text = "Defense";
            // 
            // lbCharacters
            // 
            lbCharacters.FormattingEnabled = true;
            lbCharacters.Location = new Point(381, 35);
            lbCharacters.Name = "lbCharacters";
            lbCharacters.Size = new Size(349, 79);
            lbCharacters.TabIndex = 14;
            lbCharacters.SelectedIndexChanged += lbCharacters_SelectedIndexChanged;
            // 
            // lbInventory
            // 
            lbInventory.FormattingEnabled = true;
            lbInventory.Location = new Point(381, 180);
            lbInventory.Name = "lbInventory";
            lbInventory.Size = new Size(221, 79);
            lbInventory.TabIndex = 15;
            // 
            // lblCharacters
            // 
            lblCharacters.AutoSize = true;
            lblCharacters.Location = new Point(381, 9);
            lblCharacters.Name = "lblCharacters";
            lblCharacters.Size = new Size(63, 15);
            lblCharacters.TabIndex = 16;
            lblCharacters.Text = "Characters";
            // 
            // lblCharacterInventory
            // 
            lblCharacterInventory.AutoSize = true;
            lblCharacterInventory.Location = new Point(381, 151);
            lblCharacterInventory.Name = "lblCharacterInventory";
            lblCharacterInventory.Size = new Size(119, 15);
            lblCharacterInventory.TabIndex = 17;
            lblCharacterInventory.Text = "Character's Inventory";
            // 
            // textInventory
            // 
            textInventory.Location = new Point(115, 93);
            textInventory.Name = "textInventory";
            textInventory.Size = new Size(100, 23);
            textInventory.TabIndex = 18;
            // 
            // textName
            // 
            textName.Location = new Point(114, 36);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 19;
            // 
            // frmCharacterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textName);
            Controls.Add(textInventory);
            Controls.Add(lblCharacterInventory);
            Controls.Add(lblCharacters);
            Controls.Add(lbInventory);
            Controls.Add(lbCharacters);
            Controls.Add(lblDefense);
            Controls.Add(lblSpeed);
            Controls.Add(lblAttack);
            Controls.Add(lblInventory);
            Controls.Add(lblHealth);
            Controls.Add(lblName);
            Controls.Add(numHealth);
            Controls.Add(numDefense);
            Controls.Add(numSpeed);
            Controls.Add(numAttack);
            Controls.Add(lblCharacterInfo);
            Controls.Add(btnCreate);
            Name = "frmCharacterView";
            Text = "Manage Character";
            ((System.ComponentModel.ISupportInitialize)numAttack).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDefense).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHealth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Label lblCharacterInfo;
        private NumericUpDown numAttack;
        private NumericUpDown numSpeed;
        private NumericUpDown numDefense;
        private NumericUpDown numHealth;
        private Label lblName;
        private Label lblHealth;
        private Label lblInventory;
        private Label lblAttack;
        private Label lblSpeed;
        private Label lblDefense;
        private ListBox lbCharacters;
        private ListBox lbInventory;
        private Label lblCharacters;
        private Label lblCharacterInventory;
        private TextBox textInventory;
        private TextBox textName;
    }
}
