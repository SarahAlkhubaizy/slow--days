using UnityEngine;

public class FishFloat : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(Mathf.Sin(Time.time) * 0.001f, 0, 0);
    }
}