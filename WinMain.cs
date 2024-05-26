using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OnlyClock
{
	internal partial class CF : Form
	{
		public CF () => InitializeComponent();
		private void W () => L.Text = DateTime.Now.ToString("HH:mm:ss.ff");
		private void W (Object O, EventArgs E) => W();
		private readonly Dictionary<Int32, Int32[]> SD = new Dictionary<Int32, Int32[]>
		{
			{ 0, new Int32[] { 9, 9, 9, 226, 226, 226 } },
			{ 1, new Int32[] { 255, 255, 255, 30, 30, 30 } }, { 2, new Int32[] {225, 44, 15, 36, 30, 30 } },
			{ 3, new Int32[] { 36, 221, 34, 36, 30, 30 } }, { 4, new Int32[] { 233, 93, 15, 36, 30, 30 } }
		};
		private Int32 SP = 0;
		private Color SF => Color.FromArgb(SD[SP][0], SD[SP][1], SD[SP][2]);
		private Color SB => Color.FromArgb(SD[SP][3], SD[SP][4], SD[SP][5]);
		private void SN () { SP += 1; SP %= 5; ForeColor = SF; BackColor = SB; L.ForeColor = SF; L.BackColor = SB; P.BackColor = SB; }
		private void MC (Object O, EventArgs E) => MC(O, (MouseEventArgs)E);
		private void MC (Object O, MouseEventArgs E) { if (E.Button == CC.ML) SN(); if (E.Button == CC.MR) Application.Exit(); }
		private Point FP = new Point();
		protected override void OnMouseDown (MouseEventArgs E) { FP = CC.SE(E); base.OnMouseDown(E); }
		protected override void OnMouseMove (MouseEventArgs E)
		{ if (CC.MLR(E)) { Point MP = MousePosition; MP.Offset(FP); DesktopLocation = MP; } base.OnMouseMove(E); }

		internal class CL : Label
		{
			private Point FP = new Point();
			protected override void OnMouseDown (MouseEventArgs E) { FP = CC.SE(E); base.OnMouseDown(E); }
			protected override void OnMouseMove (MouseEventArgs E)
			{ if (CC.MLR(E)) { Point MP = MousePosition; MP.Offset(FP); (Parent as Form).DesktopLocation = MP; } base.OnMouseMove(E); }
		}
		internal class CP : PictureBox
		{
			private Point FP = new Point();
			protected override void OnMouseDown (MouseEventArgs E) { FP = CC.SE(E); base.OnMouseDown(E); }
			protected override void OnMouseMove (MouseEventArgs E)
			{ if (CC.MLR(E)) { Point MP = MousePosition; MP.Offset(FP); (Parent as Form).DesktopLocation = MP; ; } base.OnMouseMove(E); }
		}
	}
	internal static class CC
	{
		internal static MouseButtons ML = MouseButtons.Left;
		internal static MouseButtons MR = MouseButtons.Right;
		internal static Boolean MLR (MouseEventArgs E) => E.Button == ML || E.Button == MR;
		internal static Point SE (MouseEventArgs E) => new Point(-E.X, -E.Y);
	}
}
