namespace SignedHW.Common
{
	public static class Constants
	{
		public static readonly string AppName = AssemblyInfoHelper.GetAppInfo().NameAndVersion;
		public static readonly string RootDirectoryPath = Path.Combine( PathHelper.GetLocalFolderPath() , AppName );
	}
}
