using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStack : MonoBehaviour
{
    public List<GameObject> blockList = new List<GameObject>();

    private GameObject LastBlockObject;

    // Start is called before the first frame update
    void Start()
    {
        updateLastBlockObject();
    }

    public void IncreaseBlockStack(GameObject gameObject)
    {
        transform.position = new Vector3 (transform.position.x,transform.position.y + 2f,transform.position.z);
        gameObject.transform.position = new Vector3(LastBlockObject.transform.position.x,LastBlockObject.transform.position.y - 2f,LastBlockObject.transform.position.z);
        gameObject.transform.SetParent(transform);
        blockList.Add(gameObject);
        updateLastBlockObject();
    }

    public void DecreaseBlock(GameObject gameObject)
    {
        gameObject.transform.parent = null;
        blockList.Remove(gameObject);
        updateLastBlockObject();
    }


    private void updateLastBlockObject()
    {
        LastBlockObject = blockList[blockList.Count - 1];
    }
}
