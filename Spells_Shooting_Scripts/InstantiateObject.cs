using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject instObj;

    public void InstantiateObj()
    {
        Instantiate(instObj, transform.position, transform.rotation);
    }
}
