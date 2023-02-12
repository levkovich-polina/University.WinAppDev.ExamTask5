using Timer = System.Threading.Timer;

namespace Task5
{
    public partial class Form1 : Form
    {
        public class Drop
        {
            public Point Center { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public SolidBrush Brush { get; set; }
            public Drop(Point point, int width, int height, SolidBrush brush)
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
            public Cloud(Point point, int radius, SolidBrush brush)
            {
                Center = point;
                Radius = radius;
                Brush = brush;
            }
        }
     
        List<Drop> _drops = new List<Drop>();
        List<Cloud> _clouds = new List<Cloud>();
        Timer _timer;
        Random _random = new Random();
        int _positionX;
        SolidBrush _brush;

        public Form1()
        {
            InitializeComponent();
        }

        private void RainButton_Click(object sender, EventArgs e)
        {
            if (ColorButton.BackColor == Color.Silver)
            {
                MessageBox.Show("Нужно выбрать цвет!");
            }
            else
            {
                TimerCallback tm = new TimerCallback(OnTimerTicked);
                _timer = new Timer(tm, 0, 0, 100);
            }
        }

        private void OnTimerTicked(object obj)
        {
            _positionX = _random.Next(1, 30);
            Draw();
        }

        private void Draw()
        {
            Graphics g = Panel.CreateGraphics();
            int width = Panel.ClientSize.Width / 30;
            int height = Panel.ClientSize.Height / 30;
            int dy = height * 4;
            int radius = 40;
            int dx = width * 2;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Cloud cloud = new Cloud(new Point(dx - radius, dy - radius), radius, _brush);
                    _clouds.Add(cloud);
                    Invoke(() =>
                    {
                        g.FillEllipse(_brush, dx - radius, dy - radius, radius * 2, radius * 2);
                    });
                    dx += width * 2;
                }
                dx += width;
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {          
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Panel.CreateGraphics().Clear(Color.White);
                _brush = new SolidBrush(ColorDialog.Color);
                ColorButton.BackColor = ColorDialog.Color;
            }
        }
    }
}