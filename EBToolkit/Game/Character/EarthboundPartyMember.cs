using EBToolkit.Game.Inventory;
using System;

namespace EBToolkit.Game.Character
{
	public class EarthboundPartyMember : EarthboundCharacter
	{
		/// <summary>
		/// The value that <see cref="Vitality"/> will multiply to for a the new
		/// <see cref="EarthboundCharacter.HP"/> on a new level.
		/// <seealso cref="EarthboundCharacter.HP"/>
		/// <seealso cref="Vitality"/>
		/// <seealso cref="GetEstimatedMaxHPOnNewLevel"/>
		/// </summary>
		public const ushort VitalityMultiplier = 15;
		
		/// <summary>
		/// A value which controls what the new <see cref="EarthboundCharacter.HP"/> 
		/// max value will be on a new level.
		/// <seealso cref="IQ"/>
		/// <seealso cref="EarthboundCharacter.HP"/>
		/// <seealso cref="VitalityMultiplier"/>
		/// <seealso cref="GetEstimatedMaxHPOnNewLevel"/>
		/// </summary>
		public EquipmentChangeableStat Vitality;
		
		/// <summary>
		/// A value which controls what the new <see cref="EarthboundCharacter.PP"/>
		/// max value will be on a new level (or for a party member without PP, when
		/// they can fix items).
		/// <seealso cref="Vitality"/>
		/// <seealso cref="EarthboundCharacter.PP"/>
		/// <seealso cref="PsychicPointsState"/>
		/// <seealso cref="GetEstimatedMaxHPOnNewLevel"/>
		/// </summary>
		public EquipmentChangeableStat IQ;

		/// <summary>
		/// The inventory for this player.
		/// </summary>
		public PlayerInventory Inventory;

		public ushort GetEstimatedMaxHPOnNewLevel()
		{
			return this.Vitality * 15;
		}

		public ushort GetEstimatedMaxPPOnNewLevel(PsychicPointsState PsychicPointsState)
		{
			return this.IQ * (ushort)PsychicPointsState;
		}

		public enum PsychicPointsState : ushort
		{
			NoPsychicPoints = 0,
			Normal = 5,
			NessPostMagicant = 10
		}
	}
}
