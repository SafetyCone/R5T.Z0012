using System;

using R5T.T0131;


namespace R5T.Z0012
{
	[ValuesMarker]
	public partial interface IDirectoryNames : IValuesMarker
	{
#pragma warning disable IDE1006 // Naming Styles
        public string bin => "bin";
		public string obj => "obj";
#pragma warning restore IDE1006 // Naming Styles

		public string Binaries => this.bin;
		public string Debug => "Debug";
		public string Objects => this.obj;
		public string Publish => "publish";
		public string Release => "Release";
    }
}