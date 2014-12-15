﻿using System;
using System.IO;

namespace LibDat.Files
{
	public class BuffDefinitions : BaseDat
	{
		[StringIndex]
		public int Id { get; set; }
		[UserStringIndex]
		public int Description { get; set; }
		public bool Invisible { get; set; }
		public bool Removable { get; set; }
		[UserStringIndex]
		public int Name { get; set; }
		public int Data0Length { get; set; }
		[UInt64Index]
		public int Data0 { get; set; }
		public bool Flag0 { get; set; }
		public int Unknown2 { get; set; }
		public bool Flag1 { get; set; }
		public Int64 Unknown3 { get; set; }
		public Int64 Unknown4 { get; set; }
		public bool Flag2 { get; set; }
		public int Unknown5 { get; set; }
		public Int64 Unknown6 { get; set; }
		public bool Flag3 { get; set; }
		public bool Flag4 { get; set; }
		public int Unknown7 { get; set; }
		public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }

		public BuffDefinitions(BinaryReader inStream)
		{
			Id = inStream.ReadInt32();
			Description = inStream.ReadInt32();
			Invisible = inStream.ReadBoolean();
			Removable = inStream.ReadBoolean();
			Name = inStream.ReadInt32();
			Data0Length = inStream.ReadInt32();
			Data0 = inStream.ReadInt32();
			Flag0 = inStream.ReadBoolean();
			Unknown2 = inStream.ReadInt32();
			Flag1 = inStream.ReadBoolean();
			Unknown3 = inStream.ReadInt64();
			Unknown4 = inStream.ReadInt64();
			Flag2 = inStream.ReadBoolean();
			Unknown5 = inStream.ReadInt32();
			Unknown6 = inStream.ReadInt64();
			Flag3 = inStream.ReadBoolean();
			Flag4 = inStream.ReadBoolean();
			Unknown7 = inStream.ReadInt32();
			Flag5 = inStream.ReadBoolean();
            Flag6 = inStream.ReadBoolean();
		}

		public override void Save(BinaryWriter outStream)
		{
			outStream.Write(Id);
			outStream.Write(Description);
			outStream.Write(Invisible);
			outStream.Write(Removable);
			outStream.Write(Name);
			outStream.Write(Data0Length);
			outStream.Write(Data0);
			outStream.Write(Flag0);
			outStream.Write(Unknown2);
			outStream.Write(Flag1);
			outStream.Write(Unknown3);
			outStream.Write(Unknown4);
			outStream.Write(Flag2);
			outStream.Write(Unknown5);
			outStream.Write(Unknown6);
			outStream.Write(Flag3);
			outStream.Write(Flag4);
			outStream.Write(Unknown7);
			outStream.Write(Flag5);
            outStream.Write(Flag6);
		}

		public override int GetSize()
		{
			return 0x41;
		}
	}
}
