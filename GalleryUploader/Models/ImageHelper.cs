using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace Leniwce
{
    public class ImageHelper
    {
      
        public static bool IsFormatValid(Image i)
        {
            if (i.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg)
            || i.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif)
            || i.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
                return true;

            return false;
        }
        public Image ResizeToWidth(Image image, int newWidth)
        {
            Graphics gr = Graphics.FromImage(image);
            //double newHeight = Convert.ToDouble(image.Width) / Convert.ToDouble(image.Height) * Convert.ToDouble(newWidth);
            double newHeight = Convert.ToDouble(image.Height) * (Convert.ToDouble(newWidth) / Convert.ToDouble(image.Width));
            Bitmap newImg = new Bitmap(newWidth, (int)newHeight);
            Graphics.FromImage(newImg).DrawImage(image, 0, 0, newWidth, (int)newHeight);
            return newImg;
        }

        public Image ResizeToHeight(Image image, int newHeight)
        {
            Graphics gr = Graphics.FromImage(image);
            //double newWidth = Convert.ToDouble(image.Width) / Convert.ToDouble(image.Height) * Convert.ToDouble(newHeight);
            double newWidth = Convert.ToDouble(image.Width) * (Convert.ToDouble(newHeight) / Convert.ToDouble(image.Height));
            Bitmap newImg = new Bitmap((int)newWidth, (int)newHeight);
            Graphics.FromImage(newImg).DrawImage(image, 0, 0, (int)newWidth, (int)newHeight);
            return newImg;
        }

        public Image ResizeToSquare(Image image, int newSize)
        {
            int x, y;
            int newX, newY;
            x = image.Width;
            y = image.Height;
            newX = x;
            newY = y;
            //robie by byly wieksze
            if (newX < newSize || newY < newSize)
            { //trzeba powiekszyc
                if (newX < newSize)
                {
                    newX = newSize;
                    newY = (int)(Convert.ToDouble(newSize) / Convert.ToDouble(x) * Convert.ToDouble(y));
                }
                if (newY < newSize)
                {
                    newY = newSize;
                    newX = (int)(Convert.ToDouble(newSize) / Convert.ToDouble(y) * Convert.ToDouble(x));
                }
            }
            //oba sa zbyt wielkie
            if (newX >= newSize && newY > newSize)
            {
                if (newX > newY) //przeskaluje wg mniejszego - wg y
                {                    
                    newX = (int)(Convert.ToDouble(newSize) * Convert.ToDouble(newX) / Convert.ToDouble(newY));
                    newY = newSize;
                }
                else
                {                    
                    newY =  (int)(Convert.ToDouble(newSize) * Convert.ToDouble(newY) / Convert.ToDouble(newX));
                    newX = newSize;
                }
            }
            //wycinam srodek
            int offsetX = (newX - newSize) / 2;
            int offsetY = (newY - newSize) / 2;


            Graphics gr = Graphics.FromImage(image);        
            //skalujemy
            Bitmap newImg = new Bitmap(newX, newY);
            Graphics.FromImage(newImg).DrawImage(image, 0, 0, newX, newY);
            //teraz zabieramy srodek
            Rectangle srcRect = new Rectangle(offsetX, offsetY, newSize, newSize);
            Bitmap cropped = (Bitmap)newImg.Clone(srcRect, image.PixelFormat);
           
            return cropped;
        }

        public byte[] ImageToByteArr(Image img)
        {
            byte[] arr;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                arr = ms.ToArray();
            }
            return arr;
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}