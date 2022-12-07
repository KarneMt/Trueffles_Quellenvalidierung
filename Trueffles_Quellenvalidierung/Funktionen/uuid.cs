namespace Trueffles_Quellenvalidierung.Funktionen
{
    public class uuid
    {
        public string CreateUUID()
        {
            Guid myuuid = Guid.NewGuid();
            string myuuidString = myuuid.ToString();
            return myuuidString;
        }
    }
}
