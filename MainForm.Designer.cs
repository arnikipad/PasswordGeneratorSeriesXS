namespace PasswordGeneratorSeriesXS;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private Panel bootPanel = null!;
    private Label titleLabel = null!;
    private Label statusLabel = null!;
    private ProgressBar bootProgress = null!;
    private Panel generatorPanel = null!;
    private Label generatorTitle = null!;
    private TextBox passwordBox = null!;
    private NumericUpDown lengthBox = null!;
    private Button generateButton = null!;
    private Button copyButton = null!;
    private Label lengthLabel = null!;
    private Label strengthLabel = null!;
    private CheckBox symbolsCheck = null!;
    private CheckBox numbersCheck = null!;
    private CheckBox uppercaseCheck = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        bootPanel = new Panel();
        titleLabel = new Label();
        statusLabel = new Label();
        bootProgress = new ProgressBar();
        generatorPanel = new Panel();
        generatorTitle = new Label();
        passwordBox = new TextBox();
        lengthBox = new NumericUpDown();
        generateButton = new Button();
        copyButton = new Button();
        lengthLabel = new Label();
        strengthLabel = new Label();
        symbolsCheck = new CheckBox();
        numbersCheck = new CheckBox();
        uppercaseCheck = new CheckBox();

        bootPanel.SuspendLayout();
        generatorPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)lengthBox).BeginInit();
        SuspendLayout();

        bootPanel.BackColor = Color.FromArgb(4, 12, 8);
        bootPanel.Dock = DockStyle.Fill;
        bootPanel.Controls.Add(titleLabel);
        bootPanel.Controls.Add(statusLabel);
        bootPanel.Controls.Add(bootProgress);

        titleLabel.AutoSize = false;
        titleLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
        titleLabel.ForeColor = Color.FromArgb(80, 255, 150);
        titleLabel.Location = new Point(40, 105);
        titleLabel.Size = new Size(820, 70);
        titleLabel.Text = "PASSWORD GENERATOR";
        titleLabel.TextAlign = ContentAlignment.MiddleCenter;

        statusLabel.AutoSize = false;
        statusLabel.Font = new Font("Consolas", 13F);
        statusLabel.ForeColor = Color.FromArgb(120, 255, 175);
        statusLabel.Location = new Point(40, 195);
        statusLabel.Size = new Size(820, 45);
        statusLabel.Text = "INITIALIZING SECURITY SYSTEM...";
        statusLabel.TextAlign = ContentAlignment.MiddleCenter;

        bootProgress.Location = new Point(180, 275);
        bootProgress.Size = new Size(540, 18);
        bootProgress.Style = ProgressBarStyle.Continuous;
        bootProgress.Minimum = 0;
        bootProgress.Maximum = 100;

        generatorPanel.BackColor = Color.FromArgb(8, 18, 13);
        generatorPanel.Dock = DockStyle.Fill;
        generatorPanel.Controls.Add(generatorTitle);
        generatorPanel.Controls.Add(passwordBox);
        generatorPanel.Controls.Add(lengthLabel);
        generatorPanel.Controls.Add(lengthBox);
        generatorPanel.Controls.Add(uppercaseCheck);
        generatorPanel.Controls.Add(numbersCheck);
        generatorPanel.Controls.Add(symbolsCheck);
        generatorPanel.Controls.Add(generateButton);
        generatorPanel.Controls.Add(copyButton);
        generatorPanel.Controls.Add(strengthLabel);
        generatorPanel.Visible = false;

        generatorTitle.AutoSize = false;
        generatorTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        generatorTitle.ForeColor = Color.FromArgb(80, 255, 150);
        generatorTitle.Location = new Point(30, 25);
        generatorTitle.Size = new Size(840, 55);
        generatorTitle.Text = "PASSWORD GENERATOR";
        generatorTitle.TextAlign = ContentAlignment.MiddleCenter;

        passwordBox.Font = new Font("Consolas", 18F);
        passwordBox.Location = new Point(100, 110);
        passwordBox.Size = new Size(700, 40);
        passwordBox.ReadOnly = true;
        passwordBox.BackColor = Color.FromArgb(15, 30, 22);
        passwordBox.ForeColor = Color.FromArgb(100, 255, 160);
        passwordBox.BorderStyle = BorderStyle.FixedSingle;

        lengthLabel.AutoSize = true;
        lengthLabel.Font = new Font("Segoe UI", 11F);
        lengthLabel.ForeColor = Color.White;
        lengthLabel.Location = new Point(100, 180);
        lengthLabel.Text = "Length:";

        lengthBox.Location = new Point(165, 177);
        lengthBox.Minimum = 8;
        lengthBox.Maximum = 64;
        lengthBox.Value = 20;
        lengthBox.Width = 75;

        uppercaseCheck.AutoSize = true;
        uppercaseCheck.Checked = true;
        uppercaseCheck.ForeColor = Color.White;
        uppercaseCheck.Location = new Point(270, 180);
        uppercaseCheck.Text = "A-Z";

        numbersCheck.AutoSize = true;
        numbersCheck.Checked = true;
        numbersCheck.ForeColor = Color.White;
        numbersCheck.Location = new Point(340, 180);
        numbersCheck.Text = "0-9";

        symbolsCheck.AutoSize = true;
        symbolsCheck.Checked = true;
        symbolsCheck.ForeColor = Color.White;
        symbolsCheck.Location = new Point(410, 180);
        symbolsCheck.Text = "Symbols";

        generateButton.Location = new Point(100, 235);
        generateButton.Size = new Size(330, 50);
        generateButton.Text = "GENERATE";
        generateButton.BackColor = Color.FromArgb(20, 120, 65);
        generateButton.ForeColor = Color.White;
        generateButton.FlatStyle = FlatStyle.Flat;
        generateButton.Click += generateButton_Click;

        copyButton.Location = new Point(470, 235);
        copyButton.Size = new Size(330, 50);
        copyButton.Text = "COPY";
        copyButton.BackColor = Color.FromArgb(25, 80, 55);
        copyButton.ForeColor = Color.White;
        copyButton.FlatStyle = FlatStyle.Flat;
        copyButton.Click += copyButton_Click;

        strengthLabel.AutoSize = false;
        strengthLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        strengthLabel.ForeColor = Color.FromArgb(100, 255, 160);
        strengthLabel.Location = new Point(100, 305);
        strengthLabel.Size = new Size(700, 35);
        strengthLabel.Text = "STRENGTH: READY";
        strengthLabel.TextAlign = ContentAlignment.MiddleCenter;

        ClientSize = new Size(900, 500);
        Controls.Add(bootPanel);
        Controls.Add(generatorPanel);
        MinimumSize = new Size(900, 500);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Password Generator — Series X|S Edition";
        BackColor = Color.FromArgb(8, 18, 13);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Load += MainForm_Load;

        bootPanel.ResumeLayout(false);
        generatorPanel.ResumeLayout(false);
        generatorPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)lengthBox).EndInit();
        ResumeLayout(false);
    }
}
