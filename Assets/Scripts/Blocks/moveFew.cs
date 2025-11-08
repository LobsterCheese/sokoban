using UnityEngine;

public class moveFew : Block
{
    int moveCount = 6;

    public void BlockMoved()
    {
        moveCount -= 1;

        if (moveCount <= 0)
        {
            Destroy(gameObject);
        }
    }
}