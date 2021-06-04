using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Kinect = Windows.Kinect;
using Proyecto26;
using TMPro;
//positive grad goes left, negative grad goes right
//above 0.6 goes to left
//between -0.6 and 0.6 stay in middle lane
//below -0.6 right lane
public class PlayerController : MonoBehaviour
{
    public double length;

    public double gradient;
    double stretch;
    public double sensitivity;
    double NegStretch;
    // private static BodySourceView gradient = new BodySourceView();
    // public double grad = gradient.grad();
    public float runspeed;

    public Transform start;
    public Transform left;
    public Transform right;
    public Transform middle;
    public float speed;

    public static int count;

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

    //database
    private int cubeNum;
    User user;
    //public static string Playeremail;
    public TMP_InputField PlayerName;
    public static string playername;
        

    // Start is called before the first frame update
    void Start()
    {

        count = 0;
        second = 0;
        minute = 0;
        cubeNum = 0;
        SetCountText();
        winText.text = "";
        Score.text = "";
        Timer.text = "00:00";
        back.SetActive(false);


        music = this.GetComponent<AudioSource>();
        music.clip = collect;
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

        gradient = BodySourceView.Gradient;
        length = BodySourceView.Length;
        stretch = Menu_Start.Stretch;
        sensitivity = Menu_Start.Sensitivity;
        NegStretch = 0 - stretch;

        //Playeremail = AuthManager.Emailtext;
        //Debug.Log(stretch);
        //Debug.Log(sensitivity);
        //Debug.Log(cubeNum);

        if (second ==20)
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



    //Apply force to make the ball contineously moving, speed can be changed by the public vatriable speed
    void FixedUpdate()
    {


        transform.position += Vector3.forward * runspeed;
        //Debug.Log(gradient);

        if (gradient > 0.2)
        {
            transform.position = Vector3.MoveTowards(start.position, left.position, speed * Time.deltaTime);
            //Debug.Log("left");
        }
        if (gradient < stretch && gradient > NegStretch )
        {
            transform.position = Vector3.MoveTowards(start.position, middle.position, speed * Time.deltaTime);
            //Debug.Log("middle");
        }
        if (gradient < NegStretch )
        {
            transform.position = Vector3.MoveTowards(start.position, right.position, speed * Time.deltaTime);
            //Debug.Log("right");

            //apply force to keep the ball moving
        }
    }

    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Easy Pick"))
        {
            other.transform.position += Vector3.forward * 400;
            music.Play();
            count = count + 1;
            cubeNum = cubeNum + 1;
            //Debug.Log("collect");
        }
        
        //if (Input.GetKey("a") ) //length > sensitivity
       // {
            if (other.gameObject.CompareTag("Pick up")&& Input.GetKey("a"))
            {
                other.transform.position += Vector3.forward * 400;
                music.Play();
                count = count + 1;
                cubeNum = cubeNum + 1;
            }
            if (other.gameObject.CompareTag("Double")&& Input.GetKey("a"))
            {
                other.transform.position += Vector3.forward * 400;
                music.Play();
                count = count + 2;
                cubeNum = cubeNum + 1;
            }
            
       // }
        SetCountText();
        
    }

    //the functing used to change the count number shown on the screen
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

    }

    private void PostToDatabase()
    {
        //Debug.Log("email1: "+Playeremail);
        User user = new User();
        //Debug.Log("email2: " + Playeremail);
        RestClient.Put("https://physio-game-default-rtdb.firebaseio.com/" + playername + ".json", user);
    }

    public void OnSubmit()
    {
        playername = PlayerName.text;
        PostToDatabase();
    }
    /*
        private void RetrieveFromDatabase()
        {
            RestClient.Get<User>("https://project-id.firebaseio.com/" + nameText.text + ".json").Then(response =>
            {
                user = response;
                UpdateScore();
            });
        }
    */
}
