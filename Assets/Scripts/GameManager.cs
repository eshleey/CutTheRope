using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Ball[] Ball;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D Hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (Hit.collider != null)
            {
                if (Hit.collider.CompareTag("Center 1"))
                {
                    ChainTechnicalProcess(Hit, "Center 1", 0);
                }
                else if (Hit.collider.CompareTag("Center 2"))
                {
                    ChainTechnicalProcess(Hit, "Center 2", 0);
                }
                else if (Hit.collider.CompareTag("Center 3"))
                {
                    ChainTechnicalProcess(Hit, "Center 3", 1);
                }
                else if (Hit.collider.CompareTag("Center 4"))
                {
                    ChainTechnicalProcess(Hit, "Center 4", 1);
                }
            }
        }
    }

    void ChainTechnicalProcess(RaycastHit2D Hit, string HingeName, int BallCount)
    {
        Hit.collider.gameObject.SetActive(false);
        Ball[BallCount].HingeControl[HingeName].enabled = false;
    }
}
