namespace System.Drawing
{
	//
	// Summary:
	//     Represents an ordered pair of floating-point x- and y-coordinates that defines a Point
	//     in a two-dimensional plane.
	public struct PointF
	{
		//
		// Summary:
		//     Represents a System.Drawing.Pointf that has System.Drawing.Pointf.X and System.Drawing.Pointf.Y
		//     values set to zero.
		public static readonly PointF Empty;

		//
		// Summary:
		//     Initializes a new instance of the System.Drawing.Pointf class with the specified
		//     coordinates.
		//
		// Parameters:
		//   x:
		//     The horizontal position of the Pointf.
		//
		//   y:
		//     The vertical position of the Pointf.
		public PointF(float x, float y)
		{
			X = x;
			Y = y;
		}

		//
		// Summary:
		//     Gets a value indicating whether this System.Drawing.Pointf is empty.
		//
		// Returns:
		//     true if both System.Drawing.Pointf.X and System.Drawing.Pointf.Y are 0; otherwise,
		//     false.
		public bool IsEmpty { get { return this == Empty; } }

		//
		// Summary:
		//     Gets or sets the x-coordinate of this System.Drawing.Pointf.
		//
		// Returns:
		//     The x-coordinate of this System.Drawing.Pointf.
		public float X { get; set; }

		//
		// Summary:
		//     Gets or sets the y-coordinate of this System.Drawing.Pointf.
		//
		// Returns:
		//     The y-coordinate of this System.Drawing.Pointf.
		public float Y { get; set; }

		//
		// Summary:
		//     Specifies whether this System.Drawing.Pointf contains the same coordinates as
		//     the specified System.Object.
		//
		// Parameters:
		//   obj:
		//     The System.Object to test.
		//
		// Returns:
		//     true if obj is a System.Drawing.Pointf and has the same coordinates as this System.Drawing.Pointf.
		public override bool Equals(object obj)
		{
			if (obj is PointF)
			{
				return Equals((PointF)obj);
			}

			return false;
		}
		//
		// Summary:
		//     Specifies whether this System.Drawing.Pointf contains the same coordinates as
		//     the specified System.Object.
		//
		// Parameters:
		//   obj:
		//     The System.Object to test.
		//
		// Returns:
		//     true if obj is a System.Drawing.Pointf and has the same coordinates as this System.Drawing.Pointf.
		public bool Equals(PointF Pointf)
		{
			return (Pointf.X == X) &&
				(Pointf.Y == Y);
		}
		//
		// Summary:
		//     Returns a hash code for this System.Drawing.Pointf.
		//
		// Returns:
		//     An integer value that specifies a hash value for this System.Drawing.Pointf.
		public override int GetHashCode()
		{
			return Utility.ShiftAndWrap(X.GetHashCode(), 2) ^ Y.GetHashCode();
		}

		//
		// Summary:
		//     Compares two System.Drawing.Pointf objects. The result specifies whether the values
		//     of the System.Drawing.Pointf.X and System.Drawing.Pointf.Y properties of the two
		//     System.Drawing.Pointf objects are equal.
		//
		// Parameters:
		//   left:
		//     A System.Drawing.Pointf to compare.
		//
		//   right:
		//     A System.Drawing.Pointf to compare.
		//
		// Returns:
		//     true if the System.Drawing.Pointf.X and System.Drawing.Pointf.Y values of left
		//     and right are equal; otherwise, false.
		public static bool operator ==(PointF left, PointF right)
		{
			return left.Equals(right);
		}
		//
		// Summary:
		//     Compares two System.Drawing.Pointf objects. The result specifies whether the values
		//     of the System.Drawing.Pointf.X or System.Drawing.Pointf.Y properties of the two
		//     System.Drawing.Pointf objects are unequal.
		//
		// Parameters:
		//   left:
		//     A System.Drawing.Pointf to compare.
		//
		//   right:
		//     A System.Drawing.Pointf to compare.
		//
		// Returns:
		//     true if the values of either the System.Drawing.Pointf.X properties or the System.Drawing.Pointf.Y
		//     properties of left and right differ; otherwise, false.
		public static bool operator !=(PointF left, PointF right)
		{
			return (false == left.Equals(right));
		}
	}
}
