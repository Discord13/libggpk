﻿using System;
using System.IO;

namespace LibDat.Files
{
	public class RandomUniqueMonsters : BaseDat
	{
		public int Unknown0 { get; set; }
		public int Unknown1 { get; set; }
		public int Unknown2 { get; set; }
		public int Unknown3 { get; set; }

		public RandomUniqueMonsters()
		{

		}

		public RandomUniqueMonsters(BinaryReader inStream)
		{
			Unknown0 = inStream.ReadInt32();
			Unknown1 = inStream.ReadInt32();
			Unknown2 = inStream.ReadInt32();
			Unknown3 = inStream.ReadInt32();
		}

		public override void Save(BinaryWriter outStream)
		{
			outStream.Write(Unknown0);
			outStream.Write(Unknown1);
			outStream.Write(Unknown2);
			outStream.Write(Unknown3);
		}

		public override int GetSize()
		{
			return 0x10;
		}
	}
}