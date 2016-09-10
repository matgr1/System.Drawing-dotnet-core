namespace System.Drawing
{
	//
	// Summary:
	//     Stores a set of four floating-point numbers that represent the location and size
	//     of a rectangle. For more advanced region functions, use a System.Drawing.Region
	//     object.
	public struct Rectangle
	{
		//
		// Summary:
		//     Represents an instance of the System.Drawing.Rectangle class with its members
		//     uninitialized.
		public static readonly Rectangle Empty;

		//
		// Summary:
		//     Initializes a new instance of the System.Drawing.Rectangle class with the specified
		//     location and size.
		//
		// Parameters:
		//   location:
		//     A System.Drawing.Point that represents the upper-left corner of the rectangular
		//     region.
		//
		//   size:
		//     A System.Drawing.Size that represents the width and height of the rectangular
		//     region.
		public Rectangle(Point location, Size size)
		{
			Location = location;
			Size = size;
		}
		//
		// Summary:
		//     Initializes a new instance of the System.Drawing.Rectangle class with the specified
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
		public Rectangle(int x, int y, int width, int height)
			: this(new Point(x, y), new Size(width, height))
		{
		}

		//
		// Summary:
		//     Gets the y-coordinate that is the sum of System.Drawing.Rectangle.Y and System.Drawing.Rectangle.Height
		//     of this System.Drawing.Rectangle structure.
		//
		// Returns:
		//     The y-coordinate that is the sum of System.Drawing.Rectangle.Y and System.Drawing.Rectangle.Height
		//     of this System.Drawing.Rectangle structure.
		public int Bottom { get { return Y + Height; } }
		//
		// Summary:
		//     Gets or sets the height of this System.Drawing.Rectangle structure.
		//
		// Returns:
		//     The height of this System.Drawing.Rectangle structure. The default is 0.
		public int Height { get { return Size.Height; } set { Size = new Size(Size.Width, value); } }
		//
		// Summary:
		//     Tests whether the System.Drawing.Rectangle.Width or System.Drawing.Rectangle.Height
		//     property of this System.Drawing.Rectangle has a value of zero.
		//
		// Returns:
		//     This property returns true if the System.Drawing.Rectangle.Width or System.Drawing.Rectangle.Height
		//     property of this System.Drawing.Rectangle has a value of zero; otherwise, false.
		public bool IsEmpty { get { return Equals(Empty); } }
		//
		// Summary:
		//     Gets the x-coordinate of the left edge of this System.Drawing.Rectangle structure.
		//
		// Returns:
		//     The x-coordinate of the left edge of this System.Drawing.Rectangle structure.
		public int Left { get { return X; } }
		//
		// Summary:
		//     Gets or sets the coordinates of the upper-left corner of this System.Drawing.Rectangle
		//     structure.
		//
		// Returns:
		//     A System.Drawing.Point that represents the upper-left corner of this System.Drawing.Rectangle
		//     structure.
		public Point Location { get; set; }
		//
		// Summary:
		//     Gets the x-coordinate that is the sum of System.Drawing.Rectangle.X and System.Drawing.Rectangle.Width
		//     of this System.Drawing.Rectangle structure.
		//
		// Returns:
		//     The x-coordinate that is the sum of System.Drawing.Rectangle.X and System.Drawing.Rectangle.Width
		//     of this System.Drawing.Rectangle structure.
		public int Right { get { return X + Width; } }
		//
		// Summary:
		//     Gets or sets the size of this System.Drawing.Rectangle.
		//
		// Returns:
		//     A System.Drawing.Size that represents the width and height of this System.Drawing.Rectangle
		//     structure.
		public Size Size { get; set; }
		//
		// Summary:
		//     Gets the y-coordinate of the top edge of this System.Drawing.Rectangle structure.
		//
		// Returns:
		//     The y-coordinate of the top edge of this System.Drawing.Rectangle structure.
		public int Top { get { return Y; } }
		//
		// Summary:
		//     Gets or sets the width of this System.Drawing.Rectangle structure.
		//
		// Returns:
		//     The width of this System.Drawing.Rectangle structure. The default is 0.
		public int Width { get { return Size.Width; } set { Size = new Size(value, Size.Height); } }
		//
		// Summary:
		//     Gets or sets the x-coordinate of the upper-left corner of this System.Drawing.Rectangle
		//     structure.
		//
		// Returns:
		//     The x-coordinate of the upper-left corner of this System.Drawing.Rectangle structure.
		//     The default is 0.
		public int X { get { return Location.X; } set { Location = new Point(value, Location.Y); } }
		//
		// Summary:
		//     Gets or sets the y-coordinate of the upper-left corner of this System.Drawing.Rectangle
		//     structure.
		//
		// Returns:
		//     The y-coordinate of the upper-left corner of this System.Drawing.Rectangle structure.
		//     The default is 0.
		public int Y { get { return Location.Y; } set { Location = new Point(Location.X, value); } }
		//
		// Summary:
		//     Tests whether obj is a System.Drawing.Rectangle with the same location and size
		//     of this System.Drawing.Rectangle.
		//
		// Parameters:
		//   obj:
		//     The System.Object to test.
		//
		// Returns:
		//     This method returns true if obj is a System.Drawing.Rectangle and its X, Y,
		//     Width, and Height properties are equal to the corresponding properties of this
		//     System.Drawing.Rectangle; otherwise, false.
		public override bool Equals(object obj)
		{
			if (obj is Rectangle)
			{
				return Equals((Rectangle)obj);
			}

			return false;
		}
		public bool Equals(Rectangle color)
		{
			return (color.X == X) &&
				(color.Y == Y) &&
				(color.Width == Width) &&
				(color.Height == Height);
		}
		//
		// Summary:
		//     Gets the hash code for this System.Drawing.Rectangle structure. For information
		//     about the use of hash codes, see Object.GetHashCode.
		//
		// Returns:
		//     The hash code for this System.Drawing.Rectangle.
		public override int GetHashCode()
		{
			return Utility.ShiftAndWrap(X.GetHashCode(), 6) ^ Utility.ShiftAndWrap(Y.GetHashCode(), 4) ^ Utility.ShiftAndWrap(Width.GetHashCode(), 2) ^ Height.GetHashCode();
		}

		//
		// Summary:
		//     Tests whether two System.Drawing.Rectangle structures have equal location and
		//     size.
		//
		// Parameters:
		//   left:
		//     The System.Drawing.Rectangle structure that is to the left of the equality operator.
		//
		//   right:
		//     The System.Drawing.Rectangle structure that is to the right of the equality
		//     operator.
		//
		// Returns:
		//     This operator returns true if the two specified System.Drawing.Rectangle structures
		//     have equal System.Drawing.Rectangle.X, System.Drawing.Rectangle.Y, System.Drawing.Rectangle.Width,
		//     and System.Drawing.Rectangle.Height properties.
		public static bool operator ==(Rectangle left, Rectangle right)
		{
			return left.Equals(right);
		}
		//
		// Summary:
		//     Tests whether two System.Drawing.Rectangle structures differ in location or
		//     size.
		//
		// Parameters:
		//   left:
		//     The System.Drawing.Rectangle structure that is to the left of the inequality
		//     operator.
		//
		//   right:
		//     The System.Drawing.Rectangle structure that is to the right of the inequality
		//     operator.
		//
		// Returns:
		//     This operator returns true if any of the System.Drawing.Rectangle.X , System.Drawing.Rectangle.Y,
		//     System.Drawing.Rectangle.Width, or System.Drawing.Rectangle.Height properties
		//     of the two System.Drawing.Rectangle structures are unequal; otherwise false.
		public static bool operator !=(Rectangle left, Rectangle right)
		{
			return (false == left.Equals(right));
		}
	}
}
