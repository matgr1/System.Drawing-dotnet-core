﻿namespace System.Drawing
{
	//
	// Summary:
	//     Stores an ordered pair of floating-point numbers, typically the width and height
	//     of a rectangle.
	public struct SizeF
	{
		//
		// Summary:
		//     Represents a System.Drawing.SizeF that has System.Drawing.SizeF.Width and System.Drawing.SizeF.Height
		//     values set to zero.
		public static readonly SizeF Empty;

		//
		// Summary:
		//     Initializes a new instance of the System.Drawing.SizeF structure from the specified
		//     dimensions.
		//
		// Parameters:
		//   width:
		//     The width component of the new System.Drawing.SizeF.
		//
		//   height:
		//     The height component of the new System.Drawing.SizeF.
		public SizeF(float x, float y)
		{
			Width = x;
			Height = y;
		}

		//
		// Summary:
		//     Tests whether this System.Drawing.SizeF structure has width and height of 0.
		//
		// Returns:
		//     This property returns true when this System.Drawing.SizeF structure has both a
		//     width and height of 0; otherwise, false.
		public bool IsEmpty { get { return this == Empty; } }

		//
		// Summary:
		//     Gets or sets the horizontal component of this System.Drawing.SizeF structure.
		//
		// Returns:
		//     The horizontal component of this System.Drawing.SizeF structure, typically measured
		//     in pixels.
		public float Width { get; set; }

		//
		// Summary:
		//     Gets or sets the vertical component of this System.Drawing.SizeF structure.
		//
		// Returns:
		//     The vertical component of this System.Drawing.SizeF structure, typically measured
		//     in pixels.
		public float Height { get; set; }

		//
		// Summary:
		//     Tests to see whether the specified object is a System.Drawing.SizeF structure
		//     with the same dimensions as this System.Drawing.SizeF structure.
		//
		// Parameters:
		//   obj:
		//     The System.Object to test.
		//
		// Returns:
		//     true if obj is a System.Drawing.SizeF and has the same width and height as this
		//     System.Drawing.SizeF; otherwise, false.
		public override bool Equals(object obj)
		{
			if (obj is SizeF)
			{
				return Equals((SizeF)obj);
			}

			return false;
		}
		//
		// Summary:
		//     Tests to see whether the specified object is a System.Drawing.SizeF structure
		//     with the same dimensions as this System.Drawing.SizeF structure.
		//
		// Parameters:
		//   obj:
		//     The System.Object to test.
		//
		// Returns:
		//     true if obj is a System.Drawing.SizeF and has the same width and height as this
		//     System.Drawing.SizeF; otherwise, false.
		public bool Equals(SizeF point)
		{
			return (point.Width == Width) &&
				(point.Height == Height);
		}
		//
		// Summary:
		//     Returns a hash code for this System.Drawing.SizeF.
		//
		// Returns:
		//     An integer value that specifies a hash value for this System.Drawing.SizeF.
		public override int GetHashCode()
		{
			return Utility.ShiftAndWrap(Width.GetHashCode(), 2) ^ Height.GetHashCode();
		}

		//
		// Summary:
		//     Tests whether two System.Drawing.SizeF structures are equal.
		//
		// Parameters:
		//   sz1:
		//     The System.Drawing.SizeF structure on the left side of the equality operator.
		//
		//   sz2:
		//     The System.Drawing.SizeF structure on the right of the equality operator.
		//
		// Returns:
		//     true if sz1 and sz2 have equal width and height; otherwise, false.
		public static bool operator ==(SizeF left, SizeF right)
		{
			return left.Equals(right);
		}
		//
		// Summary:
		//     Tests whether two System.Drawing.SizeF structures are different.
		//
		// Parameters:
		//   sz1:
		//     The System.Drawing.SizeF structure on the left of the inequality operator.
		//
		//   sz2:
		//     The System.Drawing.SizeF structure on the right of the inequality operator.
		//
		// Returns:
		//     true if sz1 and sz2 differ either in width or height; false if sz1 and sz2 are
		//     equal.
		public static bool operator !=(SizeF left, SizeF right)
		{
			return (false == left.Equals(right));
		}
	}
}
