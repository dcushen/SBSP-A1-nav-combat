using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class GameController : MonoBehaviour{
    public GameObject EnemyKamikazeShip, ourShip;
    public Vector3 spawnValues;
    public int enemyCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public Button restart;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnEnemies());
	}
	
	// Update is called once per frame
	void Update () {
        isGameOver();
	}

    void isGameOver()
    {
        ourShip = GameObject.FindWithTag("Ship");
        if(ourShip == null)
        {
            Application.LoadLevel("gameOverScene");
        }
    }

    void restartGame()
    {
        UnityEngine.UI.Button button = GameObject.Find("Start game").GetComponent<UnityEngine.UI.Button>();
        button.onClick.AddListener(newGame);
    }

    void newGame()
    {
        Application.LoadLevel("MainSceneV003");
    }
    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < enemyCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(EnemyKamikazeShip, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
