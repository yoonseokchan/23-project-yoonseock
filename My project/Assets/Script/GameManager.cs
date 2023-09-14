using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : GenericSingleton<GameManager>
{
    public int PlayerScore = 0;

    public void IncreaseScore(int amount)
    {
        PlayerScore += amount;
    }
}
