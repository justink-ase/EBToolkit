using System;
using System.IO;

namespace EBToolkit.Game.Inventory
{
	/// <summary>
	/// Represents a <see cref="Game.Character.EarthboundPartyMember"/>'s inventory
	/// </summary>
	public class PlayerInventory : Inventory
	{
		/// <summary>
		/// The size of a player's inventory
		/// </summary>
		public const int PlayerInventorySize = 14;

		/// <summary>
		/// A byte array containing the indexes of the equipped items
		/// </summary>
		public readonly byte[] Equips = { 0, 0, 0, 0 };

		/// <summary>
		/// Creates a new <see cref="PlayerInventory"/> with a size of
		/// <see cref="PlayerInventorySize"/>
		/// </summary>
		public PlayerInventory() : base(PlayerInventorySize) { }

		/// <inheritdoc/>
		public override void WriteDataToStream(BinaryWriter writer)
		{
			base.WriteDataToStream(writer);
			foreach (byte Equip in Equips) writer.Write(Equip);
		}
	}
}
