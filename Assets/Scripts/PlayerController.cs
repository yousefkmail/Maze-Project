using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float speed = 1;

    [SerializeField] GameObject followCamera;
    public void FixedUpdate()
    {
        // Make the camera follow the player.
        // we keep the height of the camera the same, but we change its position on the X-axis and Z-axis
        // to match the player.
        {

            followCamera.transform.position = new Vector3(transform.position.x, followCamera.transform.position.y, transform.position.z);
        }


        // this will get the if the player pressed the WASD keys or the Arrow keys.
        Vector2 movDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));



        //If the player didn't press any key then we don't do anything.
        if (movDir.magnitude < 0.1f) return;



        //this is the angle that the player is looking at based on the keys pressed
        // for example if key W was pressed, the player should look forward.
        float playerYAngle = math.degrees(math.atan2(movDir.x, movDir.y));

        //here we apply the angle to the player.
        transform.rotation = Quaternion.Euler(0, playerYAngle, 0);

        //here we move the player in the direction its looking at.
        transform.position += speed * Time.fixedDeltaTime * transform.forward;

    }

}
