using UnityEngine;

public class Ball : MonoBehaviour
{
    public float DistanceWithChain = 0.2f;
    public void TieLastChain(Rigidbody2D LastChain)
    {
        HingeJoint2D Joint = gameObject.AddComponent<HingeJoint2D>();
        Joint.autoConfigureConnectedAnchor = false;
        Joint.connectedBody = LastChain;
        Joint.anchor = Vector2.zero;
        Joint.connectedAnchor = new Vector2(0f, -DistanceWithChain);
    }
}
