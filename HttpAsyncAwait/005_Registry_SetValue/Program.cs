using Microsoft.Win32;

namespace _005_Registry_SetValue
{
    class Program
    {
        //Редактирование реестра
        static void Main(string[] args)
        {
            //Совершаем навигацию в нужное место и открываем его для записи.
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey softwareKey = currentUserKey.OpenSubKey("Software", true);
            RegistryKey testFolderKey = softwareKey?.CreateSubKey("TestFolder");

            //Совершаем запись в реестр
            testFolderKey?.SetValue("TheStringName", "I contain string value");
            testFolderKey?.SetValue("TheInt32Name", 1234567890); //REG_DWORD - двойное машинное слово (4 байта)

            //Тип можно указать явно
            testFolderKey?.SetValue("AnotherName", 1234567890, RegistryValueKind.String);

            softwareKey?.Close();
        }
    }
}
