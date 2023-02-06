using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour

{

    public int score = 0;
    public TextMeshProUGUI scoreboard;
    public Snowball[] snowballs;

    public int fail;

    public AudioClip shotSound;
    public AudioSource shotAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        LadeMagazin();
        fail = 5;
        shotAudioSource = GetComponent<AudioSource>();
    }

    public Snowball GibKugel()
    {
        

        for (int i = 0; i < snowballs.Length; i++)
        {


            if (!snowballs[i].IsActiv())
            {
                Debug.Log("Gib Kugel " + snowballs[i].name);
                snowballs[i].gameObject.SetActive(true);
                return snowballs[i];


            }

        }
        return null;
    }

    public void Snowballshot()
    {
        Snowball tmp = GibKugel();
        tmp.SetSpawnPos();

        tmp.SetSnowballActive();
        //shotAudioSource.PlayOneShot(shotSound);


    }

    // Update is called once per frame
    void Update()
    {
        scoreboard.text = "Score: " + score + " Leben: " + fail;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Snowball tmp = GibKugel();
            tmp.SetSpawnPos();

            tmp.SetSnowballActive();
            Debug.Log("nach setActive " + tmp.name + tmp.gameObject.activeSelf);
        }

        if (fail < 1)
        {
            // Debug.Log("Der Spieler hat verloren");
            scoreboard.text = "GAME OVER Score: " + score;
        }
    }



    public void LadeMagazin()
    {
        for (int i = 0; i < snowballs.Length; i++)
        {
            snowballs[i].gameObject.SetActive(false);
            Debug.Log(snowballs[i].IsActiv() + snowballs[i].name);
        }
    }

    public void EntladeMagazin()
    {
        for (int i = 0; i < snowballs.Length; i++)
        {
            snowballs[i].gameObject.SetActive(true);
            Debug.Log(snowballs[i].IsActiv() + snowballs[i].name);
        }
    }

    

}



    //To Do
    //Arrays, While und If müssen eingebaut werden
    //Kanone muss immer wo anders hin schießen - done
    //Score muss hochzählen, wenn der Player von einem Schneeball getroffen wird
    //Spiel muss stopen, wenn der Player einen Schneeball nicht abblockt

