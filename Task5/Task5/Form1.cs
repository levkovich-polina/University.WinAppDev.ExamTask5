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
        List<int> _listPositionX = new List<int>();

        int _width;
        int _height;
        int _dx;
        int _radius;
        int _dy;
        int _dropX;
        int _dropY;

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
                for (int j = 2; j < 28; j++)
                {
                    int chance = _random.Next(1, 11);
                    if (chance > 1)
                    {
                        _listPositionX.Add(j);
                    }
                }
                _width = Panel.ClientSize.Width / 30;
                _height = Panel.ClientSize.Height / 30;
                _radius = 35;
                _dy = _height * 4;
                _dropY = _height * 10;

                TimerCallback tm = new TimerCallback(OnTimerTicked);
                _timer = new Timer(tm, 0, 0, 1000);
            }
        }

        private void OnTimerTicked(object obj)
        {
            _positionX = _random.Next(2, 29);
            _dropX = _width * _positionX;
            Draw();
        }
        private void Draw()
        {
            Graphics g = Panel.CreateGraphics();
            for (int j = 0; j < _listPositionX.Count; j++)
            {
                _dx = _width * _listPositionX[j];
                Cloud cloud = new Cloud(new Point(_dx - _radius, _dy - _radius), _radius, _brush);
                _clouds.Add(cloud);
                Invoke(() =>
                {
                    g.FillEllipse(_brush, _dx - _radius, _dy - _radius, _radius * 2, _radius * 2);
                });
            }

            Drop drop = new Drop(new Point(_dropX - _radius, _dropY - _radius), 6, 10, _brush);
            _drops.Add(drop);
            g.FillEllipse(_brush, _dropX - _radius, _dropY - _radius, 6, 10);
            _dropY += _height;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                _brush = new SolidBrush(ColorDialog.Color);
                ColorButton.BackColor = ColorDialog.Color;
            }
        }
    }
}