using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
   [SerializeField]private GameObject wheel;
   [SerializeField]private Arrow arrow;
   [SerializeField]private Bank bank;
   [SerializeField]
   private float speedRotationAround;
   [SerializeField]
   private float timeRotating;
   private float time = 0;
   private bool canRotate;
    void Start()
    {
        time = timeRotating;
    }

    // Update is called once per frame
    void Update()
    {
        if (!canRotate)
        {
            return;
        }
        else
        {
            if (time >0)
            {
                time-=Time.deltaTime; 
                Rotating();
            }
            else
            {
                arrow.SetTrigger();
                Invoke("GetResultArrow", 0.4f);
                canRotate= false;
            }
        }
    }

    void GetResultArrow()
    {
      bank.AddToBank(arrow.GetResult());
    }
    public void RotateWheel()
    {
      canRotate= true;
      time = timeRotating;

    }

    void Rotating()
    {
        wheel.transform.Rotate(Vector3.forward, 360f* Time.deltaTime* speedRotationAround);
    }
}
