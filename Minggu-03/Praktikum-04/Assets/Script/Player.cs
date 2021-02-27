using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Text ballText;
    private int totalBall = 0;
    void Start()
    {
        UpdateBallText();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("DragonBall"))
        {
            totalBall++;
            UpdateBallText();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateBallText()
    {
        string dragonBallMessage = "DragonBall = " + totalBall;
        ballText.text = dragonBallMessage;
    }
}