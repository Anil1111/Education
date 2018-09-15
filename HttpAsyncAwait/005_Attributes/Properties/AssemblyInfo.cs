using System.Configuration.Assemblies;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

//Предназначен для хранения хэш-алгоритма для чтения хэш-значений из манифеста сборки.
[assembly:AssemblyAlgorithmId(AssemblyHashAlgorithm.MD5)]

//Определяет компанию-разработика сборки.
//С его помощью компилятор помещает название компании в заголовок исполняемого файла.
[assembly: AssemblyCompany("Roman Borodavka Company")]

//Задаем тип сборки, например DEBUG (отладочная версия), или RELEASE (окончательный выпуск).
//В Visual Studio данный тип обычно назначает пользователь, при необходимости его можно переопределить.
[assembly: AssemblyConfiguration("")]

//Задает сведения об авторских правах
[assembly: AssemblyCopyright("Copyright ©  2018")]

//Задает культуру сборки. Например: Немецкая культура - [assembly: AssemblyCulture("de")]
//Обычно сборкам назначается нейтральная культура.
[assembly: AssemblyCulture("")]

//Упрощает имя сборки, если имя сборки слишком витиевато.
[assembly:AssemblyDefaultAlias("SimpleName")]

//Определяет, получит ли сборка после компиляции строгое имя (цифровую подпись)
//При работе с данным атрибутом нужно предоставить атрибут AssemblyKeyFile, определяющий временный ключ
[assembly:AssemblyDelaySign(true)]

//Позволяет снабдить сборку комментариями
[assembly: AssemblyDescription("Some comment")]

//Предназначен для определения версии файла сборки. Версию сборки можно прочитать из файла версий.
//Если файл версий недоступен, используется значение версии из атрибута
[assembly: AssemblyFileVersion("1.0.0.0")]


//Определяет значения AssemblyNameFlags для сборки:
//    EnableJITcompileOptimizer - Активирует оптимизацию JIT-компилятора
//    EnableJITcompileTracking  - Активирует мониторинг JIT-компилятора
//    None                      - Отменяет действие флагов
//    PublicKey                 - Генерирует новый открытый ключ сборки
//    Retargetable              - Позволяет связать сборку с другим издателем
[assembly:AssemblyFlags(AssemblyNameFlags.EnableJITcompileOptimizer| AssemblyNameFlags.EnableJITcompileOptimizer)]

//Определяет версию только для ознакомительных целей.
//Использующая среда не использует это значение для управления версиями сбрки во время выполнения или 
[assembly:AssemblyInformationalVersion("1.0.0.1")]

//Задает путь к файлу ключа для цифровой подписи (сздания строгого имени) для данной сборки.
//Например:
//[assembly: AssemblyKeyFile("../key.snk")]

//Определяет заголовок сборки в манифесте
[assembly: AssemblyTitle("005_Attributes")]

//Задает сведения о торговой марке или данной сборки
[assembly:AssemblyTrademark("CyberBionic Systematics")]

//Задает версию сборки.
//Информация о версии для сборки содержит четыре следующих атрибута:
//        Major Version - Старший номер версии
//        Minor Version - Младший номер версии
//        Build Number  - Номер сборки
//        Revision      - Ревизия
//Вы может указать значения или ставить значения по умолчанию ля Build Numbers и Revision используя знак *
//Например: [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]

//Определяет пользоватеьский атрибут имени продукта для манифеста сборки
[assembly: AssemblyProduct("005_Attributes")]

//Управляет доступностью утдельного управляемого типа или члена для всех типов с сборки для COM
[assembly: ComVisible(false)]

// Предоставляет явный идентификатор System.Guid в случае, когда использвание автоматического идентификтора....
// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("33c6f9e3-0029-4650-a6b8-5c6e8ba519d9")]