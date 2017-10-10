using System.Collections.Generic;
using System.Drawing;
using static Demo_app.Helper;

namespace Demo_app
{
    public class Graphic_Object
    {
        private ShapeType shape;
        private int x;
        private int y;
        private int width;
        private int height;
        private bool isFill;
        private bool isGrouped;
        public List<Graphic_Object> groupedElements;
        public Color color;

        Rectangle rect;
        Pen pen;
        SolidBrush blackBrush;

        public Graphic_Object()
        {
            color = Color.Black;
            rect = new Rectangle();
            pen = new Pen(color);
            blackBrush = new SolidBrush(color);

            groupedElements = new List<Graphic_Object>();
        }

        public ShapeType Shape
        {
            get { return shape; }
            set { shape = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public bool IsFill
        {
            get { return isFill; }
            set { isFill = value; }
        }

        public bool IsGrouped {
            get { return isGrouped; }
            set { isGrouped = value; }
        }

        public void drawShape(Graphics g)
        {
            pen.Color = color;
            blackBrush.Color = color;

            switch (shape)
            {
                case ShapeType.Oval:
                    {
                        rect.X = x;
                        rect.Y = y;
                        rect.Width = width;
                        rect.Height = height;

                        if (isFill)
                            g.FillEllipse(blackBrush, rect);
                        else
                            g.DrawEllipse(pen, rect);


                        break;
                    }
                case ShapeType.Line:
                    {
                        g.DrawLine(pen, new Point(x, y), new Point(x + width, y + height));
                        break;
                    }
                case ShapeType.Rectangle:
                    {
                        rect.X = x;
                        rect.Y = y;
                        rect.Width = width;
                        rect.Height = height;
                        g.DrawRectangle(pen, rect);
                        break;
                    }
            }

        }

        
    }
}
