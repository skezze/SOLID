namespace ISP;

public class Good
{
    public interface IOpenDoor
    {
        public void OpenDoor();
    }
    public interface IFill
    {
        public void Fill();
    }
    public class Transport:IFill,IOpenDoor
    {
        
        public void OpenDoor()
        {
        }

        public void Fill()
        {
        }
    }
}