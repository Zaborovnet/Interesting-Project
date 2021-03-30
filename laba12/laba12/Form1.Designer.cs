namespace laba12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Бесхвостые");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Хвостатые");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Безногие");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Земноводные", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Бесхвостые";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Хвостатые";
            treeNode3.Name = "Узел3";
            treeNode3.Text = "Безногие";
            treeNode4.Name = "Узел0";
            treeNode4.Text = "Земноводные";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(273, 486);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(695, 492);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(406, 458);
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(228, 36);
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "comment_cj1Y8ue9BYcBgyBu6TUmKpi3w70ythKU,w400.jpg");
            this.imageList1.Images.SetKeyName(1, "scale_1200 (3).jpg");
            this.imageList1.Images.SetKeyName(2, "18924335716_e8eae377e4_k.jpg");
            this.imageList1.Images.SetKeyName(3, "mons_sk_bfrog_5d2_6799ci (Копировать).jpg");
            this.imageList1.Images.SetKeyName(4, "giant-pixie-feature.jpg");
            this.imageList1.Images.SetKeyName(5, "medium.jpg");
            this.imageList1.Images.SetKeyName(6, "8460137250_f20f15d808_b.jpg");
            this.imageList1.Images.SetKeyName(7, "568-3.jpg");
            this.imageList1.Images.SetKeyName(8, "Ognennaya-salamandra.jpg");
            this.imageList1.Images.SetKeyName(9, "5.jpg");
            this.imageList1.Images.SetKeyName(10, "cae003.jpg");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Примеры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 516);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Классификация земноводных";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

