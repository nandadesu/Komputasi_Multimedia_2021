using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] starPlaceholders;
    public Sprite iconDiamondsYellow;
    public Sprite iconDiamondsGrey;
    public void OnChangeStarTotal(int starTotal)
    {
        for (int i = 0; i < starPlaceholders.Length; ++i)
        {
            if (i < starTotal)
                starPlaceholders[i].sprite = iconDiamondsYellow;
            else
                starPlaceholders[i].sprite = iconDiamondsGrey;
        }
    }
}