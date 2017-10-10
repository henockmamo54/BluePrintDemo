using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Demo_app
{
    public class Helper
    {
        public enum ShapeType { Oval, Line,Rectangle }
        public static bool isPointInTheElipse(Rectangle rect, Point p)
        {

            // use the bounding box of your ellipse instead
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(rect);
            bool pointWithinEllipse = myPath.IsVisible(p.X, p.Y);
            return pointWithinEllipse;
        }

        public static bool isPointWithinLine(Point p, Graphic_Object obj)
        {
            try
            {
                bool status = (p.X - obj.X) / (obj.Width) == (p.Y - obj.Y) / (obj.Height);
                return status;
            }
            catch (Exception e) { 
            return false;}
        }

        public static bool isPointWithinRect(Point g, Graphic_Object obj) {
            bool status = (g.X > obj.X && g.Y > obj.Y && g.X < (obj.X + obj.Width) && g.Y < (obj.Y + obj.Height));
            return status;
        }


        public static List<Graphic_Object> findElementsInGroupPanel(Graphic_Object obj, List<Graphic_Object> mylist) {
            List<Graphic_Object> foundlist = new List<Graphic_Object>();

            foreach (Graphic_Object g in mylist) {
                if (g.X > obj.X && g.Y > obj.Y && g.X < (obj.X + obj.Width) && g.Y < (obj.Y + obj.Height))
                    foundlist.Add(g);
            }

            return foundlist;
        }


    }

}
