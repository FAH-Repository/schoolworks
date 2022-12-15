using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bricks {
   
    public static class Maps {
        
        public static ushort [,] GetBrickArray(List<string> lines) {
            ushort[,] brickArray = new ushort[lines[0].Length, lines.Count];
            for (int x = 0; x < lines[0].Length; x++) {
                for (int y = 0; y < lines.Count; y++) {
                    switch(lines[y][x]) {
                        case '.':
                            brickArray[x, y] = 0;
                            break;
                        case '1':
                            brickArray[x, y] = 1;
                            break;
                        case '2':
                            brickArray[x, y] = 2;
                            break;
                        case '3':
                            brickArray[x, y] = 3;
                            break;
                        default:
                            brickArray[x, y] = 0;
                            break;
                    }
                }
            }
            return brickArray;
        }
        /* This is a template! Copy/Paste it!
                public static List<string> MapTemplate() {
                    List<string> lines = new List<string>();
                    lines.Add(Stuff);
                    return lines;
                } */
       
        public static List<string> BasicLines()
        {
         
            List<string> lines = new List<string>();
            int b = 0;
            int i = 0;
            var random = new Random();
            while (b < 13)
            {
                var chars = "0123";
                var stringChars = new char[29];

                for (i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                    
                }

                var finalString = new String(stringChars);
                lines.Add(finalString); // 29
             
                i = 0;
                b++;
                
            }
       
            return lines;
        }
    }
}
