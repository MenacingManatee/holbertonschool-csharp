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
    public static void BlackWhite(string[] filenames, double threshold)
    {
        foreach (var filename in filenames) {
            using (var image = new Bitmap(System.Drawing.Image.FromFile(filename)))
            {
                ImageFormat format = image.RawFormat;
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        Color n = image.GetPixel(x, y);
                        double lum = (0.2126 * n.R + 0.7152 * n.G + 0.0722 * n.B);
                        if (lum > threshold) {
                            n = Color.FromArgb(255, 255, 255, 255);
                        }
                        else {
                            n = Color.FromArgb(255, 0, 0, 0);
                        }
                        image.SetPixel(x, y, n);
                    }
                }
                string fname = Path.GetFileName(filename);
                string[] fname_split = fname.Split('.');
                image.Save(fname_split[0] + "_bw." + fname_split[1], format);
            }
        }
    }
    public static void Thumbnail(string[] filenames, int height)
    {
        foreach (var filename in filenames) {
            using (var image = new Bitmap(System.Drawing.Image.FromFile(filename)))
            {
                double w;
                w = ((double)image.Height / (double)image.Width) * (double)height;
                ImageFormat format = image.RawFormat;
                Image thumb = image.GetThumbnailImage(height, (int)Math.Round(w, 0), ()=>false, IntPtr.Zero);
                string fname = Path.GetFileName(filename);
                string[] fname_split = fname.Split('.');
                thumb.Save(fname_split[0] + "_th." + fname_split[1], format);
            }
        }
    }
}
