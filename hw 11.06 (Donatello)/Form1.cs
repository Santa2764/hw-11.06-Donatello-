namespace hw_11._06__Donatello_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pn = new Pen(Brushes.Black, 2);

            //green part of body (silhouette)
            g.FillEllipse(Brushes.LimeGreen, 128, 118, 114, 146);  //body
            g.FillEllipse(Brushes.LimeGreen, 150, 95, 70, 50);  //head
            g.FillEllipse(Brushes.LimeGreen, 160, 78, 50, 48);
            g.FillEllipse(Brushes.LimeGreen, 110, 202, 28, 28);  //hands
            g.FillEllipse(Brushes.LimeGreen, 232, 202, 28, 28);
            g.FillRectangle(Brushes.LimeGreen, 202, 250, 17, 50);  //legs
            g.FillRectangle(Brushes.LimeGreen, 152, 250, 17, 50);

            //purple bandages
            g.FillRectangle(Brushes.Purple, 160, 83, 50, 15);  //head
            g.FillRectangle(Brushes.Purple, 202, 280, 17, 11);  //leges
            g.FillRectangle(Brushes.Purple, 152, 280, 17, 11);

            //yellow shit on body
            g.FillRectangle(Brushes.Yellow, 150, 145, 70, 65);
            g.FillEllipse(Brushes.Yellow, 150, 175, 70, 70);

            //stick
            g.FillRectangle(Brushes.Olive, 239, 90, 15, 210);
            g.FillRectangle(Brushes.LightSlateGray, 239, 160, 15, 70);

            //g.FillRectangle(Brushes.Green, 125, 170, 120, 30);

            g.Dispose();
        }
    }
}