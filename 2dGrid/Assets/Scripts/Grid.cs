using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{

    private int width;
    private int height;
    private int cellSize;
    private int[,] grid;

    public Grid(int height, int width, int cellSize)
    {
        this.width = width;
        this.height = height;

        grid = new int[height,width];

        for(int x = 0;x < height;x++)
        {
            for(int y = 0;y < width;y++)
            {
                
            }
        }
    }   
}
