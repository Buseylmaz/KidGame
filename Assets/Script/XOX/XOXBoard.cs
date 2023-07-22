using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XOXBoard
{
    public XOXGameManager.Side[,] squers;

    public XOXBoard()
    {
        squers=new XOXGameManager.Side[3,3];

        int i, j;

        for (i = 0; i < 3; i++)
        {
            for(j = 0; j < 3; j++)
            {
                squers[i, j] = XOXGameManager.Side.Empty;
            }

        }

    }

    public void Execute(int x,int y,XOXGameManager.Side side)
    {
        squers[x, y] = side;
    }

    public bool IsThereEmptyBox()
    {
        int i, j;

        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                if (squers[i, j]==XOXGameManager.Side.Empty) 
                {
                    return true;
                }
            }

        }
        return false;   
    }

    public bool DidSideWinGame(XOXGameManager.Side currentSide)
    {
        for(int i = 0; i< 3;i++) 
        {
            if (squers[1, i] == squers[0,i] && squers[1, i] == squers[2, i])
            {
                if (squers[2, i] == currentSide)
                {
                    return true;
                }
            }
        }

        for (int i = 0; i < 3; i++)
        {
            if (squers[i,1] == squers[i, 0] && squers[i, 1] == squers[i, 2])
            {
                if (squers[i, 2] == currentSide)
                {
                    return true;
                }
            }
        }

        if (squers[1, 1] == squers[0, 0] && squers[1, 1] == squers[2, 2])
        {
            if (squers[1,1] == currentSide)
            {
                return true;
            }
        }

        if (squers[1, 1] == squers[2, 0] && squers[1, 1] == squers[0, 2])
        {
            if (squers[1, 1] == currentSide)
            {
                return true;
            }
        }



        return false;
    }
}

