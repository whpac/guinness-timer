namespace GuinnessTimer
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
            components = new System.ComponentModel.Container();
            valueLabel = new Label();
            panel1 = new Panel();
            cancelPasswordButton = new Button();
            acceptPasswordButton = new Button();
            passwordTextBox = new TextBox();
            passwordPromptLabel = new Label();
            targetTextBox = new MaskedTextBox();
            targetLabel = new Label();
            panel2 = new Panel();
            resetButton = new Button();
            passwordLabel = new Label();
            stopButton = new Button();
            startButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            clocksPanel = new FlowLayoutPanel();
            timeLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            clocksPanel.SuspendLayout();
            SuspendLayout();
            // 
            // valueLabel
            // 
            valueLabel.ForeColor = Color.White;
            valueLabel.Location = new Point(3, 0);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new Size(731, 20);
            valueLabel.TabIndex = 0;
            valueLabel.Text = "00:00:00";
            valueLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(cancelPasswordButton);
            panel1.Controls.Add(acceptPasswordButton);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(passwordPromptLabel);
            panel1.Controls.Add(targetTextBox);
            panel1.Controls.Add(targetLabel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(startButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 240);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 67);
            panel1.TabIndex = 1;
            // 
            // cancelPasswordButton
            // 
            cancelPasswordButton.BackColor = Color.Black;
            cancelPasswordButton.ForeColor = Color.White;
            cancelPasswordButton.Location = new Point(273, 2);
            cancelPasswordButton.Name = "cancelPasswordButton";
            cancelPasswordButton.Size = new Size(84, 29);
            cancelPasswordButton.TabIndex = 8;
            cancelPasswordButton.Text = "Anuluj";
            cancelPasswordButton.UseVisualStyleBackColor = false;
            cancelPasswordButton.Click += cancelPasswordButton_Click;
            // 
            // acceptPasswordButton
            // 
            acceptPasswordButton.BackColor = Color.Black;
            acceptPasswordButton.ForeColor = Color.White;
            acceptPasswordButton.Location = new Point(213, 2);
            acceptPasswordButton.Name = "acceptPasswordButton";
            acceptPasswordButton.Size = new Size(54, 29);
            acceptPasswordButton.TabIndex = 7;
            acceptPasswordButton.Text = "OK";
            acceptPasswordButton.UseVisualStyleBackColor = false;
            acceptPasswordButton.Click += acceptPasswordButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.Black;
            passwordTextBox.ForeColor = Color.White;
            passwordTextBox.Location = new Point(59, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(148, 27);
            passwordTextBox.TabIndex = 6;
            // 
            // passwordPromptLabel
            // 
            passwordPromptLabel.AutoSize = true;
            passwordPromptLabel.ForeColor = Color.White;
            passwordPromptLabel.Location = new Point(3, 7);
            passwordPromptLabel.Name = "passwordPromptLabel";
            passwordPromptLabel.Size = new Size(50, 20);
            passwordPromptLabel.TabIndex = 5;
            passwordPromptLabel.Text = "Hasło:";
            // 
            // targetTextBox
            // 
            targetTextBox.BackColor = Color.Black;
            targetTextBox.ForeColor = Color.White;
            targetTextBox.Location = new Point(142, 34);
            targetTextBox.Mask = "##9\\:90\\:00";
            targetTextBox.Name = "targetTextBox";
            targetTextBox.Size = new Size(125, 27);
            targetTextBox.TabIndex = 4;
            targetTextBox.Text = "1000000";
            // 
            // targetLabel
            // 
            targetLabel.AutoSize = true;
            targetLabel.ForeColor = Color.White;
            targetLabel.Location = new Point(103, 37);
            targetLabel.Name = "targetLabel";
            targetLabel.Size = new Size(33, 20);
            targetLabel.TabIndex = 3;
            targetLabel.Text = "Cel:";
            // 
            // panel2
            // 
            panel2.Controls.Add(resetButton);
            panel2.Controls.Add(passwordLabel);
            panel2.Controls.Add(stopButton);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(477, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 67);
            panel2.TabIndex = 1;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.Black;
            resetButton.ForeColor = Color.White;
            resetButton.Location = new Point(155, 32);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 2;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(3, 11);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(246, 20);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Wstrzymanie stopera wymaga hasła";
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.Black;
            stopButton.ForeColor = Color.White;
            stopButton.Location = new Point(55, 32);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(94, 29);
            stopButton.TabIndex = 1;
            stopButton.Text = "Pauza";
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += stopButton_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Black;
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(3, 33);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 29);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // timer
            // 
            timer.Interval = 200;
            timer.Tick += timer_Tick;
            // 
            // clocksPanel
            // 
            clocksPanel.Controls.Add(valueLabel);
            clocksPanel.Controls.Add(timeLabel);
            clocksPanel.Dock = DockStyle.Fill;
            clocksPanel.FlowDirection = FlowDirection.TopDown;
            clocksPanel.Location = new Point(0, 0);
            clocksPanel.Name = "clocksPanel";
            clocksPanel.Size = new Size(731, 240);
            clocksPanel.TabIndex = 2;
            clocksPanel.WrapContents = false;
            clocksPanel.Layout += clocksPanel_Layout;
            // 
            // timeLabel
            // 
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(3, 20);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(731, 20);
            timeLabel.TabIndex = 1;
            timeLabel.Text = "00:00:00";
            timeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(731, 307);
            Controls.Add(clocksPanel);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MinimizeBox = false;
            MinimumSize = new Size(570, 150);
            Name = "Form1";
            ShowIcon = false;
            Text = "Stoper";
            TopMost = true;
            FormClosing += Form1_FormClosing;
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            clocksPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label valueLabel;
        private Panel panel1;
        private Button resetButton;
        private Button stopButton;
        private Button startButton;
        private Panel panel2;
        private Label passwordLabel;
        private System.Windows.Forms.Timer timer;
        private MaskedTextBox targetTextBox;
        private Label targetLabel;
        private TextBox passwordTextBox;
        private Label passwordPromptLabel;
        private Button acceptPasswordButton;
        private Button cancelPasswordButton;
        private FlowLayoutPanel clocksPanel;
        private Label timeLabel;
    }
}