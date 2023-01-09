using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapaGrandeController : MonoBehaviour {

    public float moveX;
    public float milimetersPerSecondY = 0.01f;
    public float moveY;
    public float moveZ;
    public float degreesPerSecondX = 2.0f;
    public float rotateX;
    public CharacterController tapaGrande;

    public float timer = 0;


    // Start is called before the first frame update
    void Start () {
        tapaGrande = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        // Final Position in Y 37, Initial Position in Y -0.2, Dif = 37.2
        // moveY += Time.deltaTime * 0.0002f;
        // Final Angle in X -214.96, Initial Angle in Y -94.51, Dif = -120.45
        // rotateX = Time.deltaTime * 20;

        tapaGrande.Move(new Vector3(moveX, moveY, -moveZ));
        tapaGrande.transform.Rotate(-rotateX, 0, 0);
    }
}
