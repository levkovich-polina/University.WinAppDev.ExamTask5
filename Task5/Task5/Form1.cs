using Microsoft.VisualBasic.FileIO;

namespace Task5
{
    public partial class Form1 : Form
    {
        public class Rain
        {
            public Point Center { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public SolidBrush Brush { get; set; }
            public Rain(Point point, int width, int height, SolidBrush brush)
            {
                Center = point;
                Width = width;
                Height = height;
                Brush = brush;
            }
        }
        public class Cloud
        {
            public Point Center { get; set; }
            public int Radius { get; set; }

            public SolidBrush Brush { get; set; }
            public Cloud(Point point, int radius,  SolidBrush brush)
            {
                Center = point;
                Radius = radius;
                Brush = brush;
            }
        }
        public class Puddle
        {
            public Point LeftCorner { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public SolidBrush Brush { get; set; }
            public Puddle(Point point, int width, int height, SolidBrush brush)
            {
                LeftCorner = point;
                Width = width;
                Height = height;
                Brush = brush;
            }
        }
        List<Rain> _rain = new List<Rain>();
        List<Cloud> _cloud = new List<Cloud>();
        List<Puddle> _puddle = new List<Puddle>();

        public Form1()
        {
            InitializeComponent();
        }
    }
}