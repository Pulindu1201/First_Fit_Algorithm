namespace Mini_Project
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
            BlockSize = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ProcessSize = new TextBox();
            btn2Add = new Button();
            label4 = new Label();
            label5 = new Label();
            AllocationGridView = new DataGridView();
            Results2 = new Label();
            RemainingBlocksGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AllocationGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RemainingBlocksGridView).BeginInit();
            SuspendLayout();
            // 
            // BlockSize
            // 
            BlockSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BlockSize.Location = new Point(52, 171);
            BlockSize.Name = "BlockSize";
            BlockSize.Size = new Size(211, 33);
            BlockSize.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 22);
            label1.Name = "label1";
            label1.Size = new Size(276, 45);
            label1.TabIndex = 2;
            label1.Text = "First Fit Algorithm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 117);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 3;
            label2.Text = "Enter Block Size:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(436, 117);
            label3.Name = "label3";
            label3.Size = new Size(176, 25);
            label3.TabIndex = 4;
            label3.Text = "Enter Process Sizes:";
            // 
            // ProcessSize
            // 
            ProcessSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProcessSize.Location = new Point(436, 170);
            ProcessSize.Name = "ProcessSize";
            ProcessSize.Size = new Size(202, 33);
            ProcessSize.TabIndex = 5;
            // 
            // btn2Add
            // 
            btn2Add.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2Add.Location = new Point(685, 170);
            btn2Add.Name = "btn2Add";
            btn2Add.Size = new Size(82, 33);
            btn2Add.TabIndex = 6;
            btn2Add.Text = "Add";
            btn2Add.UseVisualStyleBackColor = true;
            btn2Add.Click += btn2Add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 245);
            label4.Name = "label4";
            label4.Size = new Size(164, 25);
            label4.TabIndex = 8;
            label4.Text = "Allocation Results:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(436, 264);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 9;
            // 
            // AllocationGridView
            // 
            AllocationGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllocationGridView.Location = new Point(52, 292);
            AllocationGridView.Name = "AllocationGridView";
            AllocationGridView.Size = new Size(695, 133);
            AllocationGridView.TabIndex = 10;
            // 
            // Results2
            // 
            Results2.AutoSize = true;
            Results2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Results2.Location = new Point(52, 464);
            Results2.Name = "Results2";
            Results2.Size = new Size(194, 25);
            Results2.TabIndex = 11;
            Results2.Text = "Remaining Block Size:";
            // 
            // RemainingBlocksGridView
            // 
            RemainingBlocksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RemainingBlocksGridView.Location = new Point(52, 510);
            RemainingBlocksGridView.Name = "RemainingBlocksGridView";
            RemainingBlocksGridView.Size = new Size(695, 135);
            RemainingBlocksGridView.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 708);
            Controls.Add(RemainingBlocksGridView);
            Controls.Add(Results2);
            Controls.Add(AllocationGridView);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn2Add);
            Controls.Add(ProcessSize);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BlockSize);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AllocationGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)RemainingBlocksGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BlockSize;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ProcessSize;
        private Button btn2Add;
        private Label label4;
        private Label label5;
        private DataGridView AllocationGridView;
        private Label Results2;
        private DataGridView RemainingBlocksGridView;
    }
}
