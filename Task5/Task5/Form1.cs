using Timer = System.Threading.Timer;

namespace Task5
{
    public partial class Form1 : Form
    {
        public class Drop
        {
            public int PositionX { get; set; }
            public int PositionY { get; set; }

            public int Width { get; set; }
            public int Height { get; set; }

            public SolidBrush Brush { get; set; }
            public Drop(int x, int y, int width, int height, SolidBrush brush)
            {
                PositionX = x;
                PositionY = y;
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
        int _reproduction;
        int _width;
        int _height;
        int _dx;
        int _radius;
        int _dy;
        double _puddleHeight = 0;

        public Form1()
        {
            InitializeComponent();
            _brush = new SolidBrush(Color.Blue);
            ColorButton.BackColor = _brush.Color;
            MinSpeedTextBox.Text = "20";
            MaxSpeedTextBox.Text = "100";
            _reproduction = 500;
            _puddleHeight = _height;
        }

        private void RainButton_Click(object sender, EventArgs e)
        {
            Panel.CreateGraphics().Clear(Color.White);
            _listPositionX.Clear();
            _drops.Clear();
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
                TimerCallback tm = new TimerCallback(OnTimerTicked);
                _timer = new Timer(tm, 0, 0, _reproduction);
            }
        }

        private void OnTimerTicked(object obj)
        {
            double speedMax = Convert.ToDouble(MaxSpeedTextBox.Text);
            double speedMin = Convert.ToDouble(MinSpeedTextBox.Text);
            double randomSpeed = _random.Next((int)speedMin, (int)speedMax);
            double difference = randomSpeed / 100.0;
            _reproduction = (int)(20 / difference);
            _positionX = _random.Next(4, 28);
            var dropX = _width * _positionX;
            var dropY = _height * 11;
            for (int i = 0; i < _drops.Count; i++)
            {
                if (Math.Abs(_drops[i].PositionY - (Panel.ClientSize.Height - _puddleHeight)) <= 5)
                {
                    _puddleHeight += 0.2;
                    _drops.Remove(_drops[0]);
                }

            }
            Drop drop = new Drop(dropX - _radius, dropY - _radius, 6, 10, _brush);
            _drops.Add(drop);
            for (int i = 0; i < _drops.Count; i++)
            {
                _drops[i].PositionY += _height;
            }
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

            for (int i = 0; i < _drops.Count; i++)
            {
                var dx = _drops[i].PositionX;
                var dy = _drops[i].PositionY;
                var dWidth = _drops[i].Width;
                var dHeight = _drops[i].Height;
                var brush = _drops[i].Brush;
                Invoke(() =>
                {
                    g.FillEllipse(new SolidBrush(Color.White), dx, dy - _height, dWidth, dHeight);
                    g.FillEllipse(_brush, dx, dy, dWidth, dHeight);
                });
                g.FillRectangle(_brush, 0, (int)(Panel.ClientSize.Height - _puddleHeight), Panel.ClientSize.Width, (int)_puddleHeight);

            }
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