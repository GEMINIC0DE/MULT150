using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        Vector3 placement = new Vector3(-20, 0, -10);
        for(int count = 1; count <= 10; count++)
        {

            Instantiate(prefab, placement, transform.rotation);
            placement = placement + new Vector3(4, 0, 0);
            //transform.Translate(-20f, 0f, -10f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Whenever we hit the B key we will generate a prefab at the
        //position of the original prefab
        //Whenever we hit the space key, we will generate a prefab at the
        //position of the spawn object that the script is attached to
        if(Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
