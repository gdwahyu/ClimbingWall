using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class controllMove : MonoBehaviour
{
    Controller controller;
    float HandPalmPitch;
    float HandPalmYam;
    float HandPalmRoll;
    float HandWristRot;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controller = new Controller();
        Frame frame = controller.Frame();
        List<Hand> hands = frame.Hands;
        if ( frame.Hands.Count > 0)
        {
            Hand fristHand = hands[0];
        }
        HandPalmPitch = hands[0].PalmNormal.Pitch;
        HandPalmPitch = hands[0].PalmNormal.Roll;
        HandPalmPitch = hands[0].PalmNormal.Yaw;

        HandWristRot = hands[0].WristPosition.Pitch;

        Debug.Log("Pitch :" + HandPalmPitch);
        Debug.Log("Roll :" + HandPalmRoll);
        Debug.Log("Yam :" + HandPalmYam);

        //move object
        if (HandPalmYam > -2f && HandPalmYam <3.5f)
        {
            transform.Translate ( new Vector3(0, 0, 1 * Time.deltaTime));
        }
        else if (HandPalmYam < -2.2f)
        {
            transform.Translate ( new Vector3(0, 0, -1 * Time.deltaTime));
        }
    }
}
