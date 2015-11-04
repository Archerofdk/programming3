import java.awt.event.KeyEvent;
import java.io.FileNotFoundException;
import java.io.PrintWriter;

import com.theeyetribe.client.GazeManager;
import com.theeyetribe.client.IGazeListener;
import com.theeyetribe.client.data.GazeData;

public class GetData  implements IGazeListener
{
	public static double gX;
	public static double gY;
	private int x = 1920;
	private int y = 1080;
	private int framesLookedAtRight;
	private int framesLookedAtLeft;
	private int rightSeconds = framesLookedAtRight/30;
	private int leftSeconds = framesLookedAtLeft/30;
	
      
      
      GetData()
      {
            GazeManager.getInstance().activate(GazeManager.ApiVersion.VERSION_1_0, GazeManager.ClientMode.PUSH);
            GazeManager.getInstance().addGazeListener(this);
      }
      
      
      public void onGazeUpdate(GazeData gazeData)
      {
         //double gX = gazeData.rawCoordinates.x;
         //double gY = gazeData.rawCoordinates.y;
         gX = gazeData.smoothedCoordinates.x;
         gY = gazeData.smoothedCoordinates.y;
         
         
         /*try 
         {
			PrintWriter printOut = new PrintWriter(fileName);
			printOut.println("x = " + gX+ " y = "+ gY);
			if (e.getKeyCode() == KeyEvent.VK_ALT)
			 {
				 printOut.println("Times looked at right: "+ rightSeconds);
				 printOut.println("Times looked at left: "+ leftSeconds);
				 printOut.close();
				 System.exit(0);
			 }
		} catch (FileNotFoundException e) 
         {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}*/
      }
}