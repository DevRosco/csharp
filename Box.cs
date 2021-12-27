using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy
{
    internal class Box
    {
        //member variable
        private int length = 3;
        private int height;
        
        //no need member variable if used short properties
       //  public int width; 

        private int volume;

        //short properties
        public int Width { set; get; }
        // this short propertie is same as longer version
        // but for longer you need member variable as this.width need to be set
        /*
         public int Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        */
        

        //properties height capital first letter Height get set
        public int Height
        {get
            {
                return height;
            }
            set
            {   
                if(value < 0)
                {
                    height = -value;
                } else
                {
                   height = value;
                }
                
            }
        }

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
          
        }

        //constructor
        public Box(int length, int height, int width )
        {
            this.length = length;
            //member variable use the key word this
            this.height = height;
            //propertie no need this key word
            Width = width;
        }

        //set setter
        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be greater than 0!");
            }
            this.length = length;
        }

        //get getter
        public int GetLength()
        {
            return this.length;
        }

        /* this we replaced with set get volume
        public int GetVolume()
        {
            return this.length * this.height * this.Width;
        }
        */
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and the width is {2} so volume is {3}",
                length, height, Width, volume = length*height*Width);
        }



    }
}
