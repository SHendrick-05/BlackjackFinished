namespace Blackjack
{
    partial class Main
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
            this.top = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.playerCard3 = new System.Windows.Forms.PictureBox();
            this.playerCard4 = new System.Windows.Forms.PictureBox();
            this.playerCard5 = new System.Windows.Forms.PictureBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.dealer1 = new System.Windows.Forms.PictureBox();
            this.dealer2 = new System.Windows.Forms.PictureBox();
            this.dealer3 = new System.Windows.Forms.PictureBox();
            this.dealer4 = new System.Windows.Forms.PictureBox();
            this.dealer5 = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.replayButton = new System.Windows.Forms.Button();
            this.dealerValueLabel = new System.Windows.Forms.Label();
            this.winLossLabel = new System.Windows.Forms.Label();
            this.playerHand = new System.Windows.Forms.Panel();
            this.split1Hand = new System.Windows.Forms.Panel();
            this.s11 = new System.Windows.Forms.PictureBox();
            this.split1Value = new System.Windows.Forms.Label();
            this.s12 = new System.Windows.Forms.PictureBox();
            this.s13 = new System.Windows.Forms.PictureBox();
            this.s14 = new System.Windows.Forms.PictureBox();
            this.s15 = new System.Windows.Forms.PictureBox();
            this.split2Hand = new System.Windows.Forms.Panel();
            this.split2Value = new System.Windows.Forms.Label();
            this.s21 = new System.Windows.Forms.PictureBox();
            this.s22 = new System.Windows.Forms.PictureBox();
            this.s23 = new System.Windows.Forms.PictureBox();
            this.s24 = new System.Windows.Forms.PictureBox();
            this.s25 = new System.Windows.Forms.PictureBox();
            this.splitButton = new System.Windows.Forms.Button();
            this.s1Label = new System.Windows.Forms.Label();
            this.s2Label = new System.Windows.Forms.Label();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer5)).BeginInit();
            this.playerHand.SuspendLayout();
            this.split1Hand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s15)).BeginInit();
            this.split2Hand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s25)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.top.Controls.Add(this.title);
            this.top.Controls.Add(this.close);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1470, 37);
            this.top.TabIndex = 0;
            this.top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(3, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(108, 24);
            this.title.TabIndex = 1;
            this.title.Text = "Blackjack";
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.Location = new System.Drawing.Point(1375, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(95, 37);
            this.close.TabIndex = 0;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // playerCard1
            // 
            this.playerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerCard1.Location = new System.Drawing.Point(13, 13);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(125, 181);
            this.playerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerCard1.TabIndex = 1;
            this.playerCard1.TabStop = false;
            // 
            // hitButton
            // 
            this.hitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(196)))));
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.hitButton.Location = new System.Drawing.Point(12, 279);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(142, 37);
            this.hitButton.TabIndex = 2;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.standButton.Location = new System.Drawing.Point(12, 322);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(142, 37);
            this.standButton.TabIndex = 3;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // playerCard2
            // 
            this.playerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerCard2.Location = new System.Drawing.Point(144, 13);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(125, 181);
            this.playerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerCard2.TabIndex = 5;
            this.playerCard2.TabStop = false;
            // 
            // playerCard3
            // 
            this.playerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerCard3.Location = new System.Drawing.Point(275, 13);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(125, 181);
            this.playerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerCard3.TabIndex = 6;
            this.playerCard3.TabStop = false;
            // 
            // playerCard4
            // 
            this.playerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerCard4.Location = new System.Drawing.Point(406, 13);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(125, 181);
            this.playerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerCard4.TabIndex = 7;
            this.playerCard4.TabStop = false;
            // 
            // playerCard5
            // 
            this.playerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerCard5.Location = new System.Drawing.Point(537, 13);
            this.playerCard5.Name = "playerCard5";
            this.playerCard5.Size = new System.Drawing.Size(125, 181);
            this.playerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerCard5.TabIndex = 8;
            this.playerCard5.TabStop = false;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.valueLabel.Location = new System.Drawing.Point(49, 443);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(62, 30);
            this.valueLabel.TabIndex = 9;
            this.valueLabel.Text = "0/21";
            // 
            // dealer1
            // 
            this.dealer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dealer1.Location = new System.Drawing.Point(255, 43);
            this.dealer1.Name = "dealer1";
            this.dealer1.Size = new System.Drawing.Size(86, 125);
            this.dealer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dealer1.TabIndex = 10;
            this.dealer1.TabStop = false;
            // 
            // dealer2
            // 
            this.dealer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dealer2.Location = new System.Drawing.Point(347, 43);
            this.dealer2.Name = "dealer2";
            this.dealer2.Size = new System.Drawing.Size(86, 125);
            this.dealer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dealer2.TabIndex = 11;
            this.dealer2.TabStop = false;
            // 
            // dealer3
            // 
            this.dealer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dealer3.Location = new System.Drawing.Point(439, 43);
            this.dealer3.Name = "dealer3";
            this.dealer3.Size = new System.Drawing.Size(86, 125);
            this.dealer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dealer3.TabIndex = 12;
            this.dealer3.TabStop = false;
            // 
            // dealer4
            // 
            this.dealer4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dealer4.Location = new System.Drawing.Point(531, 43);
            this.dealer4.Name = "dealer4";
            this.dealer4.Size = new System.Drawing.Size(86, 125);
            this.dealer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dealer4.TabIndex = 13;
            this.dealer4.TabStop = false;
            // 
            // dealer5
            // 
            this.dealer5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dealer5.Location = new System.Drawing.Point(623, 43);
            this.dealer5.Name = "dealer5";
            this.dealer5.Size = new System.Drawing.Size(86, 125);
            this.dealer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dealer5.TabIndex = 14;
            this.dealer5.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.statusLabel.Location = new System.Drawing.Point(160, 207);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(649, 30);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.Text = "label1";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusLabel.Visible = false;
            // 
            // replayButton
            // 
            this.replayButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.replayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replayButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.replayButton.Location = new System.Drawing.Point(12, 131);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(142, 37);
            this.replayButton.TabIndex = 16;
            this.replayButton.Text = "Play again";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Visible = false;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // dealerValueLabel
            // 
            this.dealerValueLabel.AutoSize = true;
            this.dealerValueLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dealerValueLabel.Location = new System.Drawing.Point(747, 92);
            this.dealerValueLabel.Name = "dealerValueLabel";
            this.dealerValueLabel.Size = new System.Drawing.Size(62, 30);
            this.dealerValueLabel.TabIndex = 17;
            this.dealerValueLabel.Text = "0/21";
            // 
            // winLossLabel
            // 
            this.winLossLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLossLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.winLossLabel.Location = new System.Drawing.Point(12, 207);
            this.winLossLabel.Name = "winLossLabel";
            this.winLossLabel.Size = new System.Drawing.Size(142, 30);
            this.winLossLabel.TabIndex = 18;
            this.winLossLabel.Text = "0-0-0";
            this.winLossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerHand
            // 
            this.playerHand.Controls.Add(this.playerCard1);
            this.playerHand.Controls.Add(this.playerCard2);
            this.playerHand.Controls.Add(this.playerCard3);
            this.playerHand.Controls.Add(this.playerCard4);
            this.playerHand.Controls.Add(this.playerCard5);
            this.playerHand.Location = new System.Drawing.Point(195, 279);
            this.playerHand.Name = "playerHand";
            this.playerHand.Padding = new System.Windows.Forms.Padding(10);
            this.playerHand.Size = new System.Drawing.Size(675, 207);
            this.playerHand.TabIndex = 19;
            // 
            // split1Hand
            // 
            this.split1Hand.Controls.Add(this.s11);
            this.split1Hand.Controls.Add(this.split1Value);
            this.split1Hand.Controls.Add(this.s12);
            this.split1Hand.Controls.Add(this.s13);
            this.split1Hand.Controls.Add(this.s14);
            this.split1Hand.Controls.Add(this.s15);
            this.split1Hand.Location = new System.Drawing.Point(17, 510);
            this.split1Hand.Name = "split1Hand";
            this.split1Hand.Padding = new System.Windows.Forms.Padding(10);
            this.split1Hand.Size = new System.Drawing.Size(675, 240);
            this.split1Hand.TabIndex = 20;
            // 
            // s11
            // 
            this.s11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.s11.Location = new System.Drawing.Point(13, 13);
            this.s11.Name = "s11";
            this.s11.Size = new System.Drawing.Size(125, 181);
            this.s11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.s11.TabIndex = 1;
            this.s11.TabStop = false;
            // 
            // split1Value
            // 
            this.split1Value.AutoSize = true;
            this.split1Value.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.split1Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.split1Value.Location = new System.Drawing.Point(300, 200);
            this.split1Value.Name = "split1Value";
            this.split1Value.Size = new System.Drawing.Size(62, 30);
            this.split1Value.TabIndex = 21;
            this.split1Value.Text = "0/21";
            // 
            // s12
            // 
            this.s12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.s12.Location = new System.Drawing.Point(144, 13);
            this.s12.Name = "s12";
            this.s12.Size = new System.Drawing.Size(125, 181);
            this.s12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.s12.TabIndex = 5;
            this.s12.TabStop = false;
            // 
            // s13
            // 
            this.s13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.s13.Location = new System.Drawing.Point(275, 13);
            this.s13.Name = "s13";
            this.s13.Size = new System.Drawing.Size(125, 181);
            this.s13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.s13.TabIndex = 6;
            this.s13.TabStop = false;
            // 
            // s14
            // 
            this.s14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.s14.Location = new System.Drawing.Point(406, 13);
            this.s14.Name = "s14";
            this.s14.Size = new System.Drawing.Size(125, 181);
            this.s14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.s14.TabIndex = 7;
            this.s14.TabStop = false;
            // 
            // s15
            // 
            this.s15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.s15.Location = new System.Drawing.Point(537, 13);
            this.s15.Name = "s15";
            this.s15.Size = new System.Drawing.Size(125, 181);
            this.s15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.s15.TabIndex = 8;
            this.s15.TabStop = false;
            // 
            // split2Hand
            // 
            this.split2Hand.Controls.Add(this.split2Value);
            this.split2Hand.Controls.Add(this.s21);
            this.split2Hand.Controls.Add(this.s22);
            this.split2Hand.Controls.Add(this.s23);
            this.split2Hand.Controls.Add(this.s24);
            this.split2Hand.Controls.Add(this.s25);
            this.split2Hand.Location = new System.Drawing.Point(773, 510);
            this.split2Hand.Name = "split2Hand";
            this.split2Hand.Padding = new System.Windows.Forms.Padding(10);
            this.split2Hand.Size = new System.Drawing.Size(675, 240);
            this.split2Hand.TabIndex = 20;
            // 
            // split2Value
            // 
            this.split2Value.AutoSize = true;
            this.split2Value.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.split2Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.split2Value.Location = new System.Drawing.Point(309, 200);
            this.split2Value.Name = "split2Value";
            this.split2Value.Size = new System.Drawing.Size(62, 30);
            this.split2Value.TabIndex = 22;
            this.split2Value.Text = "0/21";
            // 
            // s21
            // 
            this.s21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.s21.Location = new System.Drawing.Point(13, 13);
            this.s21.Name = "s21";
            this.s21.Size = new System.Drawing.Size(125, 181);
            this.s21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.s21.TabIndex = 1;
            this.s21.TabStop = false;
            // 
            // s22
            // 
            this.s22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.s22.Location = new System.Drawing.Point(144, 13);
            this.s22.Name = "s22";
            this.s22.Size = new System.Drawing.Size(125, 181);
            this.s22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.s22.TabIndex = 5;
            this.s22.TabStop = false;
            // 
            // s23
            // 
            this.s23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.s23.Location = new System.Drawing.Point(275, 13);
            this.s23.Name = "s23";
            this.s23.Size = new System.Drawing.Size(125, 181);
            this.s23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.s23.TabIndex = 6;
            this.s23.TabStop = false;
            // 
            // s24
            // 
            this.s24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.s24.Location = new System.Drawing.Point(406, 13);
            this.s24.Name = "s24";
            this.s24.Size = new System.Drawing.Size(125, 181);
            this.s24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.s24.TabIndex = 7;
            this.s24.TabStop = false;
            // 
            // s25
            // 
            this.s25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.s25.Location = new System.Drawing.Point(537, 13);
            this.s25.Name = "s25";
            this.s25.Size = new System.Drawing.Size(125, 181);
            this.s25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.s25.TabIndex = 8;
            this.s25.TabStop = false;
            // 
            // splitButton
            // 
            this.splitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.splitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.splitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.splitButton.Location = new System.Drawing.Point(12, 365);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(142, 37);
            this.splitButton.TabIndex = 21;
            this.splitButton.Text = "Split";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Visible = false;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // s1Label
            // 
            this.s1Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s1Label.ForeColor = System.Drawing.SystemColors.Control;
            this.s1Label.Location = new System.Drawing.Point(25, 489);
            this.s1Label.Name = "s1Label";
            this.s1Label.Size = new System.Drawing.Size(654, 30);
            this.s1Label.TabIndex = 22;
            this.s1Label.Text = "BUST";
            this.s1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.s1Label.Visible = false;
            // 
            // s2Label
            // 
            this.s2Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s2Label.ForeColor = System.Drawing.SystemColors.Control;
            this.s2Label.Location = new System.Drawing.Point(781, 490);
            this.s2Label.Name = "s2Label";
            this.s2Label.Size = new System.Drawing.Size(654, 30);
            this.s2Label.TabIndex = 23;
            this.s2Label.Text = "BUST";
            this.s2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.s2Label.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1470, 762);
            this.Controls.Add(this.s2Label);
            this.Controls.Add(this.s1Label);
            this.Controls.Add(this.splitButton);
            this.Controls.Add(this.split2Hand);
            this.Controls.Add(this.split1Hand);
            this.Controls.Add(this.playerHand);
            this.Controls.Add(this.winLossLabel);
            this.Controls.Add(this.dealerValueLabel);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dealer5);
            this.Controls.Add(this.dealer4);
            this.Controls.Add(this.dealer3);
            this.Controls.Add(this.dealer2);
            this.Controls.Add(this.dealer1);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer5)).EndInit();
            this.playerHand.ResumeLayout(false);
            this.split1Hand.ResumeLayout(false);
            this.split1Hand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s15)).EndInit();
            this.split2Hand.ResumeLayout(false);
            this.split2Hand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.PictureBox playerCard3;
        private System.Windows.Forms.PictureBox playerCard4;
        private System.Windows.Forms.PictureBox playerCard5;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.PictureBox dealer1;
        private System.Windows.Forms.PictureBox dealer2;
        private System.Windows.Forms.PictureBox dealer3;
        private System.Windows.Forms.PictureBox dealer4;
        private System.Windows.Forms.PictureBox dealer5;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Label dealerValueLabel;
        private System.Windows.Forms.Label winLossLabel;
        private System.Windows.Forms.Panel playerHand;
        private System.Windows.Forms.Panel split1Hand;
        private System.Windows.Forms.PictureBox s11;
        private System.Windows.Forms.Label split1Value;
        private System.Windows.Forms.PictureBox s12;
        private System.Windows.Forms.PictureBox s13;
        private System.Windows.Forms.PictureBox s14;
        private System.Windows.Forms.PictureBox s15;
        private System.Windows.Forms.Panel split2Hand;
        private System.Windows.Forms.Label split2Value;
        private System.Windows.Forms.PictureBox s21;
        private System.Windows.Forms.PictureBox s22;
        private System.Windows.Forms.PictureBox s23;
        private System.Windows.Forms.PictureBox s24;
        private System.Windows.Forms.PictureBox s25;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Label s1Label;
        private System.Windows.Forms.Label s2Label;
    }
}

