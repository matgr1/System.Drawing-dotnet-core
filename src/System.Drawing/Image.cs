namespace System.Drawing
{
	//
	// Summary:
	//     An abstract base class that provides functionality for the System.Drawing.Bitmap
	//     and System.Drawing.Imaging.Metafile descended classes.
	public abstract class Image
	{
		//
		// Summary:
		//     Provides a callback method for determining when the System.Drawing.Image.GetThumbnailImage(System.Int32,System.Int32,System.Drawing.Image.GetThumbnailImageAbort,System.IntPtr)
		//     method should prematurely cancel execution.
		//
		// Returns:
		//     This method returns true if it decides that the System.Drawing.Image.GetThumbnailImage(System.Int32,System.Int32,System.Drawing.Image.GetThumbnailImageAbort,System.IntPtr)
		//     method should prematurely stop execution; otherwise, it returns false.
		public delegate bool GetThumbnailImageAbort();
	}
}
