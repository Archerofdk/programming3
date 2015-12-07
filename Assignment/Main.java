import java.io.IOException;
import java.net.UnknownHostException;


public class Main {

	public static void main(String[] args) throws UnknownHostException, IOException, InterruptedException {
		ClientSide client = new ClientSide();
		
		ServerSide server = new ServerSide();
		
		while(true){
			server.StartConnect();
			client.Connect();
			client.Send(client.Connect());
			
			
		}
	}

}
