/*
 * Свойства Properties
 * 
 * Автоматичесие свойства
 */

namespace _44_yrok
{
    class Point
    {
        private int x;


        public void SetX(int x)
        {
            if (x < 1)
            {
                this.x = 1;
                return;
            }
            if (x > 5)
            {
                this.x = 5;
                return;
            }

            this.x = x;
        }
        public int GetX()
        {
            return x;
        }
        private float y;

        public float Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value < 1)
                {
                    y = 1;
                    return;
                }
                if (value > 5)
                {
                    y = 5;
                    return;
                }

                y = value;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.SetX(0);

            int x = point.GetX();

            point.Y = 0;

            float Y = point.Y;
        }
    }
}
