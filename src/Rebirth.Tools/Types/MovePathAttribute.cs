﻿namespace Rebirth.Common.Types
{
	public enum MovePathAttribute : byte
	{
		MPA_NORMAL = 0x0,
		MPA_JUMP = 0x1,
		MPA_IMPACT = 0x2,
		MPA_IMMEDIATE = 0x3,
		MPA_TELEPORT = 0x4,
		MPA_HANGONBACK = 0x5,
		MPA_ASSAULTER = 0x6,
		MPA_ASSASSINATION = 0x7,
		MPA_RUSH = 0x8,
		MPA_STATCHANGE = 0x9,
		MPA_SITDOWN = 0xA,
		MPA_STARTFALLDOWN = 0xB,
		MPA_FALLDOWN = 0xC,
		MPA_STARTWINGS = 0xD,
		MPA_WINGS = 0xE,
		MPA_ARAN_ADJUST = 0xF,
		MPA_MOB_TOSS = 0x10,
		MPA_FLYING_BLOCK = 0x11,
		MPA_DASH_SLIDE = 0x12,
		MPA_BMAGE_ADJUST = 0x13,
		MPA_FLASHJUMP = 0x14,
		MPA_ROCKET_BOOSTER = 0x15,
		MPA_BACKSTEP_SHOT = 0x16,
		MPA_MOBPOWERKNOCKBACK = 0x17,
		MPA_VERTICALJUMP = 0x18,
		MPA_CUSTOMIMPACT = 0x19,
		MPA_COMBATSTEP = 0x1A,
		MPA_HIT = 0x1B,
		MPA_TIMEBOMBATTACK = 0x1C,
		MPA_SNOWBALLTOUCH = 0x1D,
		MPA_BUFFZONEEFFECT = 0x1E,
		MPA_MOB_LADDER = 0x1F,
		MPA_MOB_RIGHTANGLE = 0x20,
		MPA_MOB_STOPNODE_START = 0x21,
		MPA_MOB_BEFORE_NODE = 0x22,
		MPA_MOB_ATTACK_RUSH = 0x23,
		MPA_MOB_ATTACK_RUSH_STOP = 0x24,
	}
}
