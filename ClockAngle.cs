using System;

namespace ConsoleApp1
{
    class Program
    {

        public static int calculateAngle(int hours, int minutes)
        {
            if(hours > 12 || minutes>60 || minutes<0 || hours<0)
            {
                Console.Write("wrong inputs, please try again.");
            }

            if(minutes==60)
            {
                minutes = 0;
                hours = hours + 1;

                if(hours>12)
                {
                    hours = hours - 12;
                }

            }

            if(hours==12)
            {
                hours = 0;
            }



            //Get hours angle
            float hDegrees = 360.0f / (12.0f * 60.0f);
            int hAngle =(int) (((hours * 60) +minutes) * hDegrees) ;

            //Get minutes angle
            double mDegrees = (double)(360.0f / 60.0f);
            int mAngle = (int)(minutes * mDegrees);

            //Get difference between 2 angles
            int diff = Math.Abs(hAngle - mAngle);
            diff = Math.Min(360 - diff, diff);
       
            return diff;

        }


        static void Main(string[] args)
        {

            Console.WriteLine(calculateAngle(12, 30));
            Console.Write(calculateAngle(3, 30));

        }


      
    }
}

