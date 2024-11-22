using UnityEngine;

public class CollectFuel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (CompareTag("Coin"))
            {
                if (_audioSource != null)
                {
                    _audioSource.Play();
                }

                Destroy(gameObject, _audioSource.clip.length);
            }
            else
            {
                switch (gameObject.tag)
                {
                    case "RedFuel":
                        FuelController.instance.AddFuelPercentage(10f);
                        break;
                    case "BlueFuel":
                        FuelController.instance.AddFuelPercentage(30f);
                        break;
                    case "GoldFuel":
                        FuelController.instance.FillFuel();
                        break;
                }
                Destroy(gameObject);
            }
        }
    }

}
