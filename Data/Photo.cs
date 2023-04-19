using System;

namespace MyPhotoshop
{
	public class Photo
	{
		public Photo(int width, int height)
		{
			Width = width;
			Height = height;
			_data = new Pixel[width, height];
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					_data[i, j] = new Pixel();
				}
			}
		}
		
		public Pixel this[int x, int y]
		{
			get { return _data[x, y]; }
			set { _data[x, y] = value; }
		}

		public int Width { get; private set; }
		public int Height { get; private set; }

		private readonly Pixel[,] _data;
	}
}

