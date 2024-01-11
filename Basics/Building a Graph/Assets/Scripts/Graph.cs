using UnityEngine;

public class Graph : MonoBehaviour {
    [SerializeField]
    Transform pointPrefab;

    [SerializeField, Range(10, 100)]
    int resoution = 10;

    void Awake () {
        float step = 2f / resoution;
        var position = Vector3.zero;
        var scale = Vector3.one / 5f;
        for (int i = 0; i < resoution; i++) { 
            Transform point = Instantiate(pointPrefab);
            position.x = (i + 0.5f) * step - 1f;
            position.y = position.x * position.x;
            point.localPosition = position;
            point.localScale = scale;
            point.SetParent(transform, false);

        }
    }
}
