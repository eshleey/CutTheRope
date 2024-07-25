using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float DistanceWithChain = 0.2f;
    public Dictionary<string, HingeJoint2D> HingeControl = new Dictionary<string, HingeJoint2D>();
    public void TieLastChain(Rigidbody2D LastChain, string HingeName)
    {
        HingeJoint2D Joint = gameObject.AddComponent<HingeJoint2D>();
        HingeControl.Add(HingeName, Joint);
        Joint.autoConfigureConnectedAnchor = false;
        Joint.connectedBody = LastChain;
        Joint.anchor = Vector2.zero;
        Joint.connectedAnchor = new Vector2(0f, -DistanceWithChain);
    }
}
