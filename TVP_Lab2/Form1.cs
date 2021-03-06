namespace TVP_Lab2
{
    public partial class Form1 : Form
    {
        private EV3Motor motor1, motor2, motor3;
        private Graphics form_graphics;
        private bool mousePressed;
        public Form1()
        {
            InitializeComponent();
            this.form_graphics = this.CreateGraphics();
            mousePressed = false;
            motor1 = new EV3Motor(this.form_graphics, new Point(100, 600), 0.75, Utils.MotorStatus.OnForRotations, 30, 80);
            motor2 = new EV3Motor(this.form_graphics, new Point(700, 440), 1.4, Utils.MotorStatus.OnForDegrees, 20, 60);
            motor3 = new EV3Motor(this.form_graphics, new Point(10, 10), 2, Utils.MotorStatus.Off, 10, 70);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            EV3Motor.DrawEvery();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var cursorPos = e.Location;
            
            if (e.Button == MouseButtons.Left)
            {
                EV3Motor.ClickEvery(cursorPos);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePressed = true;
            }
        }
        

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            var cursorPos = e.Location;
            if (mousePressed)
            {
                //motor1.Click(cursorPos);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePressed = false;
            }
        }
    }
}