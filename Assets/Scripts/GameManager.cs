using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball Ball;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D Hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (Hit.collider != null)
            {
                if (Hit.collider.CompareTag("Center 1"))
                {
                    Hit.collider.gameObject.SetActive(false);
                    Ball.HingeControl["Center 1"].enabled = false;
                }
                else if (Hit.collider.CompareTag("Center 2"))
                {
                    Hit.collider.gameObject.SetActive(false);
                    Ball.HingeControl["Center 2"].enabled = false;
                }
            }
        }
    }
}
