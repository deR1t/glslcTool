namespace glslcTool
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
            this.binput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.previewbutton = new System.Windows.Forms.Button();
            this.compilebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.debugCube = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bstage = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // binput
            // 
            this.binput.AllowDrop = true;
            this.binput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.binput.Location = new System.Drawing.Point(70, 12);
            this.binput.Name = "binput";
            this.binput.Size = new System.Drawing.Size(509, 20);
            this.binput.TabIndex = 0;
            this.binput.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropLogic);
            this.binput.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragDropEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.previewbutton);
            this.panel1.Controls.Add(this.compilebutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 49);
            this.panel1.TabIndex = 1;
            // 
            // previewbutton
            // 
            this.previewbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.previewbutton.Location = new System.Drawing.Point(376, 14);
            this.previewbutton.Name = "previewbutton";
            this.previewbutton.Size = new System.Drawing.Size(122, 23);
            this.previewbutton.TabIndex = 0;
            this.previewbutton.Text = "Preview Command";
            this.previewbutton.UseVisualStyleBackColor = true;
            this.previewbutton.Click += new System.EventHandler(this.compilebutton_Click);
            // 
            // compilebutton
            // 
            this.compilebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.compilebutton.Location = new System.Drawing.Point(504, 14);
            this.compilebutton.Name = "compilebutton";
            this.compilebutton.Size = new System.Drawing.Size(75, 23);
            this.compilebutton.TabIndex = 0;
            this.compilebutton.Text = "Compile";
            this.compilebutton.UseVisualStyleBackColor = true;
            this.compilebutton.Click += new System.EventHandler(this.compilebutton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boutput
            // 
            this.boutput.AllowDrop = true;
            this.boutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boutput.Location = new System.Drawing.Point(70, 38);
            this.boutput.Name = "boutput";
            this.boutput.Size = new System.Drawing.Size(509, 20);
            this.boutput.TabIndex = 0;
            this.boutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropLogic);
            this.boutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragDropEnter);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // debugCube
            // 
            this.debugCube.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debugCube.Location = new System.Drawing.Point(12, 119);
            this.debugCube.Multiline = true;
            this.debugCube.Name = "debugCube";
            this.debugCube.ReadOnly = true;
            this.debugCube.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugCube.Size = new System.Drawing.Size(567, 255);
            this.debugCube.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stage";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bstage
            // 
            this.bstage.FormattingEnabled = true;
            this.bstage.Items.AddRange(new object[] {
            "vertex",
            "fragment",
            "tesseval",
            "tesscontrol",
            "geometry",
            "compute"});
            this.bstage.Location = new System.Drawing.Point(70, 64);
            this.bstage.Name = "bstage";
            this.bstage.Size = new System.Drawing.Size(121, 21);
            this.bstage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 439);
            this.Controls.Add(this.bstage);
            this.Controls.Add(this.debugCube);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boutput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.binput);
            this.Name = "Form1";
            this.Text = "GLSLC";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox binput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button compilebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox debugCube;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bstage;
        private System.Windows.Forms.Button previewbutton;
    }
}

