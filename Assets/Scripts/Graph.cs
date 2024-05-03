using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab;

    [SerializeField, Range(1, 100)]
    int resolution = 10;

    void Awake()
    {
        Transform point;
        float step = 2f / resolution;
        Vector3 scale = Vector3.one * step;
        Vector3 position = Vector3.zero;
        for (int i = 0; i < resolution; i++)
        {
            point = Instantiate(pointPrefab);
            point.SetParent(transform, false);

            position.x = (i + 0.5f) * step - 1f;
            position.y = position.x * position.x;
            point.localPosition = position;
            point.localScale = scale;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
