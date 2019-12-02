using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Follow_Mouse : MonoBehaviour {

   
    public float fl_PC_Move_Speed;

    private Rigidbody RB_PC;

    private Vector3 v3_last_mouse_position;
    private Vector3 v3_movement;
    private Vector3 v3_middle;

    // Use this for initialization
    void Start()
    {
        RB_PC = gameObject.GetComponent<Rigidbody>();
        v3_middle = new Vector3(Screen.width / 2, Screen.height / 2, 0);
    }
	
	// Update is called once per frame
	void Update () {
        
        if(v3_last_mouse_position != Input.mousePosition)
        {

            v3_last_mouse_position = Input.mousePosition;
            //stop moving
            RB_PC.velocity = Vector3.zero;
            //Turn and face the mouse
            Vector3 direction = PointToMouse(Input.mousePosition) + Vector3.right;
            //
            v3_movement = direction * fl_PC_Move_Speed;
            RB_PC.AddForce(v3_movement);
        }
	}



    Vector3 PointToMouse(Vector3 pointerPos)
    {
        // convert mouse position into world coordinates
        //Vector3 mouseScreenPosition = Camera.main.ScreenToWorldPoint(pointerPos);
        //print(mouseScreenPosition);
        //print(Input.mousePosition);
        float delta_xaxis = pointerPos.x - v3_middle.x;
        float delta_yaxis = pointerPos.y - v3_middle.y;

        if (delta_xaxis < 0)
        {
            //left
            return Vector3.forward;
        }
        if(delta_xaxis > 0)
        {
            //right
            return Vector3.back;
        }

        return Vector3.zero;       

        // get direction you want to point at
        //Vector2 direction = (mouseScreenPosition - (Vector2)transform.position).normalized; 

        // set vector of transform directly
        //transform.forward = direction;




    }


}
