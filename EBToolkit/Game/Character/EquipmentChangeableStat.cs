using System;
using System.IO;

namespace EBToolkit.Game.Character
{
	/// <summary>
	/// A stat that can change based on equipment
	/// </summary>
	public class EquipmentChangeableStat : Stat, EarthboundSaveable
	{
		/// <summary>
		/// How many <see cref="EquipmentChangeableStat"/>s there are in EarthBound.
		/// </summary>
		public const int StatCount = 6;
		/// <summary>
		/// The base value of this stat before the bonus from equipment is applied
		/// </summary>
		public byte BaseValue;

		/// <summary>
		/// The extra value that the equipment provides for this stat
		/// </summary>
		public byte Difference
		{
			get { return (byte)(Value - BaseValue); }
		}

		/// <inheritdoc/>
		public void WriteDataToStream(BinaryWriter writer)
		{
			writer.Write(Value);
			writer.Seek(StatCount, SeekOrigin.Current);
			writer.Write(BaseValue);
			writer.Seek(-StatCount - 1, SeekOrigin.Current);
		}
	}
}
