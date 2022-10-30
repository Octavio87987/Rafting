using UnityEngine;

public class WaterFloat : MonoBehaviour
{
    public Vector3 MovingDistances = new Vector3(0.002f, 0.001f, 0f);
    public float speed = 1f;

    public Vector3 WaveRotations;
    public float WaveRotationsSpeed = 0.3f;

    public Vector3 AxisOffsetSpeed;

    Transform actualPos;



    void Start()
    {
        actualPos = transform;
    }


    void Update()
    {

        Vector3 mov = new Vector3(
            actualPos.position.x + Mathf.Sin(speed * Time.time) * MovingDistances.x,
            actualPos.position.y + Mathf.Sin(speed * Time.time) * MovingDistances.y,
            actualPos.position.z + Mathf.Sin(speed * Time.time) * MovingDistances.z
        );


        transform.rotation = Quaternion.Euler(
            actualPos.rotation.x + WaveRotations.x * Mathf.Sin(Time.time * WaveRotationsSpeed),
            actualPos.rotation.y + WaveRotations.y * Mathf.Sin(Time.time * WaveRotationsSpeed),
            actualPos.rotation.z + WaveRotations.z * Mathf.Sin(Time.time * WaveRotationsSpeed)
        );


        transform.position = mov;


        var tran = transform.position;

        tran.x += AxisOffsetSpeed.x * Time.deltaTime;
        tran.y += AxisOffsetSpeed.y * Time.deltaTime;
        tran.z += AxisOffsetSpeed.z * Time.deltaTime;

        transform.position = tran;
    }
}