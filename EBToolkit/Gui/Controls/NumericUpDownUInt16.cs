using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EBToolkit.Gui.Controls
{
	public class NumericUpDownUInt16 : NumericUpDown
	{
		private ushort _minimum = UInt16.MinValue;

		private ushort _maximum = UInt16.MaxValue;

		private ushort _value;

		public new int DecimalPlaces
		{
			get
			{
				return 0;
			}
		}

		[DefaultValue(UInt16.MinValue)]
		public new ushort Minimum
		{
			get
			{
				return this._minimum;
			}
			set
			{
				this._minimum = value;
				base.Minimum = this._minimum;
			}
		}

		[DefaultValue(65535)]
		public new ushort Maximum
		{
			get
			{
				return this._maximum;
			}
			set
			{
				this._maximum = value;
				base.Maximum = this._maximum;
			}
		}

		[DefaultValue(UInt16.MinValue)]
		public new ushort Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
				base.Value = this._value;
			}
		}

		public NumericUpDownUInt16()
		{
			this.Minimum = UInt16.MinValue;
			this.Maximum = UInt16.MaxValue;
			this.Value = this.Minimum;
			base.ValueChanged += new EventHandler(this.SyncValue);
		}

		private void SyncValue(object sender, EventArgs args)
		{
			this._value = (ushort)base.Value;
		}
	}
}