using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D Hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (Hit.collider != null)
            {
                if (Hit.collider.CompareTag("Center 1"))
                {
                    Destroy(Hit.collider.gameObject);
                }
                else if (Hit.collider.CompareTag("Center 2"))
                {
                    Destroy(Hit.collider.gameObject);
                }
            }
        }
    }
}
