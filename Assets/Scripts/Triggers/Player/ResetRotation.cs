using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRotation : MonoBehaviour {
    public RectTransform uicanvas;
    public int timer_count = 3;
    public bool pointerstatus;
    public Transform playerrotation;
    public void action(){
        playerrotation.rotation = Quaternion.Euler(0,0,0);
        uicanvas.rotation = Quaternion.Euler(90,0,0);
    }
    public void onenter(){
        pointerstatus = true;
    }
    public void onexit(){
        pointerstatus = false;
        timer_count = 3;
    }
    private void FixedUpdate() {
        if (pointerstatus){
            timer_count = timer_count -1;
        }
        if (timer_count <= 0){
            gameplay();
        }
    }  
   
}

