﻿using System.IO;

namespace LibDat.Files
{
	public class Realms : BaseDat
	{
		[StringIndex]
		public int Id { get; set; }
		[UserStringIndex]
		public int Name { get; set; }
		public int ServerLength { get; set; }
		[DataIndex]
		public int Server { get; set; }
		public bool Flag0 { get; set; }
		public int ServerLength2 { get; set; }
		[DataIndex]
		public int Server2 { get; set; }
		[StringIndex]
		public int ShortName { get; set; }

		public Realms(BinaryReader inStream)
		{
			Id = inStream.ReadInt32();
			Name = inStream.ReadInt32();
			ServerLength = inStream.ReadInt32();
			Server = inStream.ReadInt32();
			Flag0 = inStream.ReadBoolean();
			ServerLength2 = inStream.ReadInt32();
			Server2 = inStream.ReadInt32();
			ShortName = inStream.ReadInt32();
		}

		public override void Save(BinaryWriter outStream)
		{
			outStream.Write(Id);
			outStream.Write(Name);
			outStream.Write(ServerLength);
			outStream.Write(Server);
			outStream.Write(Flag0);
			outStream.Write(ServerLength2);
			outStream.Write(Server2);
			outStream.Write(ShortName);
		}

		public override int GetSize()
		{
			return 0x1D;
		}
	}
}