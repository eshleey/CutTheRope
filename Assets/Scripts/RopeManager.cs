using UnityEngine;

public class RopeManager : MonoBehaviour
{
    public Rigidbody2D FirstHook;
    public Ball Ball;
    public int ConnectionCount = 5;
    public GameObject ConnectionPrefab;

    void Start()
    {
        CreateRope();
    }

    void CreateRope()
    {
        Rigidbody2D PreviousConnection = FirstHook;

        for (int i = 0; i < ConnectionCount; i++)
        {
            GameObject Connection = Instantiate(ConnectionPrefab, transform);
            HingeJoint2D Joint = Connection.GetComponent<HingeJoint2D>();
            Joint.connectedBody = PreviousConnection;

            if (i < ConnectionCount - 1)
            {
                PreviousConnection = Connection.GetComponent<Rigidbody2D>();
            }
            else
            {
                Ball.TieLastChain(Connection.GetComponent<Rigidbody2D>());
            }
        }
    }
}
