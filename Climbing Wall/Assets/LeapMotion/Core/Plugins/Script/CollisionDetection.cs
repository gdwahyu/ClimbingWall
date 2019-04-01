using Leap.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private LeapRTS rtsleap;
    public GameObject tanganKanan;
    private bool flag = false;
    private bool flag2 = false;
    public ExtendedFingerDetector handgrab;

    // Start is called before the first frame update
    void Start()
    {
            rtsleap = gameObject.GetComponent<LeapRTS>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //saat melakukan sentuhan kepada objek akan mengaktifkan leap rts
    void OnCollisionEnter(Collision col)
    {
        if (handgrab.grab == true && tanganKanan == col.gameObject )
        {
            Debug.Log(gameObject.name + "Active");
            // rtsleap.enabled = true;
            flag = true;
            if (flag2 == false)
            {
                gameObject.AddComponent<LeapRTS>();
                flag2 = true;

            }
        }
    }
    //menonaktifkan leap rts
   private void OnCollisionExit(Collision col)
    {
        if (flag == true)
        {
             Debug.Log(gameObject.name + "Non active");
            //rtsleap.enabled = false;
            rtsleap = gameObject.GetComponent<LeapRTS>();
            Destroy(rtsleap);
            flag = false;
            flag2 = false;
        }
    }
}
