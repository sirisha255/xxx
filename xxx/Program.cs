namespace xxx
{
    internal static class xxx
    {
        public static void run()
        {
            Console.WriteLine("Type in the width of an image to know if it is on Landscape or Portrait:");

            Console.WriteLine("Width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Height: ");
            int heigth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetImageOrientation(width, heigth));
        }

        private static string GetImageOrientation(int width, int heigth)
        {
            if (width == heigth)
                return "Both values are the same. The image has a 1:1 ratio";
            if (width > heigth)
                return "Landscape";

            return "Portrait";
        }
    }
}