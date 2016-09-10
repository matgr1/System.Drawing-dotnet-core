namespace System.Drawing
{
	internal static class Utility
	{
		public static int ShiftAndWrap(int value, int positions)
		{
			// NOTE: this is from here: https://msdn.microsoft.com/en-us/library/system.object.gethashcode(v=vs.110).aspx

			positions = positions & 0x1F;

			// Save the existing bit pattern, but interpret it as an unsigned integer.
			uint number = BitConverter.ToUInt32(BitConverter.GetBytes(value), 0);
			// Preserve the bits to be discarded.
			uint wrapped = number >> (32 - positions);
			// Shift and wrap the discarded bits.
			return BitConverter.ToInt32(BitConverter.GetBytes((number << positions) | wrapped), 0);
		}
	}
}
