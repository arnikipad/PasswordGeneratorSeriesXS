using System.Media;
using System.Security.Cryptography;

namespace PasswordGeneratorSeriesXS;

public partial class MainForm : Form
{
    private readonly RandomNumberGenerator rng = RandomNumberGenerator.Create();
    private SoundPlayer? startupSound;
    private int bootValue;
    private readonly System.Windows.Forms.Timer bootTimer = new();

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object? sender, EventArgs e)
    {
        try
        {
            string wavPath = Path.Combine(AppContext.BaseDirectory, "Assets", "startup_real.wav");
            if (File.Exists(wavPath))
            {
                startupSound = new SoundPlayer(wavPath);
                startupSound.Play();
            }
        }
        catch { }

        bootTimer.Interval = 35;
        bootTimer.Tick += BootTimer_Tick;
        bootTimer.Start();
    }

    private void BootTimer_Tick(object? sender, EventArgs e)
    {
        bootValue = Math.Min(100, bootValue + 2);
        bootProgress.Value = bootValue;

        statusLabel.Text = bootValue switch
        {
            < 25 => "INITIALIZING SECURITY SYSTEM...",
            < 50 => "LOADING RANDOM ENGINE...",
            < 75 => "VERIFYING ENTROPY...",
            < 100 => "STARTING PASSWORD GENERATOR...",
            _ => "SYSTEM READY"
        };

        if (bootValue >= 100)
        {
            bootTimer.Stop();
            bootPanel.Visible = false;
            generatorPanel.Visible = true;
            GeneratePassword();
        }
    }

    private void generateButton_Click(object? sender, EventArgs e) => GeneratePassword();

    private void copyButton_Click(object? sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(passwordBox.Text))
            Clipboard.SetText(passwordBox.Text);
        strengthLabel.Text = "PASSWORD COPIED TO CLIPBOARD";
    }

    private void GeneratePassword()
    {
        const string lower = "abcdefghijklmnopqrstuvwxyz";
        const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string numbers = "0123456789";
        const string symbols = "!@#$%^&*()-_=+[]{};:,.?";

        string pool = lower;
        if (uppercaseCheck.Checked) pool += upper;
        if (numbersCheck.Checked) pool += numbers;
        if (symbolsCheck.Checked) pool += symbols;

        int length = (int)lengthBox.Value;
        char[] result = new char[length];

        for (int i = 0; i < result.Length; i++)
            result[i] = pool[RandomIndex(pool.Length)];

        passwordBox.Text = new string(result);
        strengthLabel.Text = $"STRENGTH: {CalculateStrength(length, pool.Length)}";
    }

    private int RandomIndex(int max)
    {
        Span<byte> bytes = stackalloc byte[4];
        rng.GetBytes(bytes);
        return (int)(BitConverter.ToUInt32(bytes) % (uint)max);
    }

    private static string CalculateStrength(int length, int poolSize)
    {
        double entropy = length * Math.Log2(poolSize);
        return entropy switch
        {
            < 60 => "MODERATE",
            < 90 => "STRONG",
            _ => "VERY STRONG"
        };
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            bootTimer.Dispose();
            startupSound?.Dispose();
            rng.Dispose();
        }
        base.Dispose(disposing);
    }
}
