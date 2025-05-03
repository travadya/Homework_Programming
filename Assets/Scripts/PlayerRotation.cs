using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private Camera camera;

    private string CameraName = "Game_Camera";

    private Vector3 positionmouse;

    private void Start()
    {
        camera = GameObject.Find(CameraName).GetComponent<Camera>();
    }

    private void Update()
    {
        positionmouse = camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 pos = positionmouse - transform.position;

        float rotZ = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ - 99);
    }
}
