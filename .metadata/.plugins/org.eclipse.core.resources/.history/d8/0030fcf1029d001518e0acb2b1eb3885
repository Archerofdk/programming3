
import java.awt.*;
import java.util.*;
import java.awt.event.*;
import java.io.*;
import java.net.*;

class ClientSide
{
	int i;
    Socket s;
    DataInputStream din;
    DataOutputStream dout;
    String fileName = "D:\\Desktop\\giraffe.jpg";
    
    public void Client()
    {
    	 try {   
    	        s=new Socket("localhost",7861);
    	        System.out.println(s);
    	        din=new DataInputStream(s.getInputStream());
    	        dout=new DataOutputStream(s.getOutputStream());
    	            }catch(Exception e)
    	                          {
    	                             System.out.println(e);
    	                          }
    	 try {
             
             File file = new File(fileName);
             FileInputStream fin = new FileInputStream(file);   
             dout.writeUTF(fileName);
             System.out.println("Sending image...");
             byte[] readData = new byte[1024];

             while((i = fin.read(readData)) != -1)
                     {
                     dout.write(readData, 0, i);
                     }
                     System.out.println("Image sent");
                     fin.close();
             }catch(IOException ex)
               {
            	 System.out.println("Image ::"+ex);
               }
    }
}