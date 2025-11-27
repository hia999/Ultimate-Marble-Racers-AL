using UnityEngine;

public class KeepRotating : MonoBehaviour
{

    public int speed;

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }

}
