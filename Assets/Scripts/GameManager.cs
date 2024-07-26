using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball[] Ball;
    [SerializeField] private int BallCount;
    [SerializeField] private int TargetObjectCount;

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
                    ChainTechnicalProcess(Hit, "Center 2", 1);
                }
                /*else if (Hit.collider.CompareTag("Center 3"))
                {
                    ChainTechnicalProcess(Hit, "Center 3", 2);
                }
                else if (Hit.collider.CompareTag("Center 4"))
                {
                    ChainTechnicalProcess(Hit, "Center 4", 3);
                }*/
            }
        }
    }

    void ChainTechnicalProcess(RaycastHit2D Hit, string HingeName, int BallCount)
    {
        Hit.collider.gameObject.SetActive(false);
        Ball[BallCount].HingeControl[HingeName].enabled = false;
    }

    public void BallFell()
    {
        BallCount--;
        if (BallCount == 0)
        {
            if (TargetObjectCount == 0)
            {
                Debug.Log("KAZANDIN");
            }
            else if (TargetObjectCount > 0)
            {
                Debug.Log("KAYBETTÝN");
            }
        }
        else
        {
            if (TargetObjectCount == 0)
            {
                Debug.Log("KAZANDIN");
            }
        }
    }

    public void TargetObjectFell()
    {
        TargetObjectCount--;
        if (BallCount == 0 && TargetObjectCount == 0)
        {
            Debug.Log("KAZANDIN");
        }
        else if (BallCount == 0 && TargetObjectCount > 0)
        {
            Debug.Log("KAYBETTÝN");
        }
    }
}
