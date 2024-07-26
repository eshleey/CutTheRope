using UnityEngine;

public class HarbingerOfFalling : MonoBehaviour
{
    [SerializeField] private GameManager GameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Target Object"))
        {
            GameManager.TargetObjectFell();
        }

        if (collision.gameObject.CompareTag("Ball"))
        {
            GameManager.BallFell();
        }
    }
}
