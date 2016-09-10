namespace System.Drawing
{
	//
	// Summary:
	//     Stores a set of four floating-point numbers that represent the location and size
	//     of a rectangle. For more advanced region functions, use a System.Drawing.Region
	//     object.
	public struct RectangleF
	{
		//
		// Summary:
		//     Represents an instance of the System.Drawing.RectangleF class with its members
		//     uninitialized.
		public static readonly RectangleF Empty;

		//
		// Summary:
		//     Initializes a new instance of the System.Drawing.RectangleF class with the specified
		//     location and size.
		//
		// Parameters:
		//   location:
		//     A System.Drawing.PointF that represents the upper-left corner of the rectangular
		//     region.
		//
		//   size:
		//     A System.Drawing.SizeF that represents the width and height of the rectangular
		//     region.
		public RectangleF(PointF location, SizeF size)
		{
			Location = location;
			Size = size;
		}
		//
		// Summary:
		//     Initializes a new instance of the System.Drawing.RectangleF class with the specified
		//     location and size.
		//
		// Parameters:
		//   x:
		//     The x-coordinate of the upper-left corner of the rectangle.
		//
		//   y:
		//     The y-coordinate of the upper-left corner of the rectangle.
		//
		//   width:
		//     The width of the rectangle.
		//
		//   height:
		//     The height of the rectangle.
		public RectangleF(float x, float y, float width, float height)
			: this(new PointF(x, y), new SizeF(width, height))
		{
		}

		//
		// Summary:
		//     Gets the y-coordinate that is the sum of System.Drawing.RectangleF.Y and System.Drawing.RectangleF.Height
		//     of this System.Drawing.RectangleF structure.
		//
		// Returns:
		//     The y-coordinate that is the sum of System.Drawing.RectangleF.Y and System.Drawing.RectangleF.Height
		//     of this System.Drawing.RectangleF structure.
		public float Bottom { get { return Y + Height; } }
		//
		// Summary:
		//     Gets or sets the height of this System.Drawing.RectangleF structure.
		//
		// Returns:
		//     The height of this System.Drawing.RectangleF structure. The default is 0.
		public float Height { get { return Size.Height; } set { Size = new SizeF(Size.Width, value); } }
		//
		// Summary:
		//     Tests whether the System.Drawing.RectangleF.Width or System.Drawing.RectangleF.Height
		//     property of this System.Drawing.RectangleF has a value of zero.
		//
		// Returns:
		//     This property returns true if the System.Drawing.RectangleF.Width or System.Drawing.RectangleF.Height
		//     property of this System.Drawing.RectangleF has a value of zero; otherwise, false.
		public bool IsEmpty { get { return Equals(Empty); } }
		//
		// Summary:
		//     Gets the x-coordinate of the left edge of this System.Drawing.RectangleF structure.
		//
		// Returns:
		//     The x-coordinate of the left edge of this System.Drawing.RectangleF structure.
		public float Left { get { return X; } }
		//
		// Summary:
		//     Gets or sets the coordinates of the upper-left corner of this System.Drawing.RectangleF
		//     structure.
		//
		// Returns:
		//     A System.Drawing.PointF that represents the upper-left corner of this System.Drawing.RectangleF
		//     structure.
		public PointF Location { get; set; }
		//
		// Summary:
		//     Gets the x-coordinate that is the sum of System.Drawing.RectangleF.X and System.Drawing.RectangleF.Width
		//     of this System.Drawing.RectangleF structure.
		//
		// Returns:
		//     The x-coordinate that is the sum of System.Drawing.RectangleF.X and System.Drawing.RectangleF.Width
		//     of this System.Drawing.RectangleF structure.
		public float Right { get { return X + Width; } }
		//
		// Summary:
		//     Gets or sets the size of this System.Drawing.RectangleF.
		//
		// Returns:
		//     A System.Drawing.SizeF that represents the width and height of this System.Drawing.RectangleF
		//     structure.
		public SizeF Size { get; set; }
		//
		// Summary:
		//     Gets the y-coordinate of the top edge of this System.Drawing.RectangleF structure.
		//
		// Returns:
		//     The y-coordinate of the top edge of this System.Drawing.RectangleF structure.
		public float Top { get { return Y; } }
		//
		// Summary:
		//     Gets or sets the width of this System.Drawing.RectangleF structure.
		//
		// Returns:
		//     The width of this System.Drawing.RectangleF structure. The default is 0.
		public float Width { get { return Size.Width; } set { Size = new SizeF(value, Size.Height); } }
		//
		// Summary:
		//     Gets or sets the x-coordinate of the upper-left corner of this System.Drawing.RectangleF
		//     structure.
		//
		// Returns:
		//     The x-coordinate of the upper-left corner of this System.Drawing.RectangleF structure.
		//     The default is 0.
		public float X { get { return Location.X; } set { Location = new PointF(value, Location.Y); } }
		//
		// Summary:
		//     Gets or sets the y-coordinate of the upper-left corner of this System.Drawing.RectangleF
		//     structure.
		//
		// Returns:
		//     The y-coordinate of the upper-left corner of this System.Drawing.RectangleF structure.
		//     The default is 0.
		public float Y { get { return Location.Y; } set { Location = new PointF(Location.X, value); } }
		//
		// Summary:
		//     Tests whether obj is a System.Drawing.RectangleF with the same location and size
		//     of this System.Drawing.RectangleF.
		//
		// Parameters:
		//   obj:
		//     The System.Object to test.
		//
		// Returns:
		//     This method returns true if obj is a System.Drawing.RectangleF and its X, Y,
		//     Width, and Height properties are equal to the corresponding properties of this
		//     System.Drawing.RectangleF; otherwise, false.
		public override bool Equals(object obj)
		{
			if (obj is RectangleF)
			{
				return Equals((RectangleF)obj);
			}

			return false;
		}
		public bool Equals(RectangleF color)
		{
			return (color.X == X) &&
				(color.Y == Y) &&
				(color.Width == Width) &&
				(color.Height == Height);
		}
		//
		// Summary:
		//     Gets the hash code for this System.Drawing.RectangleF structure. For information
		//     about the use of hash codes, see Object.GetHashCode.
		//
		// Returns:
		//     The hash code for this System.Drawing.RectangleF.
		public override int GetHashCode()
		{
			return Utility.ShiftAndWrap(X.GetHashCode(), 6) ^ Utility.ShiftAndWrap(Y.GetHashCode(), 4) ^ Utility.ShiftAndWrap(Width.GetHashCode(), 2) ^ Height.GetHashCode();
		}

		//
		// Summary:
		//     Tests whether two System.Drawing.RectangleF structures have equal location and
		//     size.
		//
		// Parameters:
		//   left:
		//     The System.Drawing.RectangleF structure that is to the left of the equality operator.
		//
		//   right:
		//     The System.Drawing.RectangleF structure that is to the right of the equality
		//     operator.
		//
		// Returns:
		//     This operator returns true if the two specified System.Drawing.RectangleF structures
		//     have equal System.Drawing.RectangleF.X, System.Drawing.RectangleF.Y, System.Drawing.RectangleF.Width,
		//     and System.Drawing.RectangleF.Height properties.
		public static bool operator ==(RectangleF left, RectangleF right)
		{
			return left.Equals(right);
		}
		//
		// Summary:
		//     Tests whether two System.Drawing.RectangleF structures differ in location or
		//     size.
		//
		// Parameters:
		//   left:
		//     The System.Drawing.RectangleF structure that is to the left of the inequality
		//     operator.
		//
		//   right:
		//     The System.Drawing.RectangleF structure that is to the right of the inequality
		//     operator.
		//
		// Returns:
		//     This operator returns true if any of the System.Drawing.RectangleF.X , System.Drawing.RectangleF.Y,
		//     System.Drawing.RectangleF.Width, or System.Drawing.RectangleF.Height properties
		//     of the two System.Drawing.Rectangle structures are unequal; otherwise false.
		public static bool operator !=(RectangleF left, RectangleF right)
		{
			return (false == left.Equals(right));
		}
	}
}
