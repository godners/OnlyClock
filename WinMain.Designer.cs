namespace OnlyClock
{
	internal partial class CF
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CF));
			this.L = new OnlyClock.CF.CL();
			this.P = new OnlyClock.CF.CP();
			this.T = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.P)).BeginInit();
			this.SuspendLayout();
			// 
			// L
			// 
			this.L.CausesValidation = false;
			this.L.Location = new System.Drawing.Point(75, 0);
			this.L.Margin = new System.Windows.Forms.Padding(0);
			this.L.Name = "L";
			this.L.Size = new System.Drawing.Size(417, 75);
			this.L.TabIndex = 0;
			this.L.Text = "88:88:88.00";
			this.L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.L.UseMnemonic = false;
			this.L.Click += new System.EventHandler(this.MC);
			this.L.DoubleClick += new System.EventHandler(this.MC);
			this.L.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MC);
			this.L.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MC);
			// 
			// P
			// 
			this.P.Image = global::OnlyClock.Properties.Resources.OnlyClock;
			this.P.Location = new System.Drawing.Point(0, 0);
			this.P.Margin = new System.Windows.Forms.Padding(0);
			this.P.Name = "P";
			this.P.Size = new System.Drawing.Size(75, 75);
			this.P.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.P.TabIndex = 1;
			this.P.TabStop = false;
			this.P.Click += new System.EventHandler(this.MC);
			this.P.DoubleClick += new System.EventHandler(this.MC);
			this.P.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MC);
			this.P.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MC);
			// 
			// T
			// 
			this.T.Enabled = true;
			this.T.Interval = 10;
			this.T.Tick += new System.EventHandler(this.W);
			// 
			// F
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(492, 75);
			this.ControlBox = false;
			this.Controls.Add(this.P);
			this.Controls.Add(this.L);
			this.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "F";
			this.Opacity = 0.8D;
			this.Text = "Only Clock";
			this.TopMost = true;
			this.Click += new System.EventHandler(this.MC);
			this.DoubleClick += new System.EventHandler(this.MC);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MC);
			this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MC);
			((System.ComponentModel.ISupportInitialize)(this.P)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CL L;
		private CP P;
		private System.Windows.Forms.Timer T;
	}
}

