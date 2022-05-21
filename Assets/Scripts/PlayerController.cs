using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public RectTransform uicanvas;
    public CharacterController playercharacter;
    public Transform playerrotation;
    public float gravityconstant;
    public float speed;
    public float rotationspeed = 25;
    
    float rotationvector;
    Vector3 gravitation;
    Vector3 zerostep = new Vector3(0,0,0);
    Vector3 forwardstep = new Vector3(0,0,1);
    Vector3 backstep = new Vector3(0,0,-1);
    Vector3 leftstep = new Vector3(-1,0,0);
    Vector3 rightstep = new Vector3(1,0,0);
    Vector3 movementvector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        CalculateGravity();
    }
    private void FixedUpdate() {
        
        playercharacter.Move(transform.TransformDirection(movementvector) * speed + gravitation * Time.deltaTime);
        playerrotation.eulerAngles += new Vector3(0,rotationvector * Time.deltaTime,0);
        uicanvas.eulerAngles = new Vector3(90,0,playerrotation.rotation.y);
            
    }
    public void stepforward()
    {
        movementvector = forwardstep;
    }
    public void stepleft(){
        movementvector = leftstep;
    }
    public void stepbackward(){
        movementvector = backstep;
    }
    public void stepright(){
        movementvector = rightstep;
    }  
    public void dropmovement(){ 
        movementvector = zerostep;
    }
    public void rotateleft(){
        rotationvector = rotationspeed * -1;
    }
    public void rotateright(){
        rotationvector = rotationspeed;
    }
    
    public void droprotation(){ 
        rotationvector = 0;
    }
    public void CalculateGravity(){
        if (playercharacter.isGrounded == true){
            gravitation = Vector3.zero;
        }
        if (playercharacter.isGrounded != true){
            gravitation = Vector3.down * gravityconstant;
        }

    }
}
