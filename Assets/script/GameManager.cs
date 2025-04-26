using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.XR.CoreUtils;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

public class GameManager : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject losePanel;

    private bool gameEnded = false;

    public void WinGame()
    {
        if (gameEnded) return;
        gameEnded = true;

        winPanel.SetActive(true);

        // »œ· Time.timeScale = 0;
        DisablePlayerControls();
    }

    public void LoseGame()
    {
        if (gameEnded) return;
        gameEnded = true;

        losePanel.SetActive(true);

        // »œ· Time.timeScale = 0;
        DisablePlayerControls();
    }

    public void Retry()
    {
        Time.timeScale = 1f; // ≈⁄«œ… «·“„‰ ›ﬁÿ ›Ì Õ«· ⁄œ· Â „‰ ﬁ»·
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void DisablePlayerControls()
    {
        // ≈Ìﬁ«› XR Origin
        var origin = FindFirstObjectByType<XROrigin>();
        //if (origin != null)
        //{
        //    origin.gameObject.SetActive(false);
        //}

        // ≈Ìﬁ«› „Õ«ﬂÌ XR Device
        var simulator = FindFirstObjectByType<XRDeviceSimulator>();
        if (simulator != null)
        {
            simulator.gameObject.SetActive(false);
        }
    }

}
