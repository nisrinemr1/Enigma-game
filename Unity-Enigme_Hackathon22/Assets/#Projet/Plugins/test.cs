using System.Runtime.InteropServices;

public static class Test{
    [DllImport("__Internal")]
    public static extern string GetTextValue();
    [DllImport("__Internal")]
    public static extern string TestFlemmard();

}