using UnityEngine.Audio;
using UnityEngine;

public class GameMusic : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        FindAnyObjectByType<AudioManager>().Play("GameMusic");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StopGameMusic()
    {
        // Stop the game music
        FindObjectOfType<AudioManager>().Stop("GameMusic");
    }

    public void deathEffect()
    {
        // Play the death effect
        FindObjectOfType<AudioManager>().Play("DeathEffect");
    }
}
