using System;
using System.Drawing;
using System.Windows.Forms;

namespace PixelRuler {
    public partial class PixelRuler: Form {
        // Define ruler maximums.
        private const int MAX_WIDTH = 1200;
        private const int MAX_HEIGHT = 1200;

        public PixelRuler () {
            InitializeComponent();

            // Initial Title Bar display
            this.FormMarker_Resize(null, null);

            // Make all the labels
            Generate_Labels();
        }

        private void FormMarker_Resize (object sender, EventArgs e) {
            this.Text = "w:" + (this.DisplayRectangle.Width).ToString();
            this.Text += " h:" + (this.DisplayRectangle.Height).ToString();
        }

        // Create all the labels
        private void Generate_Labels () {
            for (int x = 0; x <= MAX_WIDTH - 100; x += 100) {
                for (int y = 0; y <= MAX_HEIGHT - 100; y += 100) {
                    Create_Label(
                        "w:" + x.ToString(), 
                        x + 4, 
                        y + 7, 
                        System.Drawing.Color.Blue
                    );
                    Create_Label(
                        "h:" + y.ToString(),
                        x + 4,
                        y + 21,
                        System.Drawing.Color.Red
                    );
                }
            }
        }

        // Make one label
        private void Create_Label (string txt, int x, int y, Color c) {
            var lab = new System.Windows.Forms.Label();
            lab.ForeColor = c;
            lab.Text = txt;
            lab.TabIndex = 0;
            lab.AutoSize = true;
            lab.Location = new System.Drawing.Point(x, y);
            lab.Font = new System.Drawing.Font(
                "Courier New", 
                8F, 
                System.Drawing.FontStyle.Regular, 
                System.Drawing.GraphicsUnit.Point, 
                (byte)(0)
            );
            this.Controls.Add(lab);
        }

        // > Paint all the rule lines. We need to do this whenever the form is
        //   painted. The rule labels take care of themselves.
        protected override void OnPaint (PaintEventArgs e) {
            base.OnPaint(e);
            Graphics g;
            g = e.Graphics;

            Pen myPenX = new Pen(Color.Blue);
            myPenX.Width = 1;

            Pen myPenY = new Pen(Color.Red);
            myPenY.Width = 1;

            for (int x = 0; x <= MAX_WIDTH; x += 100) {
                g.DrawLine(myPenX, x, 0, x, MAX_HEIGHT);
            }

            for (int y = 0; y <= MAX_HEIGHT; y += 100) {
                g.DrawLine(myPenY, 0, y, MAX_WIDTH, y);
            }

            for (int x = 0; x <= MAX_WIDTH - 100; x += 100) {
                for (int y = 0; y <= MAX_HEIGHT - 100; y += 100) {
                    g.DrawLine(myPenX, x + 50, y - 5, x + 50, y + 5);
                    g.DrawLine(myPenX, x + 25, y - 2, x + 25, y + 2);
                    g.DrawLine(myPenX, x + 75, y - 2, x + 75, y + 2);

                    g.DrawLine(myPenY, x - 5, y + 50, x + 5, y + 50);
                    g.DrawLine(myPenY, x - 2, y + 25, x + 2, y + 25);
                    g.DrawLine(myPenY, x - 2, y + 75, x + 2, y + 75);
                }
            }

            myPenY.Dispose();
            myPenX.Dispose();
        }
    }
}
