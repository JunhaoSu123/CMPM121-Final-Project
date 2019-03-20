using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public Interactable focus;
    PlayerMotor motor;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                motor.MoveToPoint(hit.point);//move player to what he hits
                RemoveFocus();//stop focusing any objects
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if(interactable != null)
                {
                    SetFocus(interactable);

                }
            }
        }
    }
    void SetFocus (Interactable Newfocus)
    {
        if (Newfocus != focus)
        {
            if (focus != null)
                focus.OnDefocused();


            focus = Newfocus;
            motor.FollowTarget(Newfocus);
        }
        Newfocus.OnFocused(transform);
    }
    void RemoveFocus()
    {
        if (focus != null)
            focus.OnDefocused();
        focus = null;
        motor.StopFollowingTarget();
    }
}
