
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

import org.opencv.core.Core;
import org.opencv.core.Mat;
import org.opencv.core.Scalar;
import org.opencv.core.CvType;
import org.opencv.imgproc.Imgproc;
import org.opencv.highgui.Highgui;
	
public class somethingsomething
{

		private static int n = 1;
		static String last;
		static { System.loadLibrary( Core.NATIVE_LIBRARY_NAME ); }
		
		/*public static void main(String[] args) throws IOException 
		{
			
		}*/
		public void run ()
		{
			Mat image = Highgui.imread(getClass().getResource("/lena.png").getPath());
		}
		
		
		public static void ReadTest () throws IOException
		{
			
			//for (int n = 1; n<123; n++)
			//{
				BufferedReader input = new BufferedReader(new FileReader("D:\\Desktop\\Medialogy\\P3\\DataFiles\\Test"+n+".txt"));
				String line;
				
				while ((line = input.readLine()) != null) 
			    {
			        last = line;
			        String[] PageData = last.split(";");
			      
			        //fra 0 til 6
			        double FirstCheck = Double.parseDouble (PageData[4]);
			        if (FirstCheck != 0)
			        {
			        	String PageLocation = PageData[2];
			        	if (PageLocation.equals("http://testserver3.weebly.com/"))
			        	{
			        		
			        		  
			        	
			        		
			        	}
			        }
			    }
			//}
		}
}
