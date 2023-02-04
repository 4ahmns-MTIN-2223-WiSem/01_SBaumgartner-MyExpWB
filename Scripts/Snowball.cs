using UnityEngine;

public class Snowball : MonoBehaviour
{

    public Transform spawnPos;
    Rigidbody rbClone;
    private Vector3 snowballForce;

    private Manager manager;

    

    // Start is called before the first frame update
    void Start()
    {
        rbClone = gameObject.GetComponent<Rigidbody>();
        manager = FindObjectOfType<Manager>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("collision with object");
            manager.score++;
        }

        if (collision.gameObject.tag != "Player")
        {
            manager.fail--;
        }

    }

    public bool IsActiv()
    {
        return gameObject.activeSelf;
    }

    public void SetSnowballActive()
    {
        gameObject.SetActive(true);
    }

    public void SetSpawnPos()
    {
        //Debug.Log(rbClone.gameObject.name + ":" + rbClone.gameObject.activeSelf);
        gameObject.transform.position = spawnPos.position;
        snowballForce.x = Random.Range(500, 600);
        snowballForce.y = Random.Range(80, 150);
        snowballForce.z = Random.Range(-200, 200);
        //rbClone.AddForce(snowballForce);

        if (rbClone != null)
        {
            rbClone.AddForce(snowballForce);
        }

        else
        {
            rbClone = gameObject.AddComponent<Rigidbody>();
            rbClone.AddForce(snowballForce);
        }

    }

    public void Update()
    {
        
    }
}
