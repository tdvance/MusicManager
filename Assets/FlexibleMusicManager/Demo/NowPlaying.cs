using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NowPlaying : MonoBehaviour {

    public Text nowPlayingText;

    

	void Update () {
      
        if (FlexibleMusicManager.instance.CurrentTrackNumber() >= 0) {
            string timeText = SecondsToMS(FlexibleMusicManager.instance.TimeInSeconds());
            string lengthText = SecondsToMS(FlexibleMusicManager.instance.LengthInSeconds());

            nowPlayingText.text = "" + (FlexibleMusicManager.instance.CurrentTrackNumber() + 1) + ".  " + 
                FlexibleMusicManager.instance.NowPlaying().name
                + " (" + timeText + "/" + lengthText + ")" ;
        }else {
            nowPlayingText.text = "-----------------";
        }
	}

    string SecondsToMS(float seconds) {
        return string.Format("{0:D3}:{1:D2}", ((int)seconds)/60, ((int)seconds)%60);
    }
}
