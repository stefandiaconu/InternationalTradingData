namespace International_Trading_Data
{
    partial class Form1
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
            this.loadButton = new System.Windows.Forms.Button();
            this.treeHightLabel = new System.Windows.Forms.Label();
            this.countryInformationBox = new System.Windows.Forms.RichTextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.treeCountLabel = new System.Windows.Forms.Label();
            this.searchPartnerLabel = new System.Windows.Forms.Label();
            this.biggestPotentialClickLabel = new System.Windows.Forms.Label();
            this.allCountriesListBox = new System.Windows.Forms.ListBox();
            this.biggestPotentialLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.searchPartnerTextBox = new System.Windows.Forms.TextBox();
            this.searchPartnerButton = new System.Windows.Forms.Button();
            this.biggestPotentialButton = new System.Windows.Forms.Button();
            this.inOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.searchCountryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(52, 87);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(145, 68);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // treeHightLabel
            // 
            this.treeHightLabel.AutoSize = true;
            this.treeHightLabel.Location = new System.Drawing.Point(47, 158);
            this.treeHightLabel.Name = "treeHightLabel";
            this.treeHightLabel.Size = new System.Drawing.Size(183, 25);
            this.treeHightLabel.TabIndex = 1;
            this.treeHightLabel.Text = "Height of the tree:";
            // 
            // countryInformationBox
            // 
            this.countryInformationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryInformationBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.countryInformationBox.Location = new System.Drawing.Point(274, 90);
            this.countryInformationBox.Name = "countryInformationBox";
            this.countryInformationBox.Size = new System.Drawing.Size(150, 279);
            this.countryInformationBox.TabIndex = 2;
            this.countryInformationBox.Text = "";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(274, 565);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(139, 31);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // treeCountLabel
            // 
            this.treeCountLabel.AutoSize = true;
            this.treeCountLabel.Location = new System.Drawing.Point(47, 183);
            this.treeCountLabel.Name = "treeCountLabel";
            this.treeCountLabel.Size = new System.Drawing.Size(211, 25);
            this.treeCountLabel.TabIndex = 4;
            this.treeCountLabel.Text = "Number of countries:";
            // 
            // searchPartnerLabel
            // 
            this.searchPartnerLabel.AutoSize = true;
            this.searchPartnerLabel.Location = new System.Drawing.Point(486, 537);
            this.searchPartnerLabel.Name = "searchPartnerLabel";
            this.searchPartnerLabel.Size = new System.Drawing.Size(364, 25);
            this.searchPartnerLabel.TabIndex = 5;
            this.searchPartnerLabel.Text = "Search for a country by trade partner";
            // 
            // biggestPotentialClickLabel
            // 
            this.biggestPotentialClickLabel.AutoSize = true;
            this.biggestPotentialClickLabel.Location = new System.Drawing.Point(47, 208);
            this.biggestPotentialClickLabel.Name = "biggestPotentialClickLabel";
            this.biggestPotentialClickLabel.Size = new System.Drawing.Size(221, 25);
            this.biggestPotentialClickLabel.TabIndex = 6;
            this.biggestPotentialClickLabel.Text = "Biggest potential click";
            // 
            // allCountriesListBox
            // 
            this.allCountriesListBox.FormattingEnabled = true;
            this.allCountriesListBox.ItemHeight = 25;
            this.allCountriesListBox.Location = new System.Drawing.Point(491, 90);
            this.allCountriesListBox.Name = "allCountriesListBox";
            this.allCountriesListBox.Size = new System.Drawing.Size(150, 279);
            this.allCountriesListBox.TabIndex = 7;
            this.allCountriesListBox.SelectedIndexChanged += new System.EventHandler(this.allCountriesListBox_SelectedIndexChanged);
            this.allCountriesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.allCountriesListBox_MouseDoubleClick);
            // 
            // biggestPotentialLabel
            // 
            this.biggestPotentialLabel.AutoSize = true;
            this.biggestPotentialLabel.Location = new System.Drawing.Point(47, 279);
            this.biggestPotentialLabel.Name = "biggestPotentialLabel";
            this.biggestPotentialLabel.Size = new System.Drawing.Size(172, 25);
            this.biggestPotentialLabel.TabIndex = 8;
            this.biggestPotentialLabel.Text = "Biggest potential";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(491, 375);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(150, 59);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove country";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // searchPartnerTextBox
            // 
            this.searchPartnerTextBox.Location = new System.Drawing.Point(491, 565);
            this.searchPartnerTextBox.Name = "searchPartnerTextBox";
            this.searchPartnerTextBox.Size = new System.Drawing.Size(150, 31);
            this.searchPartnerTextBox.TabIndex = 10;
            // 
            // searchPartnerButton
            // 
            this.searchPartnerButton.Location = new System.Drawing.Point(647, 563);
            this.searchPartnerButton.Name = "searchPartnerButton";
            this.searchPartnerButton.Size = new System.Drawing.Size(131, 35);
            this.searchPartnerButton.TabIndex = 11;
            this.searchPartnerButton.Text = "Search";
            this.searchPartnerButton.UseVisualStyleBackColor = true;
            this.searchPartnerButton.Click += new System.EventHandler(this.searchPartnerButton_Click);
            // 
            // biggestPotentialButton
            // 
            this.biggestPotentialButton.Location = new System.Drawing.Point(52, 236);
            this.biggestPotentialButton.Name = "biggestPotentialButton";
            this.biggestPotentialButton.Size = new System.Drawing.Size(108, 40);
            this.biggestPotentialButton.TabIndex = 12;
            this.biggestPotentialButton.Text = "Click";
            this.biggestPotentialButton.UseVisualStyleBackColor = true;
            this.biggestPotentialButton.Click += new System.EventHandler(this.biggestPotentialButton_Click);
            // 
            // inOrderRadioButton
            // 
            this.inOrderRadioButton.AutoSize = true;
            this.inOrderRadioButton.Location = new System.Drawing.Point(491, 440);
            this.inOrderRadioButton.Name = "inOrderRadioButton";
            this.inOrderRadioButton.Size = new System.Drawing.Size(284, 29);
            this.inOrderRadioButton.TabIndex = 13;
            this.inOrderRadioButton.TabStop = true;
            this.inOrderRadioButton.Text = "Order the list of countries";
            this.inOrderRadioButton.UseVisualStyleBackColor = true;
            this.inOrderRadioButton.CheckedChanged += new System.EventHandler(this.inOrderRadioButton_CheckedChanged);
            // 
            // searchCountryLabel
            // 
            this.searchCountryLabel.AutoSize = true;
            this.searchCountryLabel.Location = new System.Drawing.Point(274, 537);
            this.searchCountryLabel.Name = "searchCountryLabel";
            this.searchCountryLabel.Size = new System.Drawing.Size(206, 25);
            this.searchCountryLabel.TabIndex = 14;
            this.searchCountryLabel.Text = "Search for a country";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(855, 661);
            this.Controls.Add(this.searchCountryLabel);
            this.Controls.Add(this.inOrderRadioButton);
            this.Controls.Add(this.biggestPotentialButton);
            this.Controls.Add(this.searchPartnerButton);
            this.Controls.Add(this.searchPartnerTextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.biggestPotentialLabel);
            this.Controls.Add(this.allCountriesListBox);
            this.Controls.Add(this.biggestPotentialClickLabel);
            this.Controls.Add(this.searchPartnerLabel);
            this.Controls.Add(this.treeCountLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.countryInformationBox);
            this.Controls.Add(this.treeHightLabel);
            this.Controls.Add(this.loadButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label treeHightLabel;
        private System.Windows.Forms.RichTextBox countryInformationBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label treeCountLabel;
        private System.Windows.Forms.Label searchPartnerLabel;
        private System.Windows.Forms.Label biggestPotentialClickLabel;
        private System.Windows.Forms.ListBox allCountriesListBox;
        private System.Windows.Forms.Label biggestPotentialLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox searchPartnerTextBox;
        private System.Windows.Forms.Button searchPartnerButton;
        private System.Windows.Forms.Button biggestPotentialButton;
        private System.Windows.Forms.RadioButton inOrderRadioButton;
        private System.Windows.Forms.Label searchCountryLabel;
    }
}

