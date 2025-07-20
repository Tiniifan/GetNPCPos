using System.Drawing;

namespace GetNPCPos.Tools
{
    public class Draw
    {
        public static Bitmap DrawImage(Bitmap bmp, int x, int y, Image imagePath)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(imagePath, new Point(x, y));
            }
            return bmp;
        }

        public static Bitmap DrawImageWithRedCircle(Bitmap bmp, int x, int y, Image imagePath)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Créer un pinceau rouge transparent
                using (Brush redBrush = new SolidBrush(Color.FromArgb(128, 255, 0, 0)))
                {
                    // Calculer les coordonnées pour le cercle en fonction de l'image
                    int circleX = x - 5; // Ajustez ces valeurs en fonction de vos besoins
                    int circleY = y - 5;
                    int circleWidth = imagePath.Width + 10;
                    int circleHeight = imagePath.Height + 10;

                    // Dessiner le cercle rouge transparent
                    g.FillEllipse(redBrush, new Rectangle(circleX, circleY, circleWidth, circleHeight));

                    // Dessiner l'image dans le cercle rouge
                    g.DrawImage(imagePath, new Point(x, y));
                }
            }

            return bmp;
        }
    }
}
