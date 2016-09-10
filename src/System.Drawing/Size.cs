namespace System.Drawing
{
	//
	// Summary:
	//     Stores an ordered pair of integers, which specify a System.Drawing.Size.Height
	//     and System.Drawing.Size.Width.
	public struct Size
	{
		//
		// Summary:
		//     Represents a System.Drawing.Size that has System.Drawing.Size.Width and System.Drawing.Size.Height
		//     values set to zero.
		public static readonly Size Empty;

		//
		// Summary:
		//     Initializes a new instance of the System.Drawing.Size structure from the specified
		//     dimensions.
		//
		// Parameters:
		//   width:
		//     The width component of the new System.Drawing.Size.
		//
		//   height:
		//     The height component of the new System.Drawing.Size.
		public Size(int x, int y)
		{
			Width = x;
			Height = y;
		}

		//
		// Summary:
		//     Tests whether this System.Drawing.Size structure has width and height of 0.
		//
		// Returns:
		//     This property returns true when this System.Drawing.Size structure has both a
		//     width and height of 0; otherwise, false.
		public bool IsEmpty { get { return this == Empty; } }

		//
		// Summary:
		//     Gets or sets the horizontal component of this System.Drawing.Size structure.
		//
		// Returns:
		//     The horizontal component of this System.Drawing.Size structure, typically measured
		//     in pixels.
		public int Width { get; set; }

		//
		// Summary:
		//     Gets or sets the vertical component of this System.Drawing.Size structure.
		//
		// Returns:
		//     The vertical component of this System.Drawing.Size structure, typically measured
		//     in pixels.
		public int Height { get; set; }

		//
		// Summary:
		//     Tests to see whether the specified object is a System.Drawing.Size structure
		//     with the same dimensions as this System.Drawing.Size structure.
		//
		// Parameters:
		//   obj:
		//     The System.Object to test.
		//
		// Returns:
		//     true if obj is a System.Drawing.Size and has the same width and height as this
		//     System.Drawing.Size; otherwise, false.
		public override bool Equals(object obj)
		{
			if (obj is Size)
			{
				return Equals((Size)obj);
			}

			return false;
		}
		//
		// Summary:
		//     Tests to see whether the specified object is a System.Drawing.Size structure
		//     with the same dimensions as this System.Drawing.Size structure.
		//
		// Parameters:
		//   obj:
		//     The System.Object to test.
		//
		// Returns:
		//     true if obj is a System.Drawing.Size and has the same width and height as this
		//     System.Drawing.Size; otherwise, false.
		public bool Equals(Size point)
		{
			return (point.Width == Width) &&
				(point.Height == Height);
		}
		//
		// Summary:
		//     Returns a hash code for this System.Drawing.Size.
		//
		// Returns:
		//     An integer value that specifies a hash value for this System.Drawing.Size.
		public override int GetHashCode()
		{
			return Utility.ShiftAndWrap(Width.GetHashCode(), 2) ^ Height.GetHashCode();
		}

		//
		// Summary:
		//     Tests whether two System.Drawing.Size structures are equal.
		//
		// Parameters:
		//   sz1:
		//     The System.Drawing.Size structure on the left side of the equality operator.
		//
		//   sz2:
		//     The System.Drawing.Size structure on the right of the equality operator.
		//
		// Returns:
		//     true if sz1 and sz2 have equal width and height; otherwise, false.
		public static bool operator ==(Size left, Size right)
		{
			return left.Equals(right);
		}
		//
		// Summary:
		//     Tests whether two System.Drawing.Size structures are different.
		//
		// Parameters:
		//   sz1:
		//     The System.Drawing.Size structure on the left of the inequality operator.
		//
		//   sz2:
		//     The System.Drawing.Size structure on the right of the inequality operator.
		//
		// Returns:
		//     true if sz1 and sz2 differ either in width or height; false if sz1 and sz2 are
		//     equal.
		public static bool operator !=(Size left, Size right)
		{
			return (false == left.Equals(right));
		}
	}
}
