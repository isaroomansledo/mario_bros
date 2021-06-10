using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelUp : MonoBehaviour
{  //variables
    public int level; //current level the player is on
    private float coinAmountRequired;
    public string scenename;
    public int buildIndex;
    //for level up I want the player to hit the barnacle and for coin Amount to reach a certain value
    //Methods: Void Start and void Update are independent of each other
    // Start is called before the first frame update
    void Start()
    {
        coinAmountRequired = 3;
    }
    // Update is called once per frame
    //function for level up
    public void LoadNextLevel()
    {

        int scene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
    void RankUp()
    {
        LoadNextLevel();
        ScoreTextScript.coinAmount = 0;
        coinAmountRequired += 5;
    }
    //function to check if you have what is required for next level
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Flag")
        {
            Debug.Log("We have hit the flag trigger");
            if ( ScoreTextScript.coinAmount >= coinAmountRequired)
            {
                RankUp(); // Function that will load next level
            }
        }
    }
}
