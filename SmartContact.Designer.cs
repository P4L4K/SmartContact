namespace SmartContact
{
    partial class SmartContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartContact));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBoxContactID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            label3 = new Label();
            textBoxContactNo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxGender = new ComboBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            textBoxSearch = new TextBox();
            label7 = new Label();
            Searchbuttionpic = new PictureBox();
            deleteButton = new Button();
            updateButton = new Button();
            ContaxtDetails = new GroupBox();
            buttonclear = new Button();
            textBoxImage = new TextBox();
            ImageLable = new Label();
            buttonloaddata = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Searchbuttionpic).BeginInit();
            ContaxtDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBoxContactID
            // 
            resources.ApplyResources(textBoxContactID, "textBoxContactID");
            textBoxContactID.Name = "textBoxContactID";
            textBoxContactID.ReadOnly = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // textBoxFirstName
            // 
            resources.ApplyResources(textBoxFirstName, "textBoxFirstName");
            textBoxFirstName.Name = "textBoxFirstName";
            // 
            // textBoxLastName
            // 
            resources.ApplyResources(textBoxLastName, "textBoxLastName");
            textBoxLastName.Name = "textBoxLastName";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // textBoxContactNo
            // 
            resources.ApplyResources(textBoxContactNo, "textBoxContactNo");
            textBoxContactNo.Name = "textBoxContactNo";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // comboBoxGender
            // 
            resources.ApplyResources(comboBoxGender, "comboBoxGender");
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { resources.GetString("comboBoxGender.Items"), resources.GetString("comboBoxGender.Items1"), resources.GetString("comboBoxGender.Items2") });
            comboBoxGender.Name = "comboBoxGender";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.LightSeaGreen;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Name = "label6";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleGoldenrod;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // textBoxSearch
            // 
            resources.ApplyResources(textBoxSearch, "textBoxSearch");
            textBoxSearch.ForeColor = Color.FromArgb(0, 64, 64);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Tag = "";
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // Searchbuttionpic
            // 
            Searchbuttionpic.BorderStyle = BorderStyle.Fixed3D;
            resources.ApplyResources(Searchbuttionpic, "Searchbuttionpic");
            Searchbuttionpic.Name = "Searchbuttionpic";
            Searchbuttionpic.TabStop = false;
            Searchbuttionpic.Click += Searchbuttionpic_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Firebrick;
            resources.ApplyResources(deleteButton, "deleteButton");
            deleteButton.Name = "deleteButton";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += button2_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.MediumSeaGreen;
            resources.ApplyResources(updateButton, "updateButton");
            updateButton.Name = "updateButton";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += button3_Click;
            // 
            // ContaxtDetails
            // 
            ContaxtDetails.BackColor = Color.BurlyWood;
            ContaxtDetails.Controls.Add(buttonclear);
            ContaxtDetails.Controls.Add(textBoxImage);
            ContaxtDetails.Controls.Add(ImageLable);
            ContaxtDetails.Controls.Add(label1);
            ContaxtDetails.Controls.Add(updateButton);
            ContaxtDetails.Controls.Add(textBoxContactID);
            ContaxtDetails.Controls.Add(deleteButton);
            ContaxtDetails.Controls.Add(label2);
            ContaxtDetails.Controls.Add(textBoxFirstName);
            ContaxtDetails.Controls.Add(label3);
            ContaxtDetails.Controls.Add(textBoxLastName);
            ContaxtDetails.Controls.Add(label4);
            ContaxtDetails.Controls.Add(textBoxContactNo);
            ContaxtDetails.Controls.Add(comboBoxGender);
            ContaxtDetails.Controls.Add(button1);
            ContaxtDetails.Controls.Add(label5);
            ContaxtDetails.FlatStyle = FlatStyle.Popup;
            resources.ApplyResources(ContaxtDetails, "ContaxtDetails");
            ContaxtDetails.Name = "ContaxtDetails";
            ContaxtDetails.TabStop = false;
            // 
            // buttonclear
            // 
            buttonclear.BackColor = Color.MediumOrchid;
            resources.ApplyResources(buttonclear, "buttonclear");
            buttonclear.Name = "buttonclear";
            buttonclear.UseVisualStyleBackColor = false;
            buttonclear.Click += buttonclear_Click;
            // 
            // textBoxImage
            // 
            resources.ApplyResources(textBoxImage, "textBoxImage");
            textBoxImage.Name = "textBoxImage";
            textBoxImage.TextChanged += pictureBox1_Click;
            // 
            // ImageLable
            // 
            ImageLable.BackColor = Color.Transparent;
            resources.ApplyResources(ImageLable, "ImageLable");
            ImageLable.Name = "ImageLable";
            // 
            // buttonloaddata
            // 
            buttonloaddata.BackColor = Color.LightSlateGray;
            resources.ApplyResources(buttonloaddata, "buttonloaddata");
            buttonloaddata.Name = "buttonloaddata";
            buttonloaddata.UseVisualStyleBackColor = false;
            buttonloaddata.Click += buttonloaddata_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // SmartContact
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(buttonloaddata);
            Controls.Add(ContaxtDetails);
            Controls.Add(Searchbuttionpic);
            Controls.Add(textBoxSearch);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Cursor = Cursors.PanNW;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "SmartContact";
            Load += SmartContact_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Searchbuttionpic).EndInit();
            ContaxtDetails.ResumeLayout(false);
            ContaxtDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBoxContactID;
        private Label label1;
        private Label label2;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label label3;
        private TextBox textBoxContactNo;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxGender;
        private Label label6;
        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private Label label7;
        private PictureBox Searchbuttionpic;
        private Button deleteButton;
        private Button updateButton;
        private GroupBox ContaxtDetails;
        private TextBox textBoxImage;
        private Label ImageLable;
        private Button buttonclear;
        private Button buttonloaddata;
        private PictureBox pictureBox2;
    }
}
