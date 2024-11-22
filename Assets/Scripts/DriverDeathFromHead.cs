using UnityEngine;

public class DriverDeathFromHead : MonoBehaviour
{
    private void onCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.compareTag("Ground"))
        {
            GameManager.instance.GameOver();
        }
    }
}
