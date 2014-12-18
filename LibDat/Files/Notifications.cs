using System.IO;

namespace LibDat.Files
{
	public class Notifications : BaseDat
	{
		[StringIndex]
		public int Id { get; set; }
        public bool Flag0 { get; set; }
        public bool Flag1 { get; set; }
        [UserStringIndex]
		public int Text { get; set; }
        public int Unknown1 { get; set; }
        public int Unknown2 { get; set; }
        public bool Flag2 { get; set; }

        public Notifications()
		{
			
		}
		public Notifications(BinaryReader inStream)
		{
			Id = inStream.ReadInt32();
            Flag0 = inStream.ReadBoolean();
            Flag1 = inStream.ReadBoolean();
			Text = inStream.ReadInt32();
            Unknown1 = inStream.ReadInt32();
            Unknown2 = inStream.ReadInt32();
            Flag2 = inStream.ReadBoolean();
		}

		public override void Save(BinaryWriter outStream)
		{
			outStream.Write(Id);
            outStream.Write(Flag0);
            outStream.Write(Flag1);
            outStream.Write(Text);
            outStream.Write(Unknown1);
            outStream.Write(Unknown1);
            outStream.Write(Flag2);
		}

		public override int GetSize()
		{
			return 19;
		}
	}
}