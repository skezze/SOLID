namespace ISP;

public class Bad
{

    public interface ITransport
    {
        public void OpenDoor();
        public void Fill();
    }
    public class Transport:ITransport
    {
        public void OpenDoor()
        {
        }

        public void Fill()
        {
        }
    }
    
    
}
