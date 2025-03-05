namespace jurnalmod3_103022300069
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
            lblOutput = new Label();
            btnPlus = new Button();
            btnEqual = new Button();
            btnZero = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblOutput.BackColor = Color.Black;
            lblOutput.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutput.ForeColor = Color.White;
            lblOutput.Location = new Point(47, 50);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(287, 42);
            lblOutput.TabIndex = 0;
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(47, 116);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 23);
            btnPlus.TabIndex = 1;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(153, 116);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(75, 23);
            btnEqual.TabIndex = 2;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(259, 116);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(75, 23);
            btnZero.TabIndex = 3;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(47, 161);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(75, 23);
            btnOne.TabIndex = 4;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(153, 161);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(75, 23);
            btnTwo.TabIndex = 5;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(259, 161);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(75, 23);
            btnThree.TabIndex = 6;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(47, 205);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(75, 23);
            btnFour.TabIndex = 7;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(153, 205);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(75, 23);
            btnFive.TabIndex = 8;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(259, 205);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(75, 23);
            btnSix.TabIndex = 9;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(259, 245);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(75, 23);
            btnNine.TabIndex = 10;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(153, 245);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(75, 23);
            btnEight.TabIndex = 11;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(47, 245);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(75, 23);
            btnSeven.TabIndex = 12;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 317);
            Controls.Add(btnSeven);
            Controls.Add(btnEight);
            Controls.Add(btnNine);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnZero);
            Controls.Add(btnEqual);
            Controls.Add(btnPlus);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblOutput;
        private Button btnPlus;
        private Button btnEqual;
        private Button btnZero;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
    }
}
