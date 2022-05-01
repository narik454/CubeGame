using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;
    private Transform _rotator;

    void Start()
    {
        _rotator = GetComponent<Transform>();
    }

    void Update()
    {
        _rotator.Rotate(0, speed * Time.deltaTime, 0);
    }
}
