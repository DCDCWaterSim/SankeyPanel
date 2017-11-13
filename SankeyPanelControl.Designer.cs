namespace SankeyPanel
{
    partial class SankeyPanelControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sankeyGraph1 = new ConsumerResourceModelFramework.SankeyGraph();
            this.sankeyGraph1_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.sankeyGraph1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(488, 310);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // sankeyGraph1
            // 
            this.sankeyGraph1.FlowBarDrawOrder = ConsumerResourceModelFramework.SankeyGraph.DrawOrder.doBottomUp;
            this.sankeyGraph1.Location = new System.Drawing.Point(3, 3);
            this.sankeyGraph1.Name = "sankeyGraph1";
            this.sankeyGraph1.NegativeColor = System.Drawing.Color.Red;
            this.sankeyGraph1.Network = null;
            this.sankeyGraph1.NetworkBackground = System.Drawing.Color.Black;
            this.sankeyGraph1.PositiveColor = System.Drawing.Color.YellowGreen;
            this.sankeyGraph1.Size = new System.Drawing.Size(478, 294);
            this.sankeyGraph1.TabIndex = 0;
            // 
            // sankeyGraph1_label
            // 
            this.sankeyGraph1_label.AutoSize = true;
            this.sankeyGraph1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sankeyGraph1_label.Location = new System.Drawing.Point(10, 15);
            this.sankeyGraph1_label.Name = "sankeyGraph1_label";
            this.sankeyGraph1_label.Size = new System.Drawing.Size(126, 24);
            this.sankeyGraph1_label.TabIndex = 3;
            this.sankeyGraph1_label.Text = "sankey Graph";
            // 
            // SankeyPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sankeyGraph1_label);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SankeyPanelControl";
            this.Size = new System.Drawing.Size(507, 374);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ConsumerResourceModelFramework.SankeyGraph sankeyGraph1;
        private System.Windows.Forms.Label sankeyGraph1_label;
    }
}
