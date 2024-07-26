using UnityEngine;

public class RopeManager : MonoBehaviour
{
    [SerializeField] private Rigidbody2D FirstHook;
    [SerializeField] private Ball Ball;
    [SerializeField] private int ConnectionCount = 5;
    [SerializeField] private GameObject[] ConnectionPool;
    [SerializeField] private string HingeName;

    void Start()
    {
        CreateRope();
    }

    void CreateRope()
    {
        Rigidbody2D PreviousConnection = FirstHook;

        for (int i = 0; i < ConnectionCount; i++)
        {
            ConnectionPool[i].SetActive(true);
            HingeJoint2D Joint = ConnectionPool[i].GetComponent<HingeJoint2D>();
            Joint.connectedBody = PreviousConnection;

            if (i < ConnectionCount - 1)
            {
                PreviousConnection = ConnectionPool[i].GetComponent<Rigidbody2D>();
            }
            else
            {
                Ball.TieLastChain(ConnectionPool[i].GetComponent<Rigidbody2D>(), HingeName);
            }
        }
    }
}
