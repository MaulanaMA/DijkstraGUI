namespace DijkstraGUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label startNodeLabel;
        private System.Windows.Forms.Label endNodeLabel;
        private System.Windows.Forms.TextBox startNodeTextBox;
        private System.Windows.Forms.TextBox endNodeTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label sourceNodeLabel;
        private System.Windows.Forms.Label destinationNodeLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox sourceNodeTextBox;
        private System.Windows.Forms.TextBox destinationNodeTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button addEdgeButton;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label resultLabel;

        private void InitializeComponent()
        {
            this.startNodeLabel = new System.Windows.Forms.Label();
            this.endNodeLabel = new System.Windows.Forms.Label();
            this.startNodeTextBox = new System.Windows.Forms.TextBox();
            this.endNodeTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.sourceNodeLabel = new System.Windows.Forms.Label();
            this.destinationNodeLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.sourceNodeTextBox = new System.Windows.Forms.TextBox();
            this.destinationNodeTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startNodeLabel
            // 
            this.startNodeLabel.AutoSize = true;
            this.startNodeLabel.Location = new System.Drawing.Point(12, 15);
            this.startNodeLabel.Name = "startNodeLabel";
            this.startNodeLabel.Size = new System.Drawing.Size(72, 13);
            this.startNodeLabel.TabIndex = 0;
            this.startNodeLabel.Text = "Titik Awal:";
            // 
            // endNodeLabel
            // 
            this.endNodeLabel.AutoSize = true;
            this.endNodeLabel.Location = new System.Drawing.Point(12, 41);
            this.endNodeLabel.Name = "endNodeLabel";
            this.endNodeLabel.Size = new System.Drawing.Size(81, 13);
            this.endNodeLabel.TabIndex = 1;
            this.endNodeLabel.Text = "Titik Akhir:";
            // 
            // startNodeTextBox
            // 
            this.startNodeTextBox.Location = new System.Drawing.Point(99, 12);
            this.startNodeTextBox.Name = "startNodeTextBox";
            this.startNodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.startNodeTextBox.TabIndex = 2;
            // 
            // endNodeTextBox
            // 
            this.endNodeTextBox.Location = new System.Drawing.Point(99, 38);
            this.endNodeTextBox.Name = "endNodeTextBox";
            this.endNodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.endNodeTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(205, 10);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Hitung";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // sourceNodeLabel
            // 
            this.sourceNodeLabel.AutoSize = true;
            this.sourceNodeLabel.Location = new System.Drawing.Point(12, 80);
            this.sourceNodeLabel.Name = "sourceNodeLabel";
            this.sourceNodeLabel.Size = new System.Drawing.Size(81, 13);
            this.sourceNodeLabel.TabIndex = 5;
            this.sourceNodeLabel.Text = "Titik Awal:";
            // 
            // destinationNodeLabel
            // 
            this.destinationNodeLabel.AutoSize = true;
            this.destinationNodeLabel.Location = new System.Drawing.Point(12, 106);
            this.destinationNodeLabel.Name = "destinationNodeLabel";
            this.destinationNodeLabel.Size = new System.Drawing.Size(99, 13);
            this.destinationNodeLabel.TabIndex = 6;
            this.destinationNodeLabel.Text = "Titik Tujuan:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(12, 132);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(50, 13);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Bobot:";
            // 
            // sourceNodeTextBox
            // 
            this.sourceNodeTextBox.Location = new System.Drawing.Point(117, 77);
            this.sourceNodeTextBox.Name = "sourceNodeTextBox";
            this.sourceNodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sourceNodeTextBox.TabIndex = 8;
            // 
            // destinationNodeTextBox
            // 
            this.destinationNodeTextBox.Location = new System.Drawing.Point(117, 103);
            this.destinationNodeTextBox.Name = "destinationNodeTextBox";
            this.destinationNodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinationNodeTextBox.TabIndex = 9;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(117, 129);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 10;
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.Location = new System.Drawing.Point(223, 127);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(75, 23);
            this.addEdgeButton.TabIndex = 11;
            this.addEdgeButton.Text = "Tambahkan";
            this.addEdgeButton.UseVisualStyleBackColor = true;
            this.addEdgeButton.Click += new System.EventHandler(this.addEdgeButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(15, 180);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(283, 163);
            this.resultTextBox.TabIndex = 12;
            this.resultTextBox.Text = "";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 164);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 13);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Text = "Hasil:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 355);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.addEdgeButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.destinationNodeTextBox);
            this.Controls.Add(this.sourceNodeTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.destinationNodeLabel);
            this.Controls.Add(this.sourceNodeLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endNodeTextBox);
            this.Controls.Add(this.startNodeTextBox);
            this.Controls.Add(this.endNodeLabel);
            this.Controls.Add(this.startNodeLabel);
            this.Name = "MainForm";
            this.Text = "Dijkstra Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
