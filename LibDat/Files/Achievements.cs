using System.IO;

namespace LibDat.Files
{
	public class Achievements : BaseDat
	{
		[StringIndex]
		public int Id { get; set; }
		[UserStringIndex]
		public int Description { get; set; }
		public int Unknown2 { get; set; }
		[UserStringIndex]
		public int Objective { get; set; }
		public int Unknown4 { get; set; }
		public bool Flag0 { get; set; }
		public bool Flag1 { get; set; }
		public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public int Unknown5 { get; set; }

		public Achievements(BinaryReader inStream)
		{
			Id = inStream.ReadInt32();
			Description = inStream.ReadInt32();
			Unknown2 = inStream.ReadInt32();
			Objective = inStream.ReadInt32();
			Unknown4 = inStream.ReadInt32();
			Flag0 = inStream.ReadBoolean();
			Flag1 = inStream.ReadBoolean();
			Flag2 = inStream.ReadBoolean();
            Flag3 = inStream.ReadBoolean();
            Unknown5 = inStream.ReadInt32();
		}

		public override void Save(BinaryWriter outStream)
		{
			outStream.Write(Id);
			outStream.Write(Description);
			outStream.Write(Unknown2);
			outStream.Write(Objective);
			outStream.Write(Unknown4);
			outStream.Write(Flag0);
			outStream.Write(Flag1);
			outStream.Write(Flag2);
            outStream.Write(Flag3);
            outStream.Write(Unknown5);
		}

		public override int GetSize()
		{
			return 0x1C;
		}
	}
}
