using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float timer=0;
    public int totalT=0;
    public Text txt;
    public Text txt2;
    public Text txt3;
    private bool win = false;
  static  public bool lose = false;
    private GameObject[] targets;
    private bool recorded = false;
  static  private float[] history = new float[4];
    // Start is called before the first frame update
    //void Awake()
    //{
    //    lose = false;
    //}
    void Start()
    {
        lose = false;
        targets = GameObject.FindGameObjectsWithTag("target");
        txt3.text = history[0] + "\n"+ history[1] + "\n"+ history[2] + "\n"+ history[3] + "\n";
    }

    // Update is called once per frame
    void Update()
    {
        print(lose);
        if (Input.GetKey(KeyCode.R)||lose==true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        for (int i=0; i < targets.Length; i++)
        {
            if (i == 0)
            {
                totalT = 0;
            }
            if (targets[i].GetComponent<collsionTrigger>().hit == true)
            {
                totalT += 1;
            }
            if (totalT == targets.Length)
            {
                win = true;
            }

        }
        if (win == false)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if (recorded == false)
            {
                record();
                recorded = true;
            }
            txt2.enabled = true;
        }

        txt.text = ""+timer.ToString("F2");

    }
    private void record()
    {
        for (int i = 0; i < history.Length; i++)
        {
            if (history[i] > timer || history[i] == 0.00f)
            {
                txt3.text = history[0] + "\n" + history[1] + "\n" + history[2] + "\n" + history[3] + "\n";
                history[i] = timer;
                return;
            }
        }
    }
}
