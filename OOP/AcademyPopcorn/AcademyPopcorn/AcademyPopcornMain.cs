using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;
            
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                ExplodingBlock expBlock = new ExplodingBlock(new MatrixCoords(startRow + 2,i));
                Block someMoreBlock = new Block(new MatrixCoords(startRow + 1, i));
                engine.AddObject(currBlock);
                engine.AddObject(expBlock);
                engine.AddObject(someMoreBlock);
            }

            MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1),3);

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

            //add sides
            for (int row = 0; row < WorldRows; row++)
            {
                IndestructibleBlock leftIndestructibleBlock = new IndestructibleBlock(new MatrixCoords(row,0));
                engine.AddObject(leftIndestructibleBlock);
                IndestructibleBlock rightIndestructibleBlock = new IndestructibleBlock(new MatrixCoords(row, WorldCols-1));
                engine.AddObject(rightIndestructibleBlock);
            }
            //add roof
            for (int col = 0; col < WorldCols; col++)
            {
                IndestructibleBlock topIndestructibleBlock = new IndestructibleBlock(new MatrixCoords(0,col));
                engine.AddObject(topIndestructibleBlock);
            }
            
            Gift gift = new Gift(new MatrixCoords(0,10));
            engine.AddObject(gift);

            GiftBlock giftBlock = new GiftBlock(new MatrixCoords(7,33));
            engine.AddObject(giftBlock);

        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            ShootEngine gameEngine = new ShootEngine(renderer, keyboard,120);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
