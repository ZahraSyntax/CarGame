using UnityEngine;

public class CollectFuel : MonoBehaviour
{
    [SerializeField] private AudioSource collisionSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collisionSound != null)
            {
                AudioSource.PlayClipAtPoint(collisionSound.clip, transform.position);
            }
            FuelController.Instance.FillFuel(gameObject.tag);
            Destroy(gameObject);
        }
    }
}
