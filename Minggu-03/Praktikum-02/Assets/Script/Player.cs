using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Text dragonBallText;
    private bool carryingDragonBall = false;
    void Start()
    {
        UpdateDragonBallText();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("DragonBall"))
        {
            carryingDragonBall = true;
            UpdateDragonBallText();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateDragonBallText()
    {
        string DragonBallMessage = "Tidak Bawa Dragon Ball (҂ `з´ )";
        if (carryingDragonBall) DragonBallMessage = "Bawa Dragon Ball (๑˃ᴗ˂)ﻭ";
        dragonBallText.text = DragonBallMessage;
    }
}
