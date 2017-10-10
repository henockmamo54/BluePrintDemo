using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Demo_app
{
    public partial class Form1 : Form
    {
        Graphic_Object obj;
        Graphics g;
        List<Graphic_Object> drawnObjs = new List<Graphic_Object>();
        Point m_started;


        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rb_oval.Checked)
            {
                obj = new Graphic_Object();
                obj.X = e.X;
                obj.Y = e.Y;
                obj.Shape = Helper.ShapeType.Oval;
                drawnObjs.Add(obj);
            }
            else if (rb_line.Checked)
            {
                obj = new Graphic_Object();
                obj.X = e.X;
                obj.Y = e.Y;
                obj.Shape = Helper.ShapeType.Line;
                drawnObjs.Add(obj);
            }
            else if (rb_fill.Checked)
            {
                obj = new Graphic_Object();
                obj.X = e.X;
                obj.Y = e.Y;
                obj.Shape = Helper.ShapeType.Oval;
                obj.IsFill = true;
                drawnObjs.Add(obj);
            }
            else if (rb_move.Checked)
            {

                if (drawnObjs.Count != 0)
                {
                    bool isObjectFound = false;
                    Graphic_Object foundedObj = null;

                    // search for the drawable object near to the clikced point 
                    foreach (Graphic_Object o in drawnObjs)
                    {
                        if (o.Shape == Helper.ShapeType.Oval)
                            isObjectFound = Helper.isPointInTheElipse(new Rectangle(o.X, o.Y, o.Width, o.Height), new Point(e.X, e.Y));
                        else if (o.Shape == Helper.ShapeType.Line)
                            isObjectFound = Helper.isPointWithinLine(new Point(e.X, e.Y), o);
                        else if (o.Shape == Helper.ShapeType.Rectangle)
                            isObjectFound = Helper.isPointWithinRect(new Point(e.X, e.Y), o);

                        if (isObjectFound) foundedObj = o;


                    }

                    // get the starting point of the object 
                    if (foundedObj != null)
                    {
                        obj = foundedObj;
                        m_started = new Point(e.X - obj.X, e.Y - obj.Y);
                    }
                }

            }
            else if (rb_remove.Checked)
            {
                if (drawnObjs.Count != 0)
                {
                    bool isObjectFound = false;

                    // search for the nearest object 
                    foreach (Graphic_Object o in drawnObjs)
                    {
                        if (o.Shape == Helper.ShapeType.Oval)
                            isObjectFound = Helper.isPointInTheElipse(new Rectangle(o.X, o.Y, o.Width, o.Height), new Point(e.X, e.Y));
                        else if (o.Shape == Helper.ShapeType.Line)
                            isObjectFound = Helper.isPointWithinLine(new Point(e.X, e.Y), o);
                        else if (o.Shape == Helper.ShapeType.Rectangle)
                            isObjectFound = Helper.isPointWithinRect(new Point(e.X, e.Y), o);

                        // remove the found object and redraw the form
                        if (isObjectFound)
                        {
                            obj = o;
                            drawnObjs.Remove(o);
                            g.Clear(Color.WhiteSmoke);
                            foreach (Graphic_Object obj in drawnObjs)
                            {
                                obj.drawShape(g);
                                if (obj.IsGrouped)
                                {
                                    foreach (Graphic_Object j in obj.groupedElements)
                                        j.drawShape(g);
                                }
                            }
                            break;
                        }
                    }
                }
            }
            else if (rb_group.Checked)
            {
                // check the components inside the selected area
                obj = new Graphic_Object();
                obj.X = e.X;
                obj.Y = e.Y;
                obj.Shape = Helper.ShapeType.Rectangle;
                obj.color = Color.DarkGray;
                obj.IsGrouped = true;

                drawnObjs.Add(obj);

            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (rb_group.Checked)
            {
                List<Graphic_Object> elements = Helper.findElementsInGroupPanel(obj, drawnObjs);
                foreach (Graphic_Object g in elements)
                {
                    obj.groupedElements.Add(g);
                    //g.IsGrouped = true;
                    g.color = Color.DarkGray;
                    drawnObjs.Remove(g);
                }
            }

            obj = null;

            foreach (Graphic_Object obj in drawnObjs)
            {
                obj.drawShape(g);
                if (obj.IsGrouped)
                {
                    foreach (Graphic_Object j in obj.groupedElements)
                        j.drawShape(g);
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (obj != null && e.Button == MouseButtons.Left)
            {
                if (rb_fill.Checked || rb_oval.Checked || rb_line.Checked)
                {
                    obj.Width = e.X - obj.X;
                    obj.Height = e.Y - obj.Y;

                    g.Clear(Color.WhiteSmoke);
                    foreach (Graphic_Object obj in drawnObjs)
                    {
                        obj.drawShape(g);
                        if (obj.IsGrouped)
                        {
                            foreach (Graphic_Object j in obj.groupedElements)
                                j.drawShape(g);
                        }
                    }

                    //obj.drawShape(g);
                    Invalidate();
                }
                else if (rb_move.Checked)
                {
                    int previousx = 0;
                    int previousy = 0;

                    if (obj.IsGrouped)
                    {
                         previousx = obj.X;
                        previousy = obj.Y;
                    }

                    obj.X = (e.X - m_started.X);
                    obj.Y = (e.Y - m_started.Y);

                    g.Clear(Color.WhiteSmoke);
                    foreach (Graphic_Object r in drawnObjs)
                    {
                        r.drawShape(g);
                        if (r.IsGrouped)
                        {
                            foreach (Graphic_Object j in r.groupedElements)
                            {
                                if (obj.IsGrouped)
                                {
                                    j.X = j.X + (r.X - previousx);
                                    j.Y = j.Y + (r.Y - previousy);
                                }
                                j.drawShape(g);
                            }
                        }
                    }

                    Invalidate();
                }
                else if (rb_group.Checked)
                {
                    obj.Width = e.X - obj.X;
                    obj.Height = e.Y - obj.Y;

                    g.Clear(Color.WhiteSmoke);
                    foreach (Graphic_Object obj in drawnObjs)
                    {
                        obj.drawShape(g);
                        if (obj.IsGrouped)
                        {
                            foreach (Graphic_Object j in obj.groupedElements)
                                j.drawShape(g);
                        }
                    }
                    
                    Invalidate();
                }
            }
        }
    }
}
