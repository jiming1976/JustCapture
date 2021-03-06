﻿/*****************************************************************************
 * 
 * JustCapture
 * https://github.com/unvell/JustCapture
 * 
 * MIT License
 * 
 * Copyright(c) 2010-2019 Jingwood, all rights reserved.
 * 
 ****************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace unvell.JustCapture
{
	public partial class NumericRangeForm : Form
	{
		public NumericRangeForm()
		{
			InitializeComponent();

			sizeGroup.Text = LangResource.size;

			this.Text = LangResource.resize_image;

			this.labWidth.Text = LangResource.lab_width;
			this.labHeight.Text = LangResource.lab_height;

			this.btnOK.Text = LangResource.btn_ok;
			this.btnCancel.Text = LangResource.btn_cancel;

			numWidth.GotFocus += numWidth_GotFocus;
			numHeight.GotFocus += numWidth_GotFocus;
		}

		void numWidth_GotFocus(object sender, EventArgs e)
		{
			var num = ((NumericUpDown)sender);
			num.Select(0, num.Text.Length);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			numWidth.Value = ImageSize.Width;
			numHeight.Value = ImageSize.Height;
		}

		public Size ImageSize { get; set; }

		private void btnOK_Click(object sender, EventArgs e)
		{
			ImageSize = new Size((int)numWidth.Value, (int)numHeight.Value);
		}

		
	}
}
