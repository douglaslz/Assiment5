namespace Assiment5
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.bloggingDataSet = new Assiment5.BloggingDataSet();
            this.blogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blogsTableAdapter = new Assiment5.BloggingDataSetTableAdapters.BlogsTableAdapter();
            this.booksDataSet = new Assiment5.BooksDataSet();
            this.titlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titlesTableAdapter = new Assiment5.BooksDataSetTableAdapters.TitlesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bloggingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bloggingDataSet
            // 
            this.bloggingDataSet.DataSetName = "BloggingDataSet";
            this.bloggingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blogsBindingSource
            // 
            this.blogsBindingSource.DataMember = "Blogs";
            this.blogsBindingSource.DataSource = this.bloggingDataSet;
            // 
            // blogsTableAdapter
            // 
            this.blogsTableAdapter.ClearBeforeFill = true;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titlesBindingSource
            // 
            this.titlesBindingSource.DataMember = "Titles";
            this.titlesBindingSource.DataSource = this.booksDataSet;
            // 
            // titlesTableAdapter
            // 
            this.titlesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 336);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bloggingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BloggingDataSet bloggingDataSet;
        private System.Windows.Forms.BindingSource blogsBindingSource;
        private BloggingDataSetTableAdapters.BlogsTableAdapter blogsTableAdapter;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource titlesBindingSource;
        private BooksDataSetTableAdapters.TitlesTableAdapter titlesTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

