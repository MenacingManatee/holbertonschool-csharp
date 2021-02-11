using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        foreach (var filename in filenames) {
            Console.Write(filename);
            using (var image = new Bitmap(System.Drawing.Image.FromFile(filename)))
            {
                ImageFormat format = image.RawFormat;
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        Color n = image.GetPixel(x, y);
                        n = Color.FromArgb(255, (255 - n.R), (255 - n.G), (255 - n.B));
                        image.SetPixel(x, y, n);
                    }
                }
                string fname = Path.GetFileName(filename);
                string[] fname_split = fname.Split('.');
                image.Save(fname_split[0] + "_inverse." + fname_split[1], format);
            }
        }
    }
    public static void Grayscale(string[] filenames)
    {
        foreach (var filename in filenames) {
            Console.Write(filename);
            using (var image = new Bitmap(System.Drawing.Image.FromFile(filename)))
            {
                ImageFormat format = image.RawFormat;
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        Color n = image.GetPixel(x, y);
                        int av = (n.R + n.G + n.B) / 3;
                        n = Color.FromArgb(255, av, av, av);
                        image.SetPixel(x, y, n);
                    }
                }
                string fname = Path.GetFileName(filename);
                string[] fname_split = fname.Split('.');
                image.Save(fname_split[0] + "_grayscale." + fname_split[1], format);
            }
        }
    }
}
