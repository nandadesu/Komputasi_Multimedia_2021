using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] dragonBallPlaceholders;
    public Sprite iconDragonBallColour;
    public Sprite iconDragonBallGrey;
    public void OnChangeDragonBallTotal(int DragonBallTotal)
    {
        for (int i = 0; i < dragonBallPlaceholders.Length; ++i)
        {
            if (i < DragonBallTotal)
                dragonBallPlaceholders[i].sprite = iconDragonBallColour;
            else
                dragonBallPlaceholders[i].sprite = iconDragonBallGrey;
        }
    }
}