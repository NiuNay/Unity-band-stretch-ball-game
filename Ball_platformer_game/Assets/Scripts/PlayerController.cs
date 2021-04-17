using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float runspeed;

    public Transform start;
    public Transform left;
    public Transform right;
    public Transform middle;
    public float speed;

    private int count;

    public Text countText;
    public Text winText;
    public Text Timer;

    public Text Score;
    public GameObject back;


    private int second;
    private int minute;
    private float time;
    private int timer1;
    private int timer2;

    //music
    public AudioClip collect;
    private AudioSource music;
    public Slider slider;


    // Start is called before the first frame update
    void Start()
    {

        count = 0;
        second = 0;
        minute = 0;
        SetCountText();
        winText.text = "";
        Score.text = "";
        Timer.text = "00:00";
        back.SetActive(false);

        music = this.GetComponent<AudioSource>();
        music.clip = collect;
    }

    //Apply force to make the ball contineously moving, speed can be changed by the public vatriable speed
    void FixedUpdate()
    {
        transform.position += Vector3.forward*runspeed;


        if (Input.GetKey("a"))
        {
            transform.position = Vector3.MoveTowards(start.position, left.position, speed * Time.deltaTime);
            //Debug.Log("left");
        }
        if (Input.GetKey("s"))
        {
            transform.position = Vector3.MoveTowards(start.position, middle.position, speed * Time.deltaTime);
            //Debug.Log("middle");
        }
        if (Input.GetKey("d"))
        {
            transform.position = Vector3.MoveTowards(start.position, right.position, speed * Time.deltaTime);
            //Debug.Log("right");

            //apply force to keep the ball moving
        }
    }


        //when input"a" the ball will move to the Left lanes, input"s" will move to the middle lanes, input "d"will move to right lanes
        //When we use kinect can just change the input, relate it to 3 movement
     void Update()
        {
        music.volume = (slider.value) * 0.1f;
        //The timer
        time += Time.deltaTime;
        if (time >= 1)
        {

            second++;
            time = time - 1;
        }

        if (second == 60)
        {
            minute++;
            second = 0;
        }
        Timer.text = "Time: " + minute.ToString() + ":" + second.ToString();


        }



    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey("z") || Input.GetKey("x")|| Input.GetKey("c"))
        {
            if (other.gameObject.CompareTag("Pick up"))
            {
                other.transform.position += Vector3.forward * 400;
                music.Play();
                count = count + 1;
            }
            if (other.gameObject.CompareTag("Double"))
            {
                other.transform.position += Vector3.forward * 400;
                music.Play();
                count = count + 2;
            }
            SetCountText();
        }

        if (minute == 2)
        {
            back.SetActive(true);
            winText.text = "Time is UP!!!";
            timer1 = minute;
            timer2 = second;
            Timer.gameObject.SetActive(false);
            Score.text = "\n\nYour Score is: " + count + "\n\nCONGRATULATION!";
            runspeed = 0;
        }
    }

    //the functing used to change the count number shown on the screen
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

    }


}
