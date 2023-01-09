using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveroA : MonoBehaviour {
    public float moveY;
    public float moveZ;
    public float rotateX;
    public CharacterController llaveroA;

    // Start is called before the first frame update
    void Start() {
        llaveroA = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update() {
        moveY = Time.deltaTime * 10;
        moveZ = Time.deltaTime * 10;
        rotateX = Time.deltaTime * 20;
        
        if (transform.position[1] < 15) {
            llaveroA.Move(new Vector3(0, moveY, 0));
        } else if (transform.rotation.eulerAngles.x >= 270 & transform.position[1] < 35) {
            llaveroA.transform.Rotate(-rotateX, 0, 0);
            llaveroA.Move(new Vector3(0, moveY, - Time.deltaTime));
        } else if (transform.rotation.eulerAngles.x >= 270 & transform.position[1] > 25) {
            llaveroA.transform.Rotate(-rotateX, 0, 0);
            llaveroA.Move(new Vector3(0, Time.deltaTime * 6, -moveZ));
        }
    }
}
