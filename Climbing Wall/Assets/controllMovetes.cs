using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class controllMovetes : MonoBehaviour
{
    Controller controller;
    float HandPalmPitch1;
    float HandPalmYam1;
    float HandPalmRoll1;
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
        if (frame.Hands.Count > 0)
        {
            Hand fristHand = hands[0];
        }
        HandPalmPitch1 = hands[0].PalmNormal.Pitch;
        HandPalmPitch1 = hands[0].PalmNormal.Roll;
        HandPalmPitch1 = hands[0].PalmNormal.Yaw;

        HandWristRot = hands[0].WristPosition.Pitch;

        Debug.Log("Pitch :" + HandPalmPitch1);
        Debug.Log("Roll :" + HandPalmRoll1);
        Debug.Log("Yam :" + HandPalmYam1);

        //move object

        //if (HandPalmYam1 > -2f && HandPalmYam1 < 3.5f)
        //{
        //    transform.Translate(new Vector3(0, 0, 1 * Time.deltaTime));
        //}
        //else if (HandPalmYam1 < -2.2f)
        //{
        //    transform.Translate(new Vector3(0, 0, -1 * Time.deltaTime));
        //}

        //tes move up(udah mau maju mundur)
        if (HandPalmPitch1 > -2f && HandPalmPitch1 < 3.5f)
        {
            transform.Translate(new Vector3(0, 1, 0 * Time.deltaTime));
        }
        else if (HandPalmPitch1 < -2.2f)
        {
            transform.Translate(new Vector3(0, -1, 0 * Time.deltaTime));
        }
    }
}
