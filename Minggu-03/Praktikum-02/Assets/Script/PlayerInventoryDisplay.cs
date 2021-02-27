using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Text dragonBallText;
    public void OnChangeCarryingDragonBall(bool carryingDragonBall)
    {
        string DragonBallMessage = "Tidak Bawa Dragon Ball (҂ `з´ )";
        if (carryingDragonBall) DragonBallMessage = "Bawa Dragon Ball (๑˃ᴗ˂)ﻭ";
        dragonBallText.text = DragonBallMessage;
    }
}