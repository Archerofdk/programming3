import com.theeyetribe.client.GazeManager;
import com.theeyetribe.client.IGazeListener;
import com.theeyetribe.client.data.GazeData;

public class GetData  implements IGazeListener
{
	public static double gX;
	public static double gY;
	
      
      GetData()
      {
            GazeManager.getInstance().activate(GazeManager.ApiVersion.VERSION_1_0, GazeManager.ClientMode.PUSH);
            GazeManager.getInstance().addGazeListener(this);
      }
      
      
      public void onGazeUpdate(GazeData gazeData)
      {
         gX = gazeData.smoothedCoordinates.x;
         gY = gazeData.smoothedCoordinates.y;
      }
}