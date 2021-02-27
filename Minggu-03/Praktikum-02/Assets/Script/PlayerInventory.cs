using UnityEngine;
using System.Collections;
public class PlayerInventory : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;
    private bool carryingDragonBall = false;
    void Start()
    {
        playerInventoryDisplay = GetComponent<
        PlayerInventoryDisplay>();
        playerInventoryDisplay.OnChangeCarryingDragonBall(carryingDragonBall);
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("DragonBall"))
        {
            carryingDragonBall = true;

            playerInventoryDisplay.OnChangeCarryingDragonBall(carryingDragonBall);
            Destroy(hit.gameObject);
        }
    }
}
