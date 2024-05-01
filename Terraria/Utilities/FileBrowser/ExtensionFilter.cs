namespace Terraria.Utilities.FileBrowser;

public struct ExtensionFilter
{
	public string Name;
	public string[] Extensions;

	public ExtensionFilter(string filterName, params string[] filterExtensions)
	{
		Name = filterName;
		Extensions = filterExtensions;
	}
}
