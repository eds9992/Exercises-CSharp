using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
    /*
     * Assignment
     * Add Square and Triangle classes to shape
     */
{
    public abstract class Shape
    {
        private int x;
        private int y;

        public Shape(int newX, int newY)
        {
            setX(newX);
            setY(newY);
        }

        public void setX(int newX)
        {
            x = newX;
        }

        public void setY(int newY)
        {
            y = newY;
        }

        public int getX() { return x; }
        public int getY() { return y; }

        public void moveTo(int newX, int newY)
        {
            setX(newX);
            setY(newY);
        }

        public void rMoveTo(int deltaX, int deltaY)
        {
            moveTo(deltaX + getX(), deltaY + getY());
        }

        public abstract void draw();
    }

    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int newX, int newY, int newW, int newH) : base(newX, newY)
        {
            setWidth(newW);
            setHeight(newH);
        }

        public void setWidth(int newW)
        {
            width = newW;
        }

        public void setHeight(int newH)
        {
            height = newH;
        }

        public int getWidth() { return width; }
        public int getHeight() { return height; }

        public override void draw()
        {
            Console.WriteLine("Drawing a rectangle starting at: " + getX() + ", " + getY() + "\r\n");
        }
    }

    public class Circle : Shape
    {
        private int radius;

        public Circle(int newX, int newY, int newR) : base(newX, newY)
        {
            setRadius(newR);
        }

        public void setRadius(int newR)
        {
            radius = newR;
        }

        public int getRadius()
        {
            return radius;
        }

        public override void draw()
        {
            Console.WriteLine("Drawing a circle starting at: " + getX() + ", " + getY() + "\r\n");
        }
    }
    
    public class Square : Shape
    {
        private int width;
        private int height;

        public Square(int newX, int newY, int newW, int newH) : base(newX, newY)
        {
            setWidth(newW);
            setHeight(newH);
        }

        public void setWidth(int newW)
        {
            width = newW;
        }

        public void setHeight(int newH)
        {
            height = newH;
        }

        public int getWidth() { return width; }
        public int getHeight() { return height; }

        public override void draw()
        {
            Console.WriteLine("Drawing a square starting at: " + getX() + ", " + getY() + "\r\n");
        }
    }

    public class Triangle : Shape
    {
        private int Base; // I capitalized "Base" since C# already uses it
        private int height;

        public Triangle(int newX, int newY, int newB, int newH) : base(newX, newY)
        {
            setBase(newB);
            setHeight(newH);
        }

        public void setBase(int newB)
        {
            Base = newB;
        }

        public void setHeight(int newH)
        {
            height = newH;
        }

        public int getBase() { return Base; }
        public int getHeight() { return height; }

        public override void draw()
        {
            Console.WriteLine("Drawing a triangle starting at: " + getX() + ", " + getY() + "\r\n");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(1, 1, 3, 5);
            r1.draw();
            r1.moveTo(2, 3);
            r1.draw();

            Circle c1 = new Circle(3, 5, 4);
            c1.draw();
            c1.rMoveTo(1, 1);
            c1.draw();

            Square s1 = new Square(2, 2, 2, 2);
            s1.draw();
            s1.moveTo(2, 3);
            s1.draw();

            Triangle t1 = new Triangle(2, 2, 2, 2);
            t1.draw();
            t1.moveTo(2, 3);
            t1.draw();
            /*
            Shape[] scribble = new Shape[2];
            scribble[0] = r1;
            scribble[1] = c1;
            scribble[2] = s1;
            scribble[3] = t1;
            for (int i = 0; i < scribble.Length; ++i)
            {
                scribble[i].draw();
                scribble[i].rMoveTo(4, 8);
                scribble[i].draw();
            }
            */
            Console.ReadLine();
        }
    }
}
