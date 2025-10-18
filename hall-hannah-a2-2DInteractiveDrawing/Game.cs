// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.Drawing;
using System.Numerics;
using System.Security.AccessControl;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color black         = new Color("#212123");
        Color white         = new Color("#f2f0e5");
        Color brown         = new Color("#80493a");
        Color orange        = new Color("#d3a068");
        Color darkOrange    = new Color("#a77b5b");
        Color yellow        = new Color("#e5ceb4");
        Color darkGreen     = new Color("#4e584a");
        Color blue          = new Color("#4b80ca");
        Color darkBlue      = new Color("#43436a");
        Color lightPink     = new Color("#edc8c4");
        Color pink          = new Color("#cf8acb");

        Color catColor = Color.LightGray;

        int x;
        int y;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("2D Interactive Drawing");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(black);

            DrawBackground();
            DrawPumpkin();
            DrawCat();

            /*
            for (int i = 0; i < positions.Length; i++) //i++ is same as i +=1
            {
                Vector2 position = positions[i];
                int radius = radii[i];
                float corneaR = radius;
                float irisR = radius * 0.7f;
                float pupilR = radius * 0.35f;
                DrawSmallStars(position, corneaR, irisR, pupilR);
            }
            */
        }

        void DrawOutlinePixel(int x, int y, int size)
        {
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Black;
            Draw.Square(x, y, size);
        }
        void DrawOutlineRectangle(int x, int y, int w, int h)
        {
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Black;
            Draw.Rectangle(x, y, w, h);
        }

            void DrawPumpkin()
        {
            //Color Fill Pumpkin  
            Draw.LineSize = 1;
            Draw.LineColor = orange;
            Draw.FillColor = orange;
            Draw.Rectangle(55, 305, 80, 35);
            Draw.Rectangle(55, 295, 75, 10);
            Draw.Rectangle(65, 290, 65, 5);
            Draw.Rectangle(70, 285, 35, 5);
            //Color Fill Stem  
            Draw.LineSize = 1;
            Draw.LineColor = brown;
            Draw.FillColor = brown;
            Draw.Square(100, 270, 5);
            Draw.Rectangle(95, 275, 10, 5);
            Draw.Rectangle(90, 280, 10, 5);

            //bottom outline
            DrawOutlineRectangle(65, 340, 60, 5);
            //left outline ascending horizontal
            DrawOutlineRectangle(55, 335, 10, 5);
            //right outline ascending horizontal
            DrawOutlineRectangle(125, 335, 10, 5);
            //right outline ascending vertical
            DrawOutlineRectangle(135, 305, 5, 30);
                DrawOutlineRectangle(130, 295, 5, 10);
            //left outline ascending vertical
            DrawOutlineRectangle(50, 305, 5, 30);
                DrawOutlineRectangle(55, 295, 5, 10);
            //left outline ascending horizontal (top line)
            DrawOutlineRectangle(60, 290, 10, 5);
                DrawOutlineRectangle(70, 285, 15, 5);
            //right outline ascending horizontal (top line)
            DrawOutlineRectangle(120, 290, 10, 5);
                DrawOutlineRectangle(105, 285, 15, 5);
            //top outline
            DrawOutlineRectangle(90, 285, 10, 5);

            //stem
            DrawOutlinePixel(85, 280, 5);
            DrawOutlinePixel(100, 280, 5);
            DrawOutlinePixel(90, 275, 5);
            DrawOutlineRectangle(95, 265, 5, 10);
            DrawOutlineRectangle(100, 265, 10, 5);
            DrawOutlineRectangle(105, 265, 5, 15);

            //Pumpkin Detail Lines
            //Left
            Draw.LineSize = 1;
            Draw.LineColor = darkOrange;
            Draw.FillColor = darkOrange;
            Draw.Rectangle(65, 310, 5, 20);
            Draw.Rectangle(70, 300, 5, 10);
            Draw.Square(75, 335, 5);
            Draw.Square(70, 330, 5);
            Draw.Square(80, 290, 5);
            Draw.Square(75, 295, 5);
            //Right
            Draw.Rectangle(120, 310, 5, 20);
            Draw.Rectangle(115, 300, 5, 10);
            Draw.Square(110, 335, 5);
            Draw.Square(115, 330, 5);
            Draw.Square(105, 290, 5);
            Draw.Square(110, 295, 5);
            //Centre
            Draw.Rectangle(95, 290, 5, 50);
            Draw.Square(90, 290, 5);
        }

            void DrawCat()
        {
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                //Assign Random Color
                catColor = Random.Color();
            }
                //Fill Cat Color
                Draw.LineSize = 1;
                    Draw.LineColor = catColor; // MAKE CHANGEABLE
                    Draw.FillColor = catColor; //
                Draw.Rectangle(195, 265, 45, 80);
                Draw.Rectangle(190, 315, 5, 20);
                Draw.Rectangle(240, 315, 5, 20);
                Draw.Square(195, 260, 5);
                Draw.Square(235, 260, 5);
                //Fill Tail Color
                Draw.Rectangle(245, 335, 15, 5);
                Draw.Rectangle(250, 330, 15, 5);
                Draw.Rectangle(255, 325, 15, 5);
                Draw.Rectangle(260, 310, 15, 15);

            //Eye Color
            Draw.LineSize = 1;
                Draw.LineColor = darkBlue; // MAKE CHANGEABLE
                Draw.FillColor = darkBlue; //
            Draw.Square(205, 285, 5);
            Draw.Square(225, 285, 5);
            //Nose
            Draw.LineSize = 1;
            Draw.LineColor = black;
            Draw.FillColor = black;
            Draw.Square(215, 290, 5);

            //bottom outline
            DrawOutlineRectangle(190, 340, 70, 5);
            //Left back foot
            DrawOutlinePixel(200, 335, 5);
            DrawOutlineRectangle(195, 325, 5, 10);
            DrawOutlinePixel(190, 335, 5);
            //Right back foot
            DrawOutlinePixel(230, 335, 5);
            DrawOutlineRectangle(235, 325, 5, 10);
            DrawOutlinePixel(240, 335, 5);
            //Front feet
            DrawOutlineRectangle(210, 325, 5, 15);
            DrawOutlineRectangle(220, 325, 5, 15);
            //Torso Sides
            DrawOutlineRectangle(245, 315, 5, 20);
            DrawOutlineRectangle(185, 315, 5, 20);
            DrawOutlineRectangle(240, 305, 5, 10);
            DrawOutlineRectangle(190, 305, 5, 10);
            DrawOutlinePixel(195, 300, 5);
            DrawOutlinePixel(235, 300, 5);
            //Tail
            DrawOutlinePixel(260, 335, 5);
            DrawOutlinePixel(265, 330, 5);
            DrawOutlineRectangle(270, 310, 5, 20);
            DrawOutlineRectangle(260, 305, 10, 5);
            DrawOutlineRectangle(255, 310, 5, 15);
            DrawOutlinePixel(250, 325, 5);
            //Head
            DrawOutlineRectangle(240, 255, 5, 45);
            DrawOutlineRectangle(190, 255, 5, 45);
            DrawOutlineRectangle(205, 265, 25, 5);
            //Whiskers
            DrawOutlinePixel(185, 295, 5);
            DrawOutlinePixel(185, 285, 5);
            DrawOutlinePixel(245, 295, 5);
            DrawOutlinePixel(245, 285, 5);
            //Eyes
            DrawOutlinePixel(205, 280, 5);
            DrawOutlinePixel(225, 280, 5);
            //Ears left & right
            DrawOutlinePixel(195, 255, 5);
            DrawOutlinePixel(200, 260, 5);
            DrawOutlinePixel(235, 255, 5);
            DrawOutlinePixel(230, 260, 5);
        }

            void DrawBackground()
        {
            void DrawSmallStars()
            {
                ///Do the randomization stuff
                if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
                {
                    x = Random.Integer(5, 400 - 5);
                    y = Random.Integer(5, 400 - 5);
                }
                Draw.LineSize = 1;
                Draw.LineColor = white;
                Draw.FillColor = white;
                ///You could also do: Draw.FillColor = Random.Color; (but that gives you a seizure)
                Draw.Square(x, y, 5);
            }
            //Draw Smaller Stars
            DrawSmallStars();
            //Draw Moon
            {
                //Color Fill Moon
                Draw.LineSize = 1;
                Draw.LineColor = white;
                Draw.FillColor = white;
                Draw.Rectangle(250, 80, 60, 120);
                Draw.Rectangle(215, 115, 130, 50);
                Draw.Rectangle(225, 100, 110, 80);
                Draw.Rectangle(240, 85, 80, 110);
                Draw.Rectangle(235, 90, 90, 95);
                ///Bottom Line
                DrawOutlineRectangle(260, 200, 40, 5);
                ///Left Side Ascending Order
                DrawOutlineRectangle(250, 195, 10, 5);

                DrawOutlineRectangle(240, 190, 10, 5);

                DrawOutlinePixel(235, 185, 5);
                DrawOutlinePixel(230, 180, 5);
                DrawOutlinePixel(225, 175, 5);

                DrawOutlineRectangle(220, 165, 5, 10);
                DrawOutlineRectangle(215, 155, 5, 10);
                DrawOutlineRectangle(210, 125, 5, 30);
                DrawOutlineRectangle(215, 115, 5, 10);
                DrawOutlineRectangle(220, 105, 5, 10);

                DrawOutlinePixel(225, 100, 5);
                DrawOutlinePixel(230, 95, 5);
                DrawOutlinePixel(235, 90, 5);

                DrawOutlineRectangle(240, 85, 10, 5);
                DrawOutlineRectangle(250, 80, 10, 5);
                ///Right Side Ascending Order
                DrawOutlineRectangle(300, 195, 10, 5);

                DrawOutlineRectangle(310, 190, 10, 5);

                DrawOutlinePixel(320, 185, 5);
                DrawOutlinePixel(325, 180, 5);
                DrawOutlinePixel(330, 175, 5);

                DrawOutlineRectangle(335, 165, 5, 10);
                DrawOutlineRectangle(340, 155, 5, 10);
                DrawOutlineRectangle(345, 125, 5, 30);
                DrawOutlineRectangle(335, 105, 5, 10);
                DrawOutlineRectangle(340, 115, 5, 10);

                DrawOutlinePixel(330, 100, 5);
                DrawOutlinePixel(325, 95, 5);
                DrawOutlinePixel(320, 90, 5);

                DrawOutlineRectangle(310, 85, 10, 5);
                DrawOutlineRectangle(300, 80, 10, 5);
                ///Top Line
                DrawOutlineRectangle(260, 75, 40, 5);
            }
            //Draw Ground
            {
                Draw.LineSize = 0;
                Draw.LineColor = darkGreen;
                Draw.FillColor = darkGreen;
                Draw.Rectangle(0, 330, 400, 70);
            }
        }
    }

}
