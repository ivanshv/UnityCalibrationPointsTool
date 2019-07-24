using UnityEngine; using System.Collections;

public class curs : MonoBehaviour 
{ 
    public Texture2D cursorImage;

 private int cursorWidth = 200;
 private int cursorHeight = 200;
 public float horizontalSpeed = 2.0F;
 public float verticalSpeed = 2.0F;
 
 private Vector2 cursorPosition;

private void Start()
{
    Cursor.visible = false;

    // optional place it in the center on start
    cursorPosition = new Vector2(Screen.width/2f, Screen.height/2f);
}

private void OnGUI()
{
    // these are not actual positions but the change between last frame and now
    float h = horizontalSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
    float v = verticalSpeed * Input.GetAxis("Vertical") * Time.deltaTime;

    // add the changes to the actual cursor position
    cursorPosition.x += h;
    cursorPosition.y += v;

    GUI.DrawTexture(new Rect(cursorPosition.x, Screen.height - cursorPosition.y, cursorWidth, cursorHeight), cursorImage);
}
public void Update()
    {
    if(Input.GetButtonDown("Fire1"))
		{
			Debug.Log(cursorPosition.x.ToString("F4") + ", " +cursorPosition.y.ToString("F4"));
		}
    }

}