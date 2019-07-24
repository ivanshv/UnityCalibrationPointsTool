using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
using UnityEngine.UI;

public class SendToCsv81 : MonoBehaviour
  {
      private List<string[]> rowData = new List<string[]>();
      public List<string> UV = new List<string>(); //String with values from which to pick
      private int uvIndex = 0;
      public Texture2D cursorImage;

      private int cursorWidth = 70;
      private int cursorHeight = 70;
      //private Vector2 cursorHotSpot;
      public float horizontalSpeed = 2.0F;
      public float verticalSpeed = 2.0F;
 
      private Vector2 cursorPosition;
      
  
      void Start()
      {
          UV.Add("0");
          UV.Add("0");
          UV.Add("0"); 
          UV.Add("0.125");
          UV.Add("0"); 
          UV.Add("0.25");
          UV.Add("0"); 
          UV.Add("0.375");
          UV.Add("0");
          UV.Add("0.5");
          UV.Add("0"); 
          UV.Add("0.625");
          UV.Add("0");
          UV.Add("0.75");
          UV.Add("0"); 
          UV.Add("0.875");
          UV.Add("0");
          UV.Add("1");
          UV.Add("0.125");
          UV.Add("0");
          UV.Add("0.125"); 
          UV.Add("0.125");
          UV.Add("0.125"); 
          UV.Add("0.25");
          UV.Add("0.125"); 
          UV.Add("0.375");
          UV.Add("0.125");
          UV.Add("0.5");
          UV.Add("0.125"); 
          UV.Add("0.625");
          UV.Add("0.125");
          UV.Add("0.75");
          UV.Add("0.125"); 
          UV.Add("0.875");
          UV.Add("0.125");
          UV.Add("1");
          UV.Add("0.25");
          UV.Add("0");
          UV.Add("0.25"); 
          UV.Add("0.125");
          UV.Add("0.25"); 
          UV.Add("0.25");
          UV.Add("0.25"); 
          UV.Add("0.375");
          UV.Add("0.25");
          UV.Add("0.5");
          UV.Add("0.25"); 
          UV.Add("0.625");
          UV.Add("0.25");
          UV.Add("0.75");
          UV.Add("0.25"); 
          UV.Add("0.875");
          UV.Add("0.25");
          UV.Add("1");
          UV.Add("0.375");
          UV.Add("0");
          UV.Add("0.375"); 
          UV.Add("0.125");
          UV.Add("0.375"); 
          UV.Add("0.25");
          UV.Add("0.375"); 
          UV.Add("0.375");
          UV.Add("0.375");
          UV.Add("0.5");
          UV.Add("0.375"); 
          UV.Add("0.625");
          UV.Add("0.375");
          UV.Add("0.75");
          UV.Add("0.375"); 
          UV.Add("0.875");
          UV.Add("0.375");
          UV.Add("1");
          UV.Add("0.5");
          UV.Add("0");
          UV.Add("0.5"); 
          UV.Add("0.125");
          UV.Add("0.5"); 
          UV.Add("0.25");
          UV.Add("0.5"); 
          UV.Add("0.375");
          UV.Add("0.5");
          UV.Add("0.5");
          UV.Add("0.5"); 
          UV.Add("0.625");
          UV.Add("0.5");
          UV.Add("0.75");
          UV.Add("0.5"); 
          UV.Add("0.875");
          UV.Add("0.5");
          UV.Add("1");
          UV.Add("0.625");
          UV.Add("0");
          UV.Add("0.625"); 
          UV.Add("0.125");
          UV.Add("0.625"); 
          UV.Add("0.25");
          UV.Add("0.625"); 
          UV.Add("0.375");
          UV.Add("0.625");
          UV.Add("0.5");
          UV.Add("0.625"); 
          UV.Add("0.625");
          UV.Add("0.625");
          UV.Add("0.75");
          UV.Add("0.625"); 
          UV.Add("0.875");
          UV.Add("0.625");
          UV.Add("1");
          UV.Add("0.75");
          UV.Add("0");
          UV.Add("0.75"); 
          UV.Add("0.125");
          UV.Add("0.75"); 
          UV.Add("0.25");
          UV.Add("0.75"); 
          UV.Add("0.375");
          UV.Add("0.75");
          UV.Add("0.5");
          UV.Add("0.75"); 
          UV.Add("0.625");
          UV.Add("0.75");
          UV.Add("0.75");
          UV.Add("0.75"); 
          UV.Add("0.875");
          UV.Add("0.75");
          UV.Add("1");
          UV.Add("0.875");
          UV.Add("0");
          UV.Add("0.875"); 
          UV.Add("0.125");
          UV.Add("0.875"); 
          UV.Add("0.25");
          UV.Add("0.875"); 
          UV.Add("0.375");
          UV.Add("0.875");
          UV.Add("0.5");
          UV.Add("0.875"); 
          UV.Add("0.625");
          UV.Add("0.875");
          UV.Add("0.75");
          UV.Add("0.875"); 
          UV.Add("0.875");
          UV.Add("0.875");
          UV.Add("1");
          UV.Add("1");
          UV.Add("0");
          UV.Add("1"); 
          UV.Add("0.125");
          UV.Add("1"); 
          UV.Add("0.25");
          UV.Add("1"); 
          UV.Add("0.375");
          UV.Add("1");
          UV.Add("0.5");
          UV.Add("1"); 
          UV.Add("0.625");
          UV.Add("1");
          UV.Add("0.75");
          UV.Add("1"); 
          UV.Add("0.875");
          UV.Add("1");
          UV.Add("1");  

          Cursor.visible = false;
          //cursorHotSpot = new Vector2(cursorImage.width / 2, cursorImage.height / 2);
          //Cursor.SetCursor(cursorImage, cursorHotSpot, CursorMode.Auto);

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
  
      void Update()
      {
          

          if (Input.GetButtonDown("Fire2"))
          {
              string[] rowDataTemp = new string[4];
              rowDataTemp[0] = cursorPosition.x.ToString("F4"); // X
              rowDataTemp[1] = cursorPosition.y.ToString("F4"); // Y
              rowDataTemp[2] = UV[uvIndex];
              rowDataTemp[3] = UV[uvIndex+1];
              rowData.Add(rowDataTemp);
              uvIndex += 2;
  
              string[][] output = new string[rowData.Count][];
  
              for (int i = 0; i < output.Length; i++)
              {
                  output[i] = rowData[i];
              }
  
              int length = output.GetLength(0);
              string delimiter = ", ";
  
              StringBuilder sb = new StringBuilder();
  
              for (int index = 0; index < length; index++)
                  sb.AppendLine(string.Join(delimiter, output[index]));
  
              string filePath = getPath();
  
              StreamWriter outStream = System.IO.File.CreateText(filePath);
              outStream.WriteLine(sb);
              outStream.Close();
          }
          if(Input.GetButtonDown("Fire2"))
		    {
			Debug.Log(cursorPosition.x.ToString("F4") + ", " +cursorPosition.y.ToString("F4"));
		    }
      }

      
    
   
    
    // Following method is used to retrive the relative path as device platform
    public string getPath(){
#if UNITY_EDITOR
return Application.dataPath +"/CSV/"+"Saved_data.csv";
#elif UNITY_ANDROID
return Application.persistentDataPath+"Saved_data.csv";
#elif UNITY_IPHONE
return Application.persistentDataPath+"/"+"Saved_data.csv";
#else
return Application.dataPath +"/"+"Saved_data.csv";
#endif
}
}