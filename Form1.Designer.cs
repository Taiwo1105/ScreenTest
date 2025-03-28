
namespace ScreenTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnmcu = new Button();
            btntrivia = new Button();
            btnclassic = new Button();
            btnanimated = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnmcu
            // 
            btnmcu.AccessibleName = "btnmcu";
            btnmcu.Font = new Font("Elephant", 9.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmcu.ForeColor = Color.FromArgb(0, 0, 64);
            btnmcu.Location = new Point(278, 229);
            btnmcu.Name = "btnmcu";
            btnmcu.Size = new Size(449, 34);
            btnmcu.TabIndex = 0;
            btnmcu.Text = "Marvel Cinematic Universe (MCU) Legends";
            btnmcu.UseVisualStyleBackColor = true;
            btnmcu.Click += btnMCU_Click;
            // 
            // btntrivia
            // 
            btntrivia.AccessibleName = "btntrivia";
            btntrivia.Font = new Font("Elephant", 9.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntrivia.Location = new Point(278, 298);
            btntrivia.Name = "btntrivia";
            btntrivia.Size = new Size(381, 34);
            btntrivia.TabIndex = 1;
            btntrivia.Text = "Hollywood Blockbuster Trivia";
            btntrivia.UseVisualStyleBackColor = true;
            btntrivia.Click += btnTrivia_Click;
            // 
            // btnclassic
            // 
            btnclassic.AccessibleName = "btnclassic";
            btnclassic.Font = new Font("Elephant", 9.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclassic.Location = new Point(278, 365);
            btnclassic.Name = "btnclassic";
            btnclassic.Size = new Size(375, 34);
            btnclassic.TabIndex = 2;
            btnclassic.Text = "Classic Movie Mastery";
            btnclassic.UseVisualStyleBackColor = true;
            btnclassic.Click += btnClassic_Click;
            // 
            // btnanimated
            // 
            btnanimated.AccessibleName = "btnanimated";
            btnanimated.Font = new Font("Elephant", 9.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnanimated.Location = new Point(278, 434);
            btnanimated.Name = "btnanimated";
            btnanimated.Size = new Size(381, 34);
            btnanimated.TabIndex = 3;
            btnanimated.Text = "Animated Film Adventures";
            btnanimated.UseVisualStyleBackColor = true;
            btnanimated.Click += btnAnimated_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 0);
            label1.Location = new Point(141, 72);
            label1.Name = "label1";
            label1.Size = new Size(605, 85);
            label1.TabIndex = 4;
            label1.Text = "SELECT A QUIZ TOPIC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(947, 597);
            Controls.Add(label1);
            Controls.Add(btnmcu);
            Controls.Add(btntrivia);
            Controls.Add(btnclassic);
            Controls.Add(btnanimated);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        #endregion

        private Button btnmcu;
        private Button btntrivia;
        private Button btnclassic;
        private Button btnanimated;
        private Label label1;
    }
}
