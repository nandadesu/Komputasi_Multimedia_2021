using System.Collections;
using UnityEngine.UI;
using UnityEngine;
public class Player : MonoBehaviour
{
    public Image ballImage;
    public Sprite iconBall;
    public Sprite iconNoBall;
    private bool carryingDragonBall = false;
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("DragonBall"))
        {
            carryingDragonBall = true;
            UpdateballImage();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateballImage()
    {
        if (carryingDragonBall)
            ballImage.sprite = iconBall;
        else
            ballImage.sprite = iconNoBall;
    }
}