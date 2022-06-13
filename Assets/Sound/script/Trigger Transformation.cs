using UnityEngine;
using System.Collections;

public class Trigger_Transformation : MonoBehaviour
{
    private Transform ouside_door_bottom1;
    private Transform inside_door1;
    public GameObject ouside_door_bottom = null;
    public GameObject inside_door = null;

    bool trigger = false;
    void Awake()
    {
        // Setting up the references.
        ouside_door_bottom1 = ouside_door_bottom.transform;
        inside_door1 = inside_door.transform;
    }
    void OnTriggerEnter(Collider collider)
    {
            trigger = true;
            //vp_MovingPlatform platform1 = inside_door.GetComponentInChildren<vp_MovingPlatform>();
            //platform1.SendMessage("GoTo", platform1.TargetedWaypoint == 0 ? 1 : 0, SendMessageOptions.DontRequireReceiver);
    }

    public void LateUpdate()
    {
        if (trigger)
        {
            inside_door1.position = new Vector3(inside_door1.position.x, inside_door1.position.y, ouside_door_bottom1.position.z);
        }

    }

}


