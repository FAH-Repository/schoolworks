using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMaster
{
    public static class Pathing
    {
        public static Vector2 aStar(Point source, Point target, List<string> map)
        {
            int mapWidth = map[0].Length;
            int mapHeight = map.Count;
            List<Vector3> pathGrid = new List<Vector3>();
            bool[,] checkedPath = new bool[mapWidth, mapHeight];
            pathGrid.Add(new Vector3(target.X, target.Y, 0));
            bool pathFound = false;
            int i = 0;

            while (i < pathGrid.Count)
            {

                if (pathGrid[i].Y > 0) // check if source is above current square
                {
                    if (pathGrid[i].Y - 1 == source.Y && pathGrid[i].X == source.X)
                    //if source is above me
                    {
                        checkedPath[(int)pathGrid[i].X, (int)pathGrid[i].Y - 1] = true; 
                        // say we checked the square above me
                        pathFound = true;
                        // YAY!We found a path
                        return new Vector2(0, 1);
                        // enemy moves down
                    }
                    else if (map[(int)pathGrid[i].Y - 1][(int)pathGrid[i].X] == '.' &&
                        !checkedPath[(int)pathGrid[i].X, (int)pathGrid[i].Y - 1])
                    // if square above is a.
                    {
                        pathGrid.Add(new Vector3(pathGrid[i].X, pathGrid[i].Y - 1,
                            pathGrid[i].Z + 1));
                        // add a row to our path list
                        checkedPath[(int)pathGrid[i].X, (int)pathGrid[i].Y - 1] = true;
                        // we checked that square, don't check it again 
                    }
                }


                if (pathGrid[i].Y < mapHeight - 1 && !pathFound) // check if source is above current square
                {
                    if (pathGrid[i].Y + 1 == source.Y && pathGrid[i].X == source.X)
                    //if source is above me 
                    {
                        checkedPath[(int)pathGrid[i].X, (int)pathGrid[i].Y + 1] = true;
                        // say we checked the square above me
                        pathFound = true;
                        // YAY!We found a path
                        return new Vector2(0, -1);
                        // enemy moves down
                    }
                    else if (map[(int)pathGrid[i].Y + 1][(int)pathGrid[i].X] == '.' &&
                        !checkedPath[(int)pathGrid[i].X, (int)pathGrid[i].Y + 1])
                    // if square above is a .
                    {
                        pathGrid.Add(new Vector3(pathGrid[i].X, pathGrid[i].Y + 1,
                            pathGrid[i].Z + 1));
                        // add a row to our path list
                        checkedPath[(int)pathGrid[i].X, (int)pathGrid[i].Y + 1] = true;
                        // we checked that square, don't check it again 
                    }
                }


                    if (pathGrid[i].X > 0 && !pathFound) // check if source is above current square
                    {
                        if (pathGrid[i].Y == source.Y && pathGrid[i].X - 1 == source.X)
                    //if source is above me
                    {
                        checkedPath[(int)pathGrid[i].X - 1, (int)pathGrid[i].Y] = true; 
                        // say we checked the square above me
                        pathFound = true;
                        // VAY! We found a path
                        return new Vector2(1, 0);
                        // enemy moves down
                        }
                        else if (map[(int)pathGrid[i].Y][(int)pathGrid[i].X - 1] == '.' &&
                            !checkedPath[(int)pathGrid[i].X - 1, (int)pathGrid[i].Y])
                        // if square above is a .
                        {
                            pathGrid.Add(new Vector3(pathGrid[i].X - 1, pathGrid[i].Y, 
                                pathGrid[i].Z + 1));
                            // add a row to o ur path list
                            checkedPath[(int)pathGrid[i].X - 1, (int)pathGrid[i].Y] = true;
                            // we checked that square, don't check it again 
                        }
                    }


                    if (pathGrid[i].X < mapWidth - 1 && !pathFound) // check if source is above current space
                    {
                        if (pathGrid[i].Y == source.Y && pathGrid[i].X + 1 == source.X)
                        // if source is above me
                        {
                            checkedPath[(int)pathGrid[i].X + 1, (int)pathGrid[i].Y] = true; 
                        // say we checked the square above me
                            pathFound = true;
                            // VAY!We found a path
                            return new Vector2(-1, 0);
                            // enemy moves down
                        }
                            else if (map[(int)pathGrid[i].Y][(int)pathGrid[i].X + 1] == '.' && !checkedPath[(int)pathGrid[i].X + 1, (int)pathGrid[i].Y])
                            // if square is above a .
                            {
                                pathGrid.Add(new Vector3(pathGrid[i].X + 1, pathGrid[i].Y,
                                pathGrid[i].Z + 1));
                                // add a row to our path list
                                checkedPath[(int)pathGrid[i].X + 1, (int)pathGrid[i].Y] = true;
                                // we checked that square, don't check it again
                             }
                    }
                        i++;
            }
                return Vector2.Zero;
        }
    }
}
