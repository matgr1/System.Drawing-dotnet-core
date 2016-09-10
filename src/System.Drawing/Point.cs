namespace System.Drawing
{
	//
	// Summary:
	//     Represents an ordered pair of integer x- and y-coordinates that defines a point
	//     in a two-dimensional plane.
	public struct Point
	{
		//
		// Summary:
		//     Represents a System.Drawing.Point that has System.Drawing.Point.X and System.Drawing.Point.Y
		//     values set to zero.
		public static readonly Point Empty;

		//
		// Summary:
		//     Initializes a new instance of the System.Drawing.Point class with the specified
		//     coordinates.
		//
		// Parameters:
		//   x:
		//     The horizontal position of the point.
		//
		//   y:
		//     The vertical position of the point.
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		//
		// Summary:
		//     Gets a value indicating whether this System.Drawing.Point is empty.
		//
		// Returns:
		//     true if both System.Drawing.Point.X and System.Drawing.Point.Y are 0; otherwise,
		//     false.
		public bool IsEmpty { get { return this == Empty; } }

		//
		// Summary:
		//     Gets or sets the x-coordinate of this System.Drawing.Point.
		//
		// Returns:
		//     The x-coordinate of this System.Drawing.Point.
		public int X { get; set; }

		//
		// Summary:
		//     Gets or sets the y-coordinate of this System.Drawing.Point.
		//
		// Returns:
		//     The y-coordinate of this System.Drawing.Point.
		public int Y { get; set; }

		//
		// Summary:
		//     Specifies whether this System.Drawing.Point contains the same coordinates as
		//     the specified System.Object.
		//
		// Parameters:
		//   obj:
		//     The System.Object to test.
		//
		// Returns:
		//     true if obj is a System.Drawing.Point and has the same coordinates as this System.Drawing.Point.
		public override bool Equals(object obj)
		{
			if (obj is Point)
			{
				return Equals((Point)obj);
			}

			return false;
		}
		//
		// Summary:
		//     Specifies whether this System.Drawing.Point contains the same coordinates as
		//     the specified System.Object.
		//
		// Parameters:
		//   obj:
		//     The System.Object to test.
		//
		// Returns:
		//     true if obj is a System.Drawing.Point and has the same coordinates as this System.Drawing.Point.
		public bool Equals(Point point)
		{
			return (point.X == X) &&
				(point.Y == Y);
		}
		//
		// Summary:
		//     Returns a hash code for this System.Drawing.Point.
		//
		// Returns:
		//     An integer value that specifies a hash value for this System.Drawing.Point.
		public override int GetHashCode()
		{
			return Utility.ShiftAndWrap(X.GetHashCode(), 2) ^ Y.GetHashCode();
		}

		//
		// Summary:
		//     Compares two System.Drawing.Point objects. The result specifies whether the values
		//     of the System.Drawing.Point.X and System.Drawing.Point.Y properties of the two
		//     System.Drawing.Point objects are equal.
		//
		// Parameters:
		//   left:
		//     A System.Drawing.Point to compare.
		//
		//   right:
		//     A System.Drawing.Point to compare.
		//
		// Returns:
		//     true if the System.Drawing.Point.X and System.Drawing.Point.Y values of left
		//     and right are equal; otherwise, false.
		public static bool operator ==(Point left, Point right)
		{
			return left.Equals(right);
		}
		//
		// Summary:
		//     Compares two System.Drawing.Point objects. The result specifies whether the values
		//     of the System.Drawing.Point.X or System.Drawing.Point.Y properties of the two
		//     System.Drawing.Point objects are unequal.
		//
		// Parameters:
		//   left:
		//     A System.Drawing.Point to compare.
		//
		//   right:
		//     A System.Drawing.Point to compare.
		//
		// Returns:
		//     true if the values of either the System.Drawing.Point.X properties or the System.Drawing.Point.Y
		//     properties of left and right differ; otherwise, false.
		public static bool operator !=(Point left, Point right)
		{
			return (false == left.Equals(right));
		}
	}
}
