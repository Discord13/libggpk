﻿using System;
using System.IO;

namespace LibDat.Files
{
	public class DexMissionMods : BaseDat
	{
		[StringIndex]
		public int Id { get; set; }
		public int Unknown1 { get; set; }
		public int Unknown2 { get; set; }
		public int Unknown3 { get; set; }
		public bool Flag0 { get; set; }
		public bool Flag1 { get; set; }
		public int Unknown4 { get; set; }
		public int Unknown5 { get; set; }
        public bool Flag2 { get; set; }


		public DexMissionMods()
		{

		}

		public DexMissionMods(BinaryReader inStream)
		{
			Id = inStream.ReadInt32();
			Unknown1 = inStream.ReadInt32();
			Unknown2 = inStream.ReadInt32();
			Unknown3 = inStream.ReadInt32();
			Flag0 = inStream.ReadBoolean();
			Flag1 = inStream.ReadBoolean();
			Unknown4 = inStream.ReadInt32();
			Unknown5 = inStream.ReadInt32();
            Flag2 = inStream.ReadBoolean();
		}

		public override void Save(BinaryWriter outStream)
		{
			outStream.Write(Id);
			outStream.Write(Unknown1);
			outStream.Write(Unknown2);
			outStream.Write(Unknown3);
			outStream.Write(Flag0);
			outStream.Write(Flag1);
			outStream.Write(Unknown4);
			outStream.Write(Unknown5);
            outStream.Write(Flag2);
		}

		public override int GetSize()
		{
			return 0x1B;
		}
	}
}