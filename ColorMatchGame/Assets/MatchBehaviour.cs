using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public JulianID idObj;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(idObj);
    }
}
